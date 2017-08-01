/* 
 * FIELDNATION RESTful API V2
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = FieldNation.SDK.Client.SwaggerDateConverter;

namespace FieldNation.SDK.Model
{
    /// <summary>
    /// Bank
    /// </summary>
    [DataContract]
    public partial class Bank :  IEquatable<Bank>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum Checking for "Checking"
            /// </summary>
            [EnumMember(Value = "Checking")]
            Checking,
            
            /// <summary>
            /// Enum Savings for "Savings"
            /// </summary>
            [EnumMember(Value = "Savings")]
            Savings
        }

        /// <summary>
        /// Gets or Sets AccountCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountCategoryEnum
        {
            
            /// <summary>
            /// Enum Business for "Business"
            /// </summary>
            [EnumMember(Value = "Business")]
            Business,
            
            /// <summary>
            /// Enum Consumer for "Consumer"
            /// </summary>
            [EnumMember(Value = "Consumer")]
            Consumer
        }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Gets or Sets AccountCategory
        /// </summary>
        [DataMember(Name="accountCategory", EmitDefaultValue=false)]
        public AccountCategoryEnum? AccountCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Bank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="RoutingNumber">RoutingNumber (required).</param>
        /// <param name="AccountNumber">AccountNumber (required).</param>
        /// <param name="AccountType">AccountType (required).</param>
        /// <param name="AccountCategory">AccountCategory (required).</param>
        public Bank(string FirstName = default(string), string LastName = default(string), decimal? RoutingNumber = default(decimal?), string AccountNumber = default(string), AccountTypeEnum? AccountType = default(AccountTypeEnum?), AccountCategoryEnum? AccountCategory = default(AccountCategoryEnum?))
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Bank and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for Bank and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "RoutingNumber" is required (not null)
            if (RoutingNumber == null)
            {
                throw new InvalidDataException("RoutingNumber is a required property for Bank and cannot be null");
            }
            else
            {
                this.RoutingNumber = RoutingNumber;
            }
            // to ensure "AccountNumber" is required (not null)
            if (AccountNumber == null)
            {
                throw new InvalidDataException("AccountNumber is a required property for Bank and cannot be null");
            }
            else
            {
                this.AccountNumber = AccountNumber;
            }
            // to ensure "AccountType" is required (not null)
            if (AccountType == null)
            {
                throw new InvalidDataException("AccountType is a required property for Bank and cannot be null");
            }
            else
            {
                this.AccountType = AccountType;
            }
            // to ensure "AccountCategory" is required (not null)
            if (AccountCategory == null)
            {
                throw new InvalidDataException("AccountCategory is a required property for Bank and cannot be null");
            }
            else
            {
                this.AccountCategory = AccountCategory;
            }
        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public decimal? RoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bank {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountCategory: ").Append(AccountCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Bank);
        }

        /// <summary>
        /// Returns true if Bank instances are equal
        /// </summary>
        /// <param name="other">Instance of Bank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bank other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.AccountCategory == other.AccountCategory ||
                    this.AccountCategory != null &&
                    this.AccountCategory.Equals(other.AccountCategory)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.AccountCategory != null)
                    hash = hash * 59 + this.AccountCategory.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
