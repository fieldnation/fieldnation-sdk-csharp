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
    /// Date
    /// </summary>
    [DataContract]
    public partial class Date :  IEquatable<Date>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Date" /> class.
        /// </summary>
        /// <param name="Utc">Utc.</param>
        /// <param name="Local">Local.</param>
        public Date(Utc Utc = default(Utc), Local Local = default(Local))
        {
            this.Utc = Utc;
            this.Local = Local;
        }
        
        /// <summary>
        /// Gets or Sets Utc
        /// </summary>
        [DataMember(Name="utc", EmitDefaultValue=false)]
        public Utc Utc { get; set; }

        /// <summary>
        /// Gets or Sets Local
        /// </summary>
        [DataMember(Name="local", EmitDefaultValue=false)]
        public Local Local { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Date {\n");
            sb.Append("  Utc: ").Append(Utc).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
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
            return this.Equals(obj as Date);
        }

        /// <summary>
        /// Returns true if Date instances are equal
        /// </summary>
        /// <param name="other">Instance of Date to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Date other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Utc == other.Utc ||
                    this.Utc != null &&
                    this.Utc.Equals(other.Utc)
                ) && 
                (
                    this.Local == other.Local ||
                    this.Local != null &&
                    this.Local.Equals(other.Local)
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
                if (this.Utc != null)
                    hash = hash * 59 + this.Utc.GetHashCode();
                if (this.Local != null)
                    hash = hash * 59 + this.Local.GetHashCode();
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
