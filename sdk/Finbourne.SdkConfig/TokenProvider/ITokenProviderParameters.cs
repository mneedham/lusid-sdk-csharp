using System;
using System.Collections.Generic;

namespace Finbourne.SdkConfig.TokenProvider
{
    /// <summary>
    /// Interface for parameters required for the TokenProvider
    /// </summary>
    public interface ITokenProviderParameters
    {
        /// <summary>
        /// Token issuer Url
        /// </summary>
        Uri TokenUrl { get; }

        /// <summary>
        /// Username
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Password
        /// </summary>
        string Password { get; }

        /// <summary>
        /// OAuth2 Client ID
        /// </summary>
        string ClientId { get; }

        /// <summary>
        /// OAuth2 Client Secret
        /// </summary>
        string ClientSecret { get; }

        /// <summary>
        /// OAuth2 Scope
        /// </summary>
        string Scope { get; }

        /// <summary>
        /// Additional parameters to be added to token request
        /// </summary>
        IEnumerable<KeyValuePair<string, string>> AdditionalParameters { get; }
    }
}
