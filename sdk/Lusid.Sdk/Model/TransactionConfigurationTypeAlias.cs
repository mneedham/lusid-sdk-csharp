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
    /// TransactionConfigurationTypeAlias
    /// </summary>
    [DataContract]
    public partial class TransactionConfigurationTypeAlias :  IEquatable<TransactionConfigurationTypeAlias>
    {
        /// <summary>
        /// Transactions role within a class. E.g. Increase a long position
        /// </summary>
        /// <value>Transactions role within a class. E.g. Increase a long position</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionRolesEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum LongLonger for value: LongLonger
            /// </summary>
            [EnumMember(Value = "LongLonger")]
            LongLonger = 2,

            /// <summary>
            /// Enum LongShorter for value: LongShorter
            /// </summary>
            [EnumMember(Value = "LongShorter")]
            LongShorter = 3,

            /// <summary>
            /// Enum ShortShorter for value: ShortShorter
            /// </summary>
            [EnumMember(Value = "ShortShorter")]
            ShortShorter = 4,

            /// <summary>
            /// Enum ShortLonger for value: ShortLonger
            /// </summary>
            [EnumMember(Value = "ShortLonger")]
            ShortLonger = 5,

            /// <summary>
            /// Enum Longer for value: Longer
            /// </summary>
            [EnumMember(Value = "Longer")]
            Longer = 6,

            /// <summary>
            /// Enum Shorter for value: Shorter
            /// </summary>
            [EnumMember(Value = "Shorter")]
            Shorter = 7,

            /// <summary>
            /// Enum AllRoles for value: AllRoles
            /// </summary>
            [EnumMember(Value = "AllRoles")]
            AllRoles = 8

        }

        /// <summary>
        /// Transactions role within a class. E.g. Increase a long position
        /// </summary>
        /// <value>Transactions role within a class. E.g. Increase a long position</value>
        [DataMember(Name="transactionRoles", EmitDefaultValue=false)]
        public TransactionRolesEnum TransactionRoles { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationTypeAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionConfigurationTypeAlias() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationTypeAlias" /> class.
        /// </summary>
        /// <param name="type">The transaction type (required).</param>
        /// <param name="description">Brief description of the transaction (required).</param>
        /// <param name="transactionClass">Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut (required).</param>
        /// <param name="transactionGroup">Group is a set of codes related to a source, or sync (required).</param>
        /// <param name="transactionRoles">Transactions role within a class. E.g. Increase a long position (required).</param>
        public TransactionConfigurationTypeAlias(string type = default(string), string description = default(string), string transactionClass = default(string), string transactionGroup = default(string), TransactionRolesEnum transactionRoles = default(TransactionRolesEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for TransactionConfigurationTypeAlias and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for TransactionConfigurationTypeAlias and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            
            // to ensure "transactionClass" is required (not null)
            if (transactionClass == null)
            {
                throw new InvalidDataException("transactionClass is a required property for TransactionConfigurationTypeAlias and cannot be null");
            }
            else
            {
                this.TransactionClass = transactionClass;
            }
            
            // to ensure "transactionGroup" is required (not null)
            if (transactionGroup == null)
            {
                throw new InvalidDataException("transactionGroup is a required property for TransactionConfigurationTypeAlias and cannot be null");
            }
            else
            {
                this.TransactionGroup = transactionGroup;
            }
            
            // to ensure "transactionRoles" is required (not null)
            if (transactionRoles == null)
            {
                throw new InvalidDataException("transactionRoles is a required property for TransactionConfigurationTypeAlias and cannot be null");
            }
            else
            {
                this.TransactionRoles = transactionRoles;
            }
            
        }
        
        /// <summary>
        /// The transaction type
        /// </summary>
        /// <value>The transaction type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Brief description of the transaction
        /// </summary>
        /// <value>Brief description of the transaction</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut
        /// </summary>
        /// <value>Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut</value>
        [DataMember(Name="transactionClass", EmitDefaultValue=false)]
        public string TransactionClass { get; set; }

        /// <summary>
        /// Group is a set of codes related to a source, or sync
        /// </summary>
        /// <value>Group is a set of codes related to a source, or sync</value>
        [DataMember(Name="transactionGroup", EmitDefaultValue=false)]
        public string TransactionGroup { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionConfigurationTypeAlias {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TransactionClass: ").Append(TransactionClass).Append("\n");
            sb.Append("  TransactionGroup: ").Append(TransactionGroup).Append("\n");
            sb.Append("  TransactionRoles: ").Append(TransactionRoles).Append("\n");
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
            return this.Equals(input as TransactionConfigurationTypeAlias);
        }

        /// <summary>
        /// Returns true if TransactionConfigurationTypeAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionConfigurationTypeAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionConfigurationTypeAlias input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TransactionClass == input.TransactionClass ||
                    (this.TransactionClass != null &&
                    this.TransactionClass.Equals(input.TransactionClass))
                ) && 
                (
                    this.TransactionGroup == input.TransactionGroup ||
                    (this.TransactionGroup != null &&
                    this.TransactionGroup.Equals(input.TransactionGroup))
                ) && 
                (
                    this.TransactionRoles == input.TransactionRoles ||
                    (this.TransactionRoles != null &&
                    this.TransactionRoles.Equals(input.TransactionRoles))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TransactionClass != null)
                    hashCode = hashCode * 59 + this.TransactionClass.GetHashCode();
                if (this.TransactionGroup != null)
                    hashCode = hashCode * 59 + this.TransactionGroup.GetHashCode();
                if (this.TransactionRoles != null)
                    hashCode = hashCode * 59 + this.TransactionRoles.GetHashCode();
                return hashCode;
            }
        }
    }

}
