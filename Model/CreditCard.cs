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
    /// CreditCard
    /// </summary>
    [DataContract]
    public partial class CreditCard :  IEquatable<CreditCard>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Visa for "visa"
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa,
            
            /// <summary>
            /// Enum Mastercard for "mastercard"
            /// </summary>
            [EnumMember(Value = "mastercard")]
            Mastercard,
            
            /// <summary>
            /// Enum Americanexpress for "american express"
            /// </summary>
            [EnumMember(Value = "american express")]
            Americanexpress,
            
            /// <summary>
            /// Enum Discover for "discover"
            /// </summary>
            [EnumMember(Value = "discover")]
            Discover,
            
            /// <summary>
            /// Enum Jcb for "jcb"
            /// </summary>
            [EnumMember(Value = "jcb")]
            Jcb,
            
            /// <summary>
            /// Enum Dinersclub for "diners club"
            /// </summary>
            [EnumMember(Value = "diners club")]
            Dinersclub
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="CardNumber">CardNumber (required).</param>
        /// <param name="ExpDate">format MM/YY (required).</param>
        /// <param name="Cvv">Cvv (required).</param>
        /// <param name="CardholderName">CardholderName (required).</param>
        public CreditCard(TypeEnum? Type = default(TypeEnum?), string CardNumber = default(string), string ExpDate = default(string), string Cvv = default(string), string CardholderName = default(string))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for CreditCard and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "CardNumber" is required (not null)
            if (CardNumber == null)
            {
                throw new InvalidDataException("CardNumber is a required property for CreditCard and cannot be null");
            }
            else
            {
                this.CardNumber = CardNumber;
            }
            // to ensure "ExpDate" is required (not null)
            if (ExpDate == null)
            {
                throw new InvalidDataException("ExpDate is a required property for CreditCard and cannot be null");
            }
            else
            {
                this.ExpDate = ExpDate;
            }
            // to ensure "Cvv" is required (not null)
            if (Cvv == null)
            {
                throw new InvalidDataException("Cvv is a required property for CreditCard and cannot be null");
            }
            else
            {
                this.Cvv = Cvv;
            }
            // to ensure "CardholderName" is required (not null)
            if (CardholderName == null)
            {
                throw new InvalidDataException("CardholderName is a required property for CreditCard and cannot be null");
            }
            else
            {
                this.CardholderName = CardholderName;
            }
        }
        

        /// <summary>
        /// Gets or Sets CardNumber
        /// </summary>
        [DataMember(Name="card_number", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// format MM/YY
        /// </summary>
        /// <value>format MM/YY</value>
        [DataMember(Name="exp_date", EmitDefaultValue=false)]
        public string ExpDate { get; set; }

        /// <summary>
        /// Gets or Sets Cvv
        /// </summary>
        [DataMember(Name="cvv", EmitDefaultValue=false)]
        public string Cvv { get; set; }

        /// <summary>
        /// Gets or Sets CardholderName
        /// </summary>
        [DataMember(Name="cardholder_name", EmitDefaultValue=false)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCard {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  ExpDate: ").Append(ExpDate).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
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
            return this.Equals(obj as CreditCard);
        }

        /// <summary>
        /// Returns true if CreditCard instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CardNumber == other.CardNumber ||
                    this.CardNumber != null &&
                    this.CardNumber.Equals(other.CardNumber)
                ) && 
                (
                    this.ExpDate == other.ExpDate ||
                    this.ExpDate != null &&
                    this.ExpDate.Equals(other.ExpDate)
                ) && 
                (
                    this.Cvv == other.Cvv ||
                    this.Cvv != null &&
                    this.Cvv.Equals(other.Cvv)
                ) && 
                (
                    this.CardholderName == other.CardholderName ||
                    this.CardholderName != null &&
                    this.CardholderName.Equals(other.CardholderName)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CardNumber != null)
                    hash = hash * 59 + this.CardNumber.GetHashCode();
                if (this.ExpDate != null)
                    hash = hash * 59 + this.ExpDate.GetHashCode();
                if (this.Cvv != null)
                    hash = hash * 59 + this.Cvv.GetHashCode();
                if (this.CardholderName != null)
                    hash = hash * 59 + this.CardholderName.GetHashCode();
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
            // ExpDate (string) pattern
            Regex regexExpDate = new Regex(@"^\\d{2}\/\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexExpDate.Match(this.ExpDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpDate, must match a pattern of " + regexExpDate, new [] { "ExpDate" });
            }

            yield break;
        }
    }

}
