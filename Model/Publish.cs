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
    /// Publish
    /// </summary>
    [DataContract]
    public partial class Publish :  IEquatable<Publish>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Publish" /> class.
        /// </summary>
        /// <param name="CreditCardId">CreditCardId.</param>
        /// <param name="CreditCard">CreditCard.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        public Publish(string CreditCardId = default(string), CreditCard CreditCard = default(CreditCard), BillingAddress BillingAddress = default(BillingAddress))
        {
            this.CreditCardId = CreditCardId;
            this.CreditCard = CreditCard;
            this.BillingAddress = BillingAddress;
        }
        
        /// <summary>
        /// Gets or Sets CreditCardId
        /// </summary>
        [DataMember(Name="credit_card_id", EmitDefaultValue=false)]
        public string CreditCardId { get; set; }

        /// <summary>
        /// Gets or Sets CreditCard
        /// </summary>
        [DataMember(Name="credit_card", EmitDefaultValue=false)]
        public CreditCard CreditCard { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Publish {\n");
            sb.Append("  CreditCardId: ").Append(CreditCardId).Append("\n");
            sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
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
            return this.Equals(obj as Publish);
        }

        /// <summary>
        /// Returns true if Publish instances are equal
        /// </summary>
        /// <param name="other">Instance of Publish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Publish other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreditCardId == other.CreditCardId ||
                    this.CreditCardId != null &&
                    this.CreditCardId.Equals(other.CreditCardId)
                ) && 
                (
                    this.CreditCard == other.CreditCard ||
                    this.CreditCard != null &&
                    this.CreditCard.Equals(other.CreditCard)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
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
                if (this.CreditCardId != null)
                    hash = hash * 59 + this.CreditCardId.GetHashCode();
                if (this.CreditCard != null)
                    hash = hash * 59 + this.CreditCard.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
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
