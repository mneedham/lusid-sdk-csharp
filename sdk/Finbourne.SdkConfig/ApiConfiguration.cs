using System;
using System.Collections.Generic;
using Finbourne.SdkConfig.TokenProvider;

namespace Finbourne.SdkConfig
{
    /// <summary>
    /// Configuration for the ClientCredentialsFlowTokenProvider, for example sourced from a "secrets.json" file 
    /// </summary>
    public class ApiConfiguration : ITokenProviderParameters
    {
        private readonly IDictionary<string, string> _additionalParameters = new Dictionary<string, string>();

        /// <summary>
        /// LUSID Api Url
        /// </summary>
        public Uri ApiUrl { get; set; }

        /// <summary>
        /// Url for the token provider
        /// </summary>
        public Uri TokenUrl { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// OAuth2 Client ID
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// OAuth2 Client Secret
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// OAuth2 Scope
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Additional parameters to supply in the token request
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> AdditionalParameters => _additionalParameters;

        /// <summary>
        /// Client Application name
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Adds an additional parameter to this configuration
        /// </summary>
        public ApiConfiguration WithAdditionalParameter(string name, string value)
        {
            _additionalParameters[name] = value;

            return this;
        }
    }
}