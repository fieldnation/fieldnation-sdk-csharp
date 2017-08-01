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
    /// UserPreviousRequest
    /// </summary>
    [DataContract]
    public partial class UserPreviousRequest :  IEquatable<UserPreviousRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreviousRequest" /> class.
        /// </summary>
        /// <param name="At">At.</param>
        public UserPreviousRequest(DateTime? At = default(DateTime?))
        {
            this.At = At;
        }
        
        /// <summary>
        /// Gets or Sets At
        /// </summary>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public DateTime? At { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPreviousRequest {\n");
            sb.Append("  At: ").Append(At).Append("\n");
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
            return this.Equals(obj as UserPreviousRequest);
        }

        /// <summary>
        /// Returns true if UserPreviousRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPreviousRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPreviousRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.At == other.At ||
                    this.At != null &&
                    this.At.Equals(other.At)
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
                if (this.At != null)
                    hash = hash * 59 + this.At.GetHashCode();
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
