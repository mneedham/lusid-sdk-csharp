using System;

namespace Finbourne.SdkConfig.TokenProvider
{
    /// <summary>
    /// A token issued by a Token provider
    /// </summary>
    public class AuthenticationToken
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AuthenticationToken(string token, DateTimeOffset expiresOn, string refreshToken)
        {
            Token = token;
            ExpiresOn = expiresOn;
            RefreshToken = refreshToken;
        }

        /// <summary>
        /// The token
        /// </summary>
        public string Token { get; }
        
        /// <summary>
        /// When this token expires
        /// </summary>
        public DateTimeOffset ExpiresOn { get; internal set; }

        /// <summary>
        /// The refresh token
        /// </summary>
        public string RefreshToken { get; }
    }
}
