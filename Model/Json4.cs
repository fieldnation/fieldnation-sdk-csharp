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
    /// Json4
    /// </summary>
    [DataContract]
    public partial class Json4 :  IEquatable<Json4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Json4" /> class.
        /// </summary>
        /// <param name="PreferenceValue">PreferenceValue.</param>
        public Json4(int? PreferenceValue = default(int?))
        {
            this.PreferenceValue = PreferenceValue;
        }
        
        /// <summary>
        /// Gets or Sets PreferenceValue
        /// </summary>
        [DataMember(Name="preference_value", EmitDefaultValue=false)]
        public int? PreferenceValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Json4 {\n");
            sb.Append("  PreferenceValue: ").Append(PreferenceValue).Append("\n");
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
            return this.Equals(obj as Json4);
        }

        /// <summary>
        /// Returns true if Json4 instances are equal
        /// </summary>
        /// <param name="other">Instance of Json4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Json4 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreferenceValue == other.PreferenceValue ||
                    this.PreferenceValue != null &&
                    this.PreferenceValue.Equals(other.PreferenceValue)
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
                if (this.PreferenceValue != null)
                    hash = hash * 59 + this.PreferenceValue.GetHashCode();
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
