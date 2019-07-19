using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Client;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// An extended ApiException factory to add in the request id
    /// </summary>
    public class ApiExceptionExtensionsFactory
    {
        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory ExtendedExceptionFactory = (methodName, response) =>
        {

            var status = (int) response.StatusCode;
            if (status >= 400)

            {
                return new ApiExceptionExtended(status,
                    string.Format("Error calling {0}: {1}", methodName, response.Content),
                    response.Headers.GetValues("lusid-meta-requestId").First(),
                    response.Content);
            }

            return null;
        };
    };
};