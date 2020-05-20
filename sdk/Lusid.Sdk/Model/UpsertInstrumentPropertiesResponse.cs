/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1388
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// UpsertInstrumentPropertiesResponse
    /// </summary>
    [DataContract]
    public partial class UpsertInstrumentPropertiesResponse :  IEquatable<UpsertInstrumentPropertiesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertInstrumentPropertiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertiesResponse" /> class.
        /// </summary>
        /// <param name="asAtDate">The asAt datetime at which the properties were updated or inserted on the specified instruments. (required).</param>
        /// <param name="links">links.</param>
        public UpsertInstrumentPropertiesResponse(DateTimeOffset? asAtDate = default(DateTimeOffset?), List<Link> links = default(List<Link>))
        {
            // to ensure "asAtDate" is required (not null)
            if (asAtDate == null)
            {
                throw new InvalidDataException("asAtDate is a required property for UpsertInstrumentPropertiesResponse and cannot be null");
            }
            else
            {
                this.AsAtDate = asAtDate;
            }
            
            this.Links = links;
        }
        
        /// <summary>
        /// The asAt datetime at which the properties were updated or inserted on the specified instruments.
        /// </summary>
        /// <value>The asAt datetime at which the properties were updated or inserted on the specified instruments.</value>
        [DataMember(Name="asAtDate", EmitDefaultValue=false)]
        public DateTimeOffset? AsAtDate { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertInstrumentPropertiesResponse {\n");
            sb.Append("  AsAtDate: ").Append(AsAtDate).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpsertInstrumentPropertiesResponse);
        }

        /// <summary>
        /// Returns true if UpsertInstrumentPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertInstrumentPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertInstrumentPropertiesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsAtDate == input.AsAtDate ||
                    (this.AsAtDate != null &&
                    this.AsAtDate.Equals(input.AsAtDate))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AsAtDate != null)
                    hashCode = hashCode * 59 + this.AsAtDate.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
