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
    /// UserPreviousAssignment
    /// </summary>
    [DataContract]
    public partial class UserPreviousAssignment :  IEquatable<UserPreviousAssignment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreviousAssignment" /> class.
        /// </summary>
        /// <param name="Removal">Removal.</param>
        /// <param name="By">By.</param>
        /// <param name="Reason">Reason.</param>
        public UserPreviousAssignment(DateTime? Removal = default(DateTime?), User By = default(User), string Reason = default(string))
        {
            this.Removal = Removal;
            this.By = By;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Gets or Sets Removal
        /// </summary>
        [DataMember(Name="removal", EmitDefaultValue=false)]
        public DateTime? Removal { get; set; }

        /// <summary>
        /// Gets or Sets By
        /// </summary>
        [DataMember(Name="by", EmitDefaultValue=false)]
        public User By { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPreviousAssignment {\n");
            sb.Append("  Removal: ").Append(Removal).Append("\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as UserPreviousAssignment);
        }

        /// <summary>
        /// Returns true if UserPreviousAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPreviousAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPreviousAssignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Removal == other.Removal ||
                    this.Removal != null &&
                    this.Removal.Equals(other.Removal)
                ) && 
                (
                    this.By == other.By ||
                    this.By != null &&
                    this.By.Equals(other.By)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Removal != null)
                    hash = hash * 59 + this.Removal.GetHashCode();
                if (this.By != null)
                    hash = hash * 59 + this.By.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
