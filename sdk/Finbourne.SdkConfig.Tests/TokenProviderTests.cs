using System;
using System.IO;
using System.Threading.Tasks;
using Finbourne.SdkConfig.TokenProvider;
using NUnit.Framework;

namespace Finbourne.SdkConfig.Tests
{
    /// <summary>
    ///  These tests require a local secrets.json file in the same directory, or the appropriate environment variables defined
    /// </summary>
    public class TokenProviderTests
    {
        private static ApiConfiguration GetConfig()
        {
            var apiConfig = ApiConfigurationBuilder.Build(
                Path.Combine(
                    TestContext.CurrentContext.TestDirectory.Replace("Finbourne.TokenProviders.Tests", "Lusid.Sdk.Tests"),
                    "secrets.json"));
            
            return apiConfig;
        }

        [Test]
        public async Task CanGetToken()
        {
            // GIVEN a token provider initialised with required secrets
            var provider = new ClientCredentialsFlowTokenProvider(GetConfig());

            // WHEN the token is requested
            var token = await provider.GetAuthenticationTokenAsync();

            // THEN it is populated
            Assert.That(token, Is.Not.Empty);
        }

        [Test]
        public async Task CanRefreshWithRefreshToken()
        {
            // GIVEN a token from the TokenProvider that contains a refresh token
            var provider = new ClientCredentialsFlowTokenProvider(GetConfig());
            var _ = await provider.GetAuthenticationTokenAsync();
            var firstTokenDetails = provider.GetLastToken();
            
            Assert.That(firstTokenDetails.RefreshToken, Is.Not.Null.And.Not.Empty, "refresh_token not returned so unable to verify refresh behaviour.  This requires the userid defined in secrets.json to be set to 'allow offline access' in Okta");

            Console.WriteLine($"Token expiring at {firstTokenDetails.ExpiresOn:o}");

            // WHEN we pretend to delay until the original token has expired (for expediency update the expires_on on the token)
            provider.ExpireToken();

            Assert.That(DateTimeOffset.UtcNow, Is.GreaterThan(firstTokenDetails.ExpiresOn));
            var refreshedToken = await provider.GetAuthenticationTokenAsync();

            // THEN it should be populated, and the ExpiresOn should be in the future
            Assert.That(refreshedToken, Is.Not.Empty);
            Assert.That(provider.GetLastToken().ExpiresOn, Is.GreaterThan(DateTimeOffset.UtcNow));
        }

        [Test, Explicit("Needs to have secrets.json file containing user without offline-access enabled")]
        public async Task CanRefreshWithoutToken()
        {
            // GIVEN a token from the TokenProvider that DOES NOT contain a refresh token
            var provider = new ClientCredentialsFlowTokenProvider(GetConfig());
            var _ = await provider.GetAuthenticationTokenAsync();
            var firstTokenDetails = provider.GetLastToken();

            Assert.That(firstTokenDetails.RefreshToken, Is.Null, "refresh_token was returned so unable to verify refresh behaviour with a token.  This requires the userid defined in secrets.json to be set to NOT 'allow offline access' in Okta");

            // WHEN we pretend to delay until the original token has expired (for expediency update the expires_on on the token)
            provider.ExpireToken();

            Assert.That(DateTimeOffset.UtcNow, Is.GreaterThan(firstTokenDetails.ExpiresOn));
            var refreshedToken = await provider.GetAuthenticationTokenAsync();

            // THEN it should be populated, and the ExpiresOn should be in the future
            Assert.That(refreshedToken, Is.Not.Empty);
            Assert.That(provider.GetLastToken().ExpiresOn, Is.GreaterThan(DateTimeOffset.UtcNow));
        }
    }
}
