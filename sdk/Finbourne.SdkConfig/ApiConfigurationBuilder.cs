using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Finbourne.SdkConfig
{
    /// <summary>
    /// Creates an ApiConfiguration 
    /// </summary>
    public static class ApiConfigurationBuilder
    {
        /// <summary>
        /// Builds an ApiConfiguration.  If the path to a secrets.json file is specified that will be used,
        /// otherwise the values will come from environment variables.
        ///
        /// For further details refer to https://github.com/finbourne/lusid-sdk-csharp/wiki/API-credentials
        /// </summary>
        /// <param name="apiSecretsFile">optional, filename of the secrets.json file</param>
        /// <returns>ApiConfiguration</returns>
        public static ApiConfiguration Build(string apiSecretsFile = null)
        {
            var apiConfig = new ApiConfiguration();

            // First read secrets file if it is supplied
            if (!string.IsNullOrEmpty(apiSecretsFile))
            {
                var builder = new ConfigurationBuilder();
                if (!Path.IsPathRooted(apiSecretsFile))
                {
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                }

                builder.AddJsonFile(apiSecretsFile);

                var config = builder.Build();

                config.GetSection("api").Bind(apiConfig);

                Console.WriteLine($"Loaded values from {apiSecretsFile}");
            }

            // Override with any environment variables
            var configType = typeof(ApiConfiguration);

            SetOverride(
                apiConfig, 
                configType.GetProperty(nameof(apiConfig.ApiUrl)), 
                ValidateUri(GetEnvVariable("FBN_LUSID_API_URL"), "LUSID Api Uri"));

            SetOverride(
                apiConfig,
                configType.GetProperty(nameof(apiConfig.TokenUrl)),
                ValidateUri(GetEnvVariable("FBN_TOKEN_URL"), "Token Uri"));

            SetOverride(
                apiConfig,
                configType.GetProperty(nameof(apiConfig.ClientId)),
                GetEnvVariable("FBN_CLIENT_ID"));

            SetOverride(
                apiConfig,
                configType.GetProperty(nameof(apiConfig.ClientSecret)),
                GetEnvVariable("FBN_CLIENT_SECRET"));

            SetOverride(
                apiConfig,
                configType.GetProperty(nameof(apiConfig.Username)),
                GetEnvVariable("FBN_USERNAME"));

            SetOverride(
                apiConfig,
                configType.GetProperty(nameof(apiConfig.Password)),
                GetEnvVariable("FBN_PASSWORD"));

            SetOverride(
                apiConfig,
                configType.GetProperty(nameof(apiConfig.ApplicationName)),
                GetEnvVariable("FBN_APP_NAME"));

            // Verify we have everything we need
            var missingFieldsError = IdentifyMissingFields(apiConfig).ToList();

            if (missingFieldsError.Any())
            {
                throw new ArgumentException($"Please supply the following values: {string.Join(",", missingFieldsError)}");
            }

            return apiConfig;
        }

        private static IEnumerable<string> IdentifyMissingFields(ApiConfiguration apiConfig)
        {
            if (apiConfig.ApiUrl == null)
            {
                yield return "ApiUrl";
            }

            if (apiConfig.TokenUrl == null)
            {
                yield return "TokenUrl";
            }

            if (string.IsNullOrEmpty(apiConfig.Username))
            {
                yield return "Username";
            }

            if (string.IsNullOrEmpty(apiConfig.Password))
            {
                yield return "Password";
            }

            if (string.IsNullOrEmpty(apiConfig.ClientId))
            {
                yield return "ClientId";
            }

            if (string.IsNullOrEmpty(apiConfig.ApplicationName))
            {
                yield return "ApplicationName";
            }

            // ClientSecret is not always required
        }

        private static string GetEnvVariable(string variable)
        {
            return Environment.GetEnvironmentVariable(variable.ToUpper()) ?? Environment.GetEnvironmentVariable(variable.ToLower());
        }

        private static Uri ValidateUri(string uri, string fieldName)
        {
            Uri result = null;

            if((uri != null) && (!Uri.TryCreate(uri, UriKind.Absolute, out result)))
            {
                throw new UriFormatException($"Invalid {fieldName}: {uri}");
            }

            return result;
        }

        private static void SetOverride(ApiConfiguration apiConfig, PropertyInfo property, object value)
        {
            if (value != null)
            {
                property.SetValue(apiConfig, value);
            }
        }
    }
}

