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
    /// A reconciliation break
    /// </summary>
    [DataContract]
    public partial class ReconciliationBreak :  IEquatable<ReconciliationBreak>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconciliationBreak" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReconciliationBreak() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconciliationBreak" /> class.
        /// </summary>
        /// <param name="instrumentUid">Unique instrument identifier (required).</param>
        /// <param name="subHoldingKeys">Any other properties that comprise the Sub-Holding Key (required).</param>
        /// <param name="leftUnits">Units from the left hand side (required).</param>
        /// <param name="rightUnits">Units from the right hand side (required).</param>
        /// <param name="differenceUnits">Difference in units (required).</param>
        /// <param name="leftCost">leftCost (required).</param>
        /// <param name="rightCost">rightCost (required).</param>
        /// <param name="differenceCost">differenceCost (required).</param>
        /// <param name="instrumentProperties">Additional features relating to the instrument (required).</param>
        public ReconciliationBreak(string instrumentUid = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), decimal? leftUnits = default(decimal?), decimal? rightUnits = default(decimal?), decimal? differenceUnits = default(decimal?), CurrencyAndAmount leftCost = default(CurrencyAndAmount), CurrencyAndAmount rightCost = default(CurrencyAndAmount), CurrencyAndAmount differenceCost = default(CurrencyAndAmount), List<Property> instrumentProperties = default(List<Property>))
        {
            // to ensure "instrumentUid" is required (not null)
            if (instrumentUid == null)
            {
                throw new InvalidDataException("instrumentUid is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.InstrumentUid = instrumentUid;
            }
            
            // to ensure "subHoldingKeys" is required (not null)
            if (subHoldingKeys == null)
            {
                throw new InvalidDataException("subHoldingKeys is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.SubHoldingKeys = subHoldingKeys;
            }
            
            // to ensure "leftUnits" is required (not null)
            if (leftUnits == null)
            {
                throw new InvalidDataException("leftUnits is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.LeftUnits = leftUnits;
            }
            
            // to ensure "rightUnits" is required (not null)
            if (rightUnits == null)
            {
                throw new InvalidDataException("rightUnits is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.RightUnits = rightUnits;
            }
            
            // to ensure "differenceUnits" is required (not null)
            if (differenceUnits == null)
            {
                throw new InvalidDataException("differenceUnits is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.DifferenceUnits = differenceUnits;
            }
            
            // to ensure "leftCost" is required (not null)
            if (leftCost == null)
            {
                throw new InvalidDataException("leftCost is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.LeftCost = leftCost;
            }
            
            // to ensure "rightCost" is required (not null)
            if (rightCost == null)
            {
                throw new InvalidDataException("rightCost is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.RightCost = rightCost;
            }
            
            // to ensure "differenceCost" is required (not null)
            if (differenceCost == null)
            {
                throw new InvalidDataException("differenceCost is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.DifferenceCost = differenceCost;
            }
            
            // to ensure "instrumentProperties" is required (not null)
            if (instrumentProperties == null)
            {
                throw new InvalidDataException("instrumentProperties is a required property for ReconciliationBreak and cannot be null");
            }
            else
            {
                this.InstrumentProperties = instrumentProperties;
            }
            
        }
        
        /// <summary>
        /// Unique instrument identifier
        /// </summary>
        /// <value>Unique instrument identifier</value>
        [DataMember(Name="instrumentUid", EmitDefaultValue=false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Any other properties that comprise the Sub-Holding Key
        /// </summary>
        /// <value>Any other properties that comprise the Sub-Holding Key</value>
        [DataMember(Name="subHoldingKeys", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// Units from the left hand side
        /// </summary>
        /// <value>Units from the left hand side</value>
        [DataMember(Name="leftUnits", EmitDefaultValue=false)]
        public decimal? LeftUnits { get; set; }

        /// <summary>
        /// Units from the right hand side
        /// </summary>
        /// <value>Units from the right hand side</value>
        [DataMember(Name="rightUnits", EmitDefaultValue=false)]
        public decimal? RightUnits { get; set; }

        /// <summary>
        /// Difference in units
        /// </summary>
        /// <value>Difference in units</value>
        [DataMember(Name="differenceUnits", EmitDefaultValue=false)]
        public decimal? DifferenceUnits { get; set; }

        /// <summary>
        /// Gets or Sets LeftCost
        /// </summary>
        [DataMember(Name="leftCost", EmitDefaultValue=false)]
        public CurrencyAndAmount LeftCost { get; set; }

        /// <summary>
        /// Gets or Sets RightCost
        /// </summary>
        [DataMember(Name="rightCost", EmitDefaultValue=false)]
        public CurrencyAndAmount RightCost { get; set; }

        /// <summary>
        /// Gets or Sets DifferenceCost
        /// </summary>
        [DataMember(Name="differenceCost", EmitDefaultValue=false)]
        public CurrencyAndAmount DifferenceCost { get; set; }

        /// <summary>
        /// Additional features relating to the instrument
        /// </summary>
        /// <value>Additional features relating to the instrument</value>
        [DataMember(Name="instrumentProperties", EmitDefaultValue=false)]
        public List<Property> InstrumentProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReconciliationBreak {\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  LeftUnits: ").Append(LeftUnits).Append("\n");
            sb.Append("  RightUnits: ").Append(RightUnits).Append("\n");
            sb.Append("  DifferenceUnits: ").Append(DifferenceUnits).Append("\n");
            sb.Append("  LeftCost: ").Append(LeftCost).Append("\n");
            sb.Append("  RightCost: ").Append(RightCost).Append("\n");
            sb.Append("  DifferenceCost: ").Append(DifferenceCost).Append("\n");
            sb.Append("  InstrumentProperties: ").Append(InstrumentProperties).Append("\n");
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
            return this.Equals(input as ReconciliationBreak);
        }

        /// <summary>
        /// Returns true if ReconciliationBreak instances are equal
        /// </summary>
        /// <param name="input">Instance of ReconciliationBreak to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReconciliationBreak input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.LeftUnits == input.LeftUnits ||
                    (this.LeftUnits != null &&
                    this.LeftUnits.Equals(input.LeftUnits))
                ) && 
                (
                    this.RightUnits == input.RightUnits ||
                    (this.RightUnits != null &&
                    this.RightUnits.Equals(input.RightUnits))
                ) && 
                (
                    this.DifferenceUnits == input.DifferenceUnits ||
                    (this.DifferenceUnits != null &&
                    this.DifferenceUnits.Equals(input.DifferenceUnits))
                ) && 
                (
                    this.LeftCost == input.LeftCost ||
                    (this.LeftCost != null &&
                    this.LeftCost.Equals(input.LeftCost))
                ) && 
                (
                    this.RightCost == input.RightCost ||
                    (this.RightCost != null &&
                    this.RightCost.Equals(input.RightCost))
                ) && 
                (
                    this.DifferenceCost == input.DifferenceCost ||
                    (this.DifferenceCost != null &&
                    this.DifferenceCost.Equals(input.DifferenceCost))
                ) && 
                (
                    this.InstrumentProperties == input.InstrumentProperties ||
                    this.InstrumentProperties != null &&
                    input.InstrumentProperties != null &&
                    this.InstrumentProperties.SequenceEqual(input.InstrumentProperties)
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
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                if (this.LeftUnits != null)
                    hashCode = hashCode * 59 + this.LeftUnits.GetHashCode();
                if (this.RightUnits != null)
                    hashCode = hashCode * 59 + this.RightUnits.GetHashCode();
                if (this.DifferenceUnits != null)
                    hashCode = hashCode * 59 + this.DifferenceUnits.GetHashCode();
                if (this.LeftCost != null)
                    hashCode = hashCode * 59 + this.LeftCost.GetHashCode();
                if (this.RightCost != null)
                    hashCode = hashCode * 59 + this.RightCost.GetHashCode();
                if (this.DifferenceCost != null)
                    hashCode = hashCode * 59 + this.DifferenceCost.GetHashCode();
                if (this.InstrumentProperties != null)
                    hashCode = hashCode * 59 + this.InstrumentProperties.GetHashCode();
                return hashCode;
            }
        }
    }

}
