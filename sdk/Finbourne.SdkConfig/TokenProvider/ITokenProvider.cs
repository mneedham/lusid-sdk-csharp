using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Finbourne.SdkConfig.TokenProvider
{
    /// <summary>
    /// Interface for an implementation to return access tokens
    /// </summary>
    public interface ITokenProvider
    {
        /// <summary>
        /// Return an access token
        /// </summary>
        Task<string> GetAuthenticationTokenAsync();

        /// <summary>
        /// Return an access token
        /// </summary>
        Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync();
    }
}
