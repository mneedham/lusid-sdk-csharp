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
    /// ReferencePortfolioConstituentRequest
    /// </summary>
    [DataContract]
    public partial class ReferencePortfolioConstituentRequest :  IEquatable<ReferencePortfolioConstituentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePortfolioConstituentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferencePortfolioConstituentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePortfolioConstituentRequest" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">Unique instrument identifiers (required).</param>
        /// <param name="properties">properties.</param>
        /// <param name="weight">weight (required).</param>
        /// <param name="currency">currency.</param>
        public ReferencePortfolioConstituentRequest(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), decimal? weight = default(decimal?), string currency = default(string))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new InvalidDataException("instrumentIdentifiers is a required property for ReferencePortfolioConstituentRequest and cannot be null");
            }
            else
            {
                this.InstrumentIdentifiers = instrumentIdentifiers;
            }
            
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for ReferencePortfolioConstituentRequest and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            
            this.Properties = properties;
            this.Currency = currency;
        }
        
        /// <summary>
        /// Unique instrument identifiers
        /// </summary>
        /// <value>Unique instrument identifiers</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferencePortfolioConstituentRequest {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as ReferencePortfolioConstituentRequest);
        }

        /// <summary>
        /// Returns true if ReferencePortfolioConstituentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferencePortfolioConstituentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferencePortfolioConstituentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }

}
