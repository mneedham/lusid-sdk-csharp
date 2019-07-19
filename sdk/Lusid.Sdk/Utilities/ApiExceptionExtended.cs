using System;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// API Exception Extended
    /// </summary>
    public class ApiExceptionExtended : Exception
    {
        /// <summary>
        /// Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error content (body json object)
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public dynamic ErrorContent { get; private set; }
        
        /// <summary>
        /// Gets or sets the request id
        /// </summary>
        /// <value>The request id (Inside Http response header).</value>
        public string RequestId { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiExceptionExtended"/> class.
        /// </summary>
        public ApiExceptionExtended() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiExceptionExtended"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiExceptionExtended(int errorCode, string message, string requestId, dynamic errorContent = null) : base(message)
        {
            this.ErrorCode = errorCode;
            this.ErrorContent = errorContent;
            this.RequestId = requestId;
        }
    }

}