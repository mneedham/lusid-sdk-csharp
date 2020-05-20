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
    /// VersionSummaryDto
    /// </summary>
    [DataContract]
    public partial class VersionSummaryDto :  IEquatable<VersionSummaryDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionSummaryDto" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        public VersionSummaryDto(List<Link> links = default(List<Link>))
        {
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or Sets BuildVersion
        /// </summary>
        [DataMember(Name="buildVersion", EmitDefaultValue=false)]
        public string BuildVersion { get; private set; }

        /// <summary>
        /// Gets or Sets ExcelVersion
        /// </summary>
        [DataMember(Name="excelVersion", EmitDefaultValue=false)]
        public string ExcelVersion { get; private set; }

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
            sb.Append("class VersionSummaryDto {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  ExcelVersion: ").Append(ExcelVersion).Append("\n");
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
            return this.Equals(input as VersionSummaryDto);
        }

        /// <summary>
        /// Returns true if VersionSummaryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionSummaryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionSummaryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.BuildVersion == input.BuildVersion ||
                    (this.BuildVersion != null &&
                    this.BuildVersion.Equals(input.BuildVersion))
                ) && 
                (
                    this.ExcelVersion == input.ExcelVersion ||
                    (this.ExcelVersion != null &&
                    this.ExcelVersion.Equals(input.ExcelVersion))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.BuildVersion != null)
                    hashCode = hashCode * 59 + this.BuildVersion.GetHashCode();
                if (this.ExcelVersion != null)
                    hashCode = hashCode * 59 + this.ExcelVersion.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
