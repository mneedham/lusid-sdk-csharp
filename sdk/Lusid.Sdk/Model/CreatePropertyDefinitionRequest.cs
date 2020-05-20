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
    /// CreatePropertyDefinitionRequest
    /// </summary>
    [DataContract]
    public partial class CreatePropertyDefinitionRequest :  IEquatable<CreatePropertyDefinitionRequest>
    {
        /// <summary>
        /// The domain that the property exists in.
        /// </summary>
        /// <value>The domain that the property exists in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DomainEnum
        {
            /// <summary>
            /// Enum NotDefined for value: NotDefined
            /// </summary>
            [EnumMember(Value = "NotDefined")]
            NotDefined = 1,

            /// <summary>
            /// Enum Transaction for value: Transaction
            /// </summary>
            [EnumMember(Value = "Transaction")]
            Transaction = 2,

            /// <summary>
            /// Enum Portfolio for value: Portfolio
            /// </summary>
            [EnumMember(Value = "Portfolio")]
            Portfolio = 3,

            /// <summary>
            /// Enum Holding for value: Holding
            /// </summary>
            [EnumMember(Value = "Holding")]
            Holding = 4,

            /// <summary>
            /// Enum ReferenceHolding for value: ReferenceHolding
            /// </summary>
            [EnumMember(Value = "ReferenceHolding")]
            ReferenceHolding = 5,

            /// <summary>
            /// Enum TransactionConfiguration for value: TransactionConfiguration
            /// </summary>
            [EnumMember(Value = "TransactionConfiguration")]
            TransactionConfiguration = 6,

            /// <summary>
            /// Enum Instrument for value: Instrument
            /// </summary>
            [EnumMember(Value = "Instrument")]
            Instrument = 7,

            /// <summary>
            /// Enum CutLabelDefinition for value: CutLabelDefinition
            /// </summary>
            [EnumMember(Value = "CutLabelDefinition")]
            CutLabelDefinition = 8,

            /// <summary>
            /// Enum Analytic for value: Analytic
            /// </summary>
            [EnumMember(Value = "Analytic")]
            Analytic = 9,

            /// <summary>
            /// Enum PortfolioGroup for value: PortfolioGroup
            /// </summary>
            [EnumMember(Value = "PortfolioGroup")]
            PortfolioGroup = 10,

            /// <summary>
            /// Enum Person for value: Person
            /// </summary>
            [EnumMember(Value = "Person")]
            Person = 11,

            /// <summary>
            /// Enum AccessMetadata for value: AccessMetadata
            /// </summary>
            [EnumMember(Value = "AccessMetadata")]
            AccessMetadata = 12,

            /// <summary>
            /// Enum Order for value: Order
            /// </summary>
            [EnumMember(Value = "Order")]
            Order = 13,

            /// <summary>
            /// Enum UnitResult for value: UnitResult
            /// </summary>
            [EnumMember(Value = "UnitResult")]
            UnitResult = 14,

            /// <summary>
            /// Enum MarketData for value: MarketData
            /// </summary>
            [EnumMember(Value = "MarketData")]
            MarketData = 15,

            /// <summary>
            /// Enum ConfigurationRecipe for value: ConfigurationRecipe
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipe")]
            ConfigurationRecipe = 16,

            /// <summary>
            /// Enum Allocation for value: Allocation
            /// </summary>
            [EnumMember(Value = "Allocation")]
            Allocation = 17

        }

        /// <summary>
        /// The domain that the property exists in.
        /// </summary>
        /// <value>The domain that the property exists in.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public DomainEnum Domain { get; set; }
        /// <summary>
        /// Describes how the property&#39;s values can change over time.
        /// </summary>
        /// <value>Describes how the property&#39;s values can change over time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LifeTimeEnum
        {
            /// <summary>
            /// Enum Perpetual for value: Perpetual
            /// </summary>
            [EnumMember(Value = "Perpetual")]
            Perpetual = 1,

            /// <summary>
            /// Enum TimeVariant for value: TimeVariant
            /// </summary>
            [EnumMember(Value = "TimeVariant")]
            TimeVariant = 2

        }

        /// <summary>
        /// Describes how the property&#39;s values can change over time.
        /// </summary>
        /// <value>Describes how the property&#39;s values can change over time.</value>
        [DataMember(Name="lifeTime", EmitDefaultValue=false)]
        public LifeTimeEnum? LifeTime { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePropertyDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePropertyDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePropertyDefinitionRequest" /> class.
        /// </summary>
        /// <param name="domain">The domain that the property exists in. (required).</param>
        /// <param name="scope">The scope that the property exists in. (required).</param>
        /// <param name="code">The code of the property. Together with the domain and scope this uniquely identifies the property. (required).</param>
        /// <param name="valueRequired">Whether or not a value is always required for this property..</param>
        /// <param name="displayName">The display name of the property. (required).</param>
        /// <param name="dataTypeId">dataTypeId (required).</param>
        /// <param name="lifeTime">Describes how the property&#39;s values can change over time..</param>
        /// <param name="constraintStyle">Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. Defaults to \&quot;Property\&quot; if not specified..</param>
        public CreatePropertyDefinitionRequest(DomainEnum domain = default(DomainEnum), string scope = default(string), string code = default(string), bool? valueRequired = default(bool?), string displayName = default(string), ResourceId dataTypeId = default(ResourceId), LifeTimeEnum? lifeTime = default(LifeTimeEnum?), string constraintStyle = default(string))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new InvalidDataException("domain is a required property for CreatePropertyDefinitionRequest and cannot be null");
            }
            else
            {
                this.Domain = domain;
            }
            
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new InvalidDataException("scope is a required property for CreatePropertyDefinitionRequest and cannot be null");
            }
            else
            {
                this.Scope = scope;
            }
            
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for CreatePropertyDefinitionRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for CreatePropertyDefinitionRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            // to ensure "dataTypeId" is required (not null)
            if (dataTypeId == null)
            {
                throw new InvalidDataException("dataTypeId is a required property for CreatePropertyDefinitionRequest and cannot be null");
            }
            else
            {
                this.DataTypeId = dataTypeId;
            }
            
            this.ValueRequired = valueRequired;
            this.LifeTime = lifeTime;
            this.ConstraintStyle = constraintStyle;
        }
        

        /// <summary>
        /// The scope that the property exists in.
        /// </summary>
        /// <value>The scope that the property exists in.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The code of the property. Together with the domain and scope this uniquely identifies the property.
        /// </summary>
        /// <value>The code of the property. Together with the domain and scope this uniquely identifies the property.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Whether or not a value is always required for this property.
        /// </summary>
        /// <value>Whether or not a value is always required for this property.</value>
        [DataMember(Name="valueRequired", EmitDefaultValue=false)]
        public bool? ValueRequired { get; set; }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeId
        /// </summary>
        [DataMember(Name="dataTypeId", EmitDefaultValue=false)]
        public ResourceId DataTypeId { get; set; }


        /// <summary>
        /// Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. Defaults to \&quot;Property\&quot; if not specified.
        /// </summary>
        /// <value>Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. Defaults to \&quot;Property\&quot; if not specified.</value>
        [DataMember(Name="constraintStyle", EmitDefaultValue=false)]
        public string ConstraintStyle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePropertyDefinitionRequest {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ValueRequired: ").Append(ValueRequired).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataTypeId: ").Append(DataTypeId).Append("\n");
            sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
            sb.Append("  ConstraintStyle: ").Append(ConstraintStyle).Append("\n");
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
            return this.Equals(input as CreatePropertyDefinitionRequest);
        }

        /// <summary>
        /// Returns true if CreatePropertyDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePropertyDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePropertyDefinitionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ValueRequired == input.ValueRequired ||
                    (this.ValueRequired != null &&
                    this.ValueRequired.Equals(input.ValueRequired))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DataTypeId == input.DataTypeId ||
                    (this.DataTypeId != null &&
                    this.DataTypeId.Equals(input.DataTypeId))
                ) && 
                (
                    this.LifeTime == input.LifeTime ||
                    (this.LifeTime != null &&
                    this.LifeTime.Equals(input.LifeTime))
                ) && 
                (
                    this.ConstraintStyle == input.ConstraintStyle ||
                    (this.ConstraintStyle != null &&
                    this.ConstraintStyle.Equals(input.ConstraintStyle))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ValueRequired != null)
                    hashCode = hashCode * 59 + this.ValueRequired.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DataTypeId != null)
                    hashCode = hashCode * 59 + this.DataTypeId.GetHashCode();
                if (this.LifeTime != null)
                    hashCode = hashCode * 59 + this.LifeTime.GetHashCode();
                if (this.ConstraintStyle != null)
                    hashCode = hashCode * 59 + this.ConstraintStyle.GetHashCode();
                return hashCode;
            }
        }
    }

}
