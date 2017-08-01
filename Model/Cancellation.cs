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
    /// Cancellation
    /// </summary>
    [DataContract]
    public partial class Cancellation :  IEquatable<Cancellation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cancellation" /> class.
        /// </summary>
        /// <param name="CancelReason">CancelReason.</param>
        /// <param name="MessageToProvider">MessageToProvider.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="CancelRequestNotCharge">CancelRequestNotCharge.</param>
        public Cancellation(int? CancelReason = default(int?), string MessageToProvider = default(string), string Notes = default(string), bool? CancelRequestNotCharge = default(bool?))
        {
            this.CancelReason = CancelReason;
            this.MessageToProvider = MessageToProvider;
            this.Notes = Notes;
            this.CancelRequestNotCharge = CancelRequestNotCharge;
        }
        
        /// <summary>
        /// Gets or Sets CancelReason
        /// </summary>
        [DataMember(Name="cancel_reason", EmitDefaultValue=false)]
        public int? CancelReason { get; set; }

        /// <summary>
        /// Gets or Sets MessageToProvider
        /// </summary>
        [DataMember(Name="message_to_provider", EmitDefaultValue=false)]
        public string MessageToProvider { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets CancelRequestNotCharge
        /// </summary>
        [DataMember(Name="cancel_request_not_charge", EmitDefaultValue=false)]
        public bool? CancelRequestNotCharge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cancellation {\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  MessageToProvider: ").Append(MessageToProvider).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  CancelRequestNotCharge: ").Append(CancelRequestNotCharge).Append("\n");
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
            return this.Equals(obj as Cancellation);
        }

        /// <summary>
        /// Returns true if Cancellation instances are equal
        /// </summary>
        /// <param name="other">Instance of Cancellation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cancellation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CancelReason == other.CancelReason ||
                    this.CancelReason != null &&
                    this.CancelReason.Equals(other.CancelReason)
                ) && 
                (
                    this.MessageToProvider == other.MessageToProvider ||
                    this.MessageToProvider != null &&
                    this.MessageToProvider.Equals(other.MessageToProvider)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.CancelRequestNotCharge == other.CancelRequestNotCharge ||
                    this.CancelRequestNotCharge != null &&
                    this.CancelRequestNotCharge.Equals(other.CancelRequestNotCharge)
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
                if (this.CancelReason != null)
                    hash = hash * 59 + this.CancelReason.GetHashCode();
                if (this.MessageToProvider != null)
                    hash = hash * 59 + this.MessageToProvider.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.CancelRequestNotCharge != null)
                    hash = hash * 59 + this.CancelRequestNotCharge.GetHashCode();
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
