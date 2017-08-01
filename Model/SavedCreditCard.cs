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
    /// SavedCreditCard
    /// </summary>
    [DataContract]
    public partial class SavedCreditCard :  IEquatable<SavedCreditCard>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardTypeEnum
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
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Disable for "disable"
            /// </summary>
            [EnumMember(Value = "disable")]
            Disable,
            
            /// <summary>
            /// Enum Enable for "enable"
            /// </summary>
            [EnumMember(Value = "enable")]
            Enable,
            
            /// <summary>
            /// Enum Request for "request"
            /// </summary>
            [EnumMember(Value = "request")]
            Request,
            
            /// <summary>
            /// Enum Deny for "deny"
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny
        }

        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        [DataMember(Name="card_type", EmitDefaultValue=false)]
        public CardTypeEnum? CardType { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedCreditCard" /> class.
        /// </summary>
        /// <param name="CardId">CardId.</param>
        /// <param name="CardType">CardType.</param>
        /// <param name="ExpirationDate">format MM/YY.</param>
        /// <param name="IsExpired">IsExpired.</param>
        /// <param name="LastFour">LastFour.</param>
        /// <param name="Actions">Actions.</param>
        public SavedCreditCard(int? CardId = default(int?), CardTypeEnum? CardType = default(CardTypeEnum?), string ExpirationDate = default(string), int? IsExpired = default(int?), string LastFour = default(string), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.CardId = CardId;
            this.CardType = CardType;
            this.ExpirationDate = ExpirationDate;
            this.IsExpired = IsExpired;
            this.LastFour = LastFour;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets CardId
        /// </summary>
        [DataMember(Name="card_id", EmitDefaultValue=false)]
        public int? CardId { get; set; }


        /// <summary>
        /// format MM/YY
        /// </summary>
        /// <value>format MM/YY</value>
        [DataMember(Name="expiration_date", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        [DataMember(Name="isExpired", EmitDefaultValue=false)]
        public int? IsExpired { get; set; }

        /// <summary>
        /// Gets or Sets LastFour
        /// </summary>
        [DataMember(Name="last_four", EmitDefaultValue=false)]
        public string LastFour { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SavedCreditCard {\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  LastFour: ").Append(LastFour).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as SavedCreditCard);
        }

        /// <summary>
        /// Returns true if SavedCreditCard instances are equal
        /// </summary>
        /// <param name="other">Instance of SavedCreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SavedCreditCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardId == other.CardId ||
                    this.CardId != null &&
                    this.CardId.Equals(other.CardId)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.IsExpired == other.IsExpired ||
                    this.IsExpired != null &&
                    this.IsExpired.Equals(other.IsExpired)
                ) && 
                (
                    this.LastFour == other.LastFour ||
                    this.LastFour != null &&
                    this.LastFour.Equals(other.LastFour)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                if (this.CardId != null)
                    hash = hash * 59 + this.CardId.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.IsExpired != null)
                    hash = hash * 59 + this.IsExpired.GetHashCode();
                if (this.LastFour != null)
                    hash = hash * 59 + this.LastFour.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
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
            // ExpirationDate (string) pattern
            Regex regexExpirationDate = new Regex(@"^\\d{2}\/\\d{2}$", RegexOptions.CultureInvariant);
            if (false == regexExpirationDate.Match(this.ExpirationDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, must match a pattern of " + regexExpirationDate, new [] { "ExpirationDate" });
            }

            yield break;
        }
    }

}
