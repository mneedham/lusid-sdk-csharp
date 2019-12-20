using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace Finbourne.SdkConfig.Tests
{
    public class ApiConfigurationBuilderTests
    {
        [SetUp]
        public void Setup()
        {
            // Ensure that there are no environment variables
            Environment.SetEnvironmentVariable("FBN_LUSID_API_URL", null);
            Environment.SetEnvironmentVariable("FBN_TOKEN_URL", null);
            Environment.SetEnvironmentVariable("FBN_CLIENT_ID", null);
            Environment.SetEnvironmentVariable("FBN_USERNAME", null);
            Environment.SetEnvironmentVariable("FBN_PASSWORD", null);
            Environment.SetEnvironmentVariable("FBN_APP_NAME", null);
        }

        [Test]
        public void CanCreateUsingEnvironmentVariables()
        {
            // GIVEN a path to a secrets file and a set of environment variables
            var secretsFilePath = "dummy-secrets.json";
            Assert.That(File.Exists(secretsFilePath), $"Secrets file {secretsFilePath} needs to exist");

            string testApiUrl = "https://test.com/";
            Environment.SetEnvironmentVariable("FBN_LUSID_API_URL", testApiUrl);

            var testTokenUrl = "https://test.okta.com/";
            Environment.SetEnvironmentVariable("FBN_TOKEN_URL", testTokenUrl);

            var testClientId = "xyz";
            Environment.SetEnvironmentVariable("FBN_CLIENT_ID", testClientId);

            var testUserName = "testuser";
            Environment.SetEnvironmentVariable("FBN_USERNAME", testUserName);

            var testPassword = "abc123";
            Environment.SetEnvironmentVariable("FBN_PASSWORD", testPassword);

            var testApplicationName = "TestApp";
            Environment.SetEnvironmentVariable("FBN_APP_NAME", testApplicationName);

            // WHEN a configuration is created
            var config = ApiConfigurationBuilder.Build(secretsFilePath);

            // THEN the environment variables take precedence
            Assert.That(config.ApiUrl.AbsoluteUri, Is.EqualTo(testApiUrl));
            Assert.That(config.TokenUrl.AbsoluteUri, Is.EqualTo(testTokenUrl));
            Assert.That(config.ClientId, Is.EqualTo(testClientId));
            Assert.That(config.Username, Is.EqualTo(testUserName));
            Assert.That(config.Password, Is.EqualTo(testPassword));
            Assert.That(config.ApplicationName, Is.EqualTo(testApplicationName));
        }

        [Test]
        public void CanCreateUsingRelativeSecretsFilePath()
        {
            // GIVEN a relative path to a secrets file
            var secretsFilePath = "dummy-secrets.json";

            // WHEN a configuration is created with the secrets file path
            var config = ApiConfigurationBuilder.Build(secretsFilePath);

            // THEN everything is loaded from the secrets file
            Assert.That(config.ApiUrl.AbsoluteUri, Is.EqualTo("https://finbourne.com/"));
            Assert.That(config.TokenUrl.AbsoluteUri, Is.EqualTo("https://finbourne.okta.com/"));
            Assert.That(config.Username, Is.EqualTo("TestUserId"));
            Assert.That(config.Password, Is.EqualTo("TestPassword"));
            Assert.That(config.ClientId, Is.EqualTo("TestClientId"));
            Assert.That(config.ClientSecret, Is.EqualTo("TestClientSecret"));
            Assert.That(config.ApplicationName, Is.EqualTo("TestApplication"));
        }

        [Test]
        public void CanCreateUsingAbsoluteSecretsFilePath()
        {
            // GIVEN an absolute path to a secrets file
            var secretsFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "dummy-secrets.json");
            Assert.That(Path.IsPathRooted(secretsFilePath), Is.True, "File path should be absolute for this test");

            // WHEN a configuration is created using it
            var config = ApiConfigurationBuilder.Build(secretsFilePath);

            // THEN everything is loaded correctly from the secrets file
            Assert.That(config.ApiUrl.AbsoluteUri, Is.EqualTo("https://finbourne.com/"));
            Assert.That(config.TokenUrl.AbsoluteUri, Is.EqualTo("https://finbourne.okta.com/"));
            Assert.That(config.Username, Is.EqualTo("TestUserId"));
            Assert.That(config.Password, Is.EqualTo("TestPassword"));
            Assert.That(config.ClientId, Is.EqualTo("TestClientId"));
            Assert.That(config.ClientSecret, Is.EqualTo("TestClientSecret"));
            Assert.That(config.ApplicationName, Is.EqualTo("TestApplication"));
        }

        [Test]
        public void CanAddAdditionalParameters()
        {
            // GIVEN a config loaded from a secrets file with no additional parameters
            var config = ApiConfigurationBuilder.Build("dummy-secrets.json");
            Assert.That(config.AdditionalParameters, Is.Empty);

            // WHEN an additional parameter is added
            config = config.WithAdditionalParameter("additional", "value");

            // THEN the config has the additional parameters
            Assert.That(config.AdditionalParameters,
                Is.EquivalentTo(new [] { new KeyValuePair<string, string>("additional", "value")}));
        }

        [Test]
        public void ThrowsExceptionForMissingEnvironmentVariables()
        {
            Assert.That(Environment.GetEnvironmentVariable("FBN_LUSID_API_URL"), Is.Null);
            Assert.That(Environment.GetEnvironmentVariable("FBN_TOKEN_URL"), Is.Null);
            Assert.That(Environment.GetEnvironmentVariable("FBN_CLIENT_ID"), Is.Null);
            Assert.That(Environment.GetEnvironmentVariable("FBN_USERNAME"), Is.Null);
            Assert.That(Environment.GetEnvironmentVariable("FBN_PASSWORD"), Is.Null);
            Assert.That(Environment.GetEnvironmentVariable("FBN_APP_NAME"), Is.Null);

            Assert.That(
                () => ApiConfigurationBuilder.Build(),
                Throws.ArgumentException.With.Message.EqualTo("Please supply the following values: ApiUrl,TokenUrl,Username,Password,ClientId,ApplicationName"));
        }
    }
}
