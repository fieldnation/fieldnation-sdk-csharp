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
    /// ProblemsSum
    /// </summary>
    [DataContract]
    public partial class ProblemsSum :  IEquatable<ProblemsSum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemsSum" /> class.
        /// </summary>
        /// <param name="Resolved">Resolved.</param>
        /// <param name="Unresolved">Unresolved.</param>
        public ProblemsSum(int? Resolved = default(int?), int? Unresolved = default(int?))
        {
            this.Resolved = Resolved;
            this.Unresolved = Unresolved;
        }
        
        /// <summary>
        /// Gets or Sets Resolved
        /// </summary>
        [DataMember(Name="resolved", EmitDefaultValue=false)]
        public int? Resolved { get; set; }

        /// <summary>
        /// Gets or Sets Unresolved
        /// </summary>
        [DataMember(Name="unresolved", EmitDefaultValue=false)]
        public int? Unresolved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemsSum {\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
            sb.Append("  Unresolved: ").Append(Unresolved).Append("\n");
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
            return this.Equals(obj as ProblemsSum);
        }

        /// <summary>
        /// Returns true if ProblemsSum instances are equal
        /// </summary>
        /// <param name="other">Instance of ProblemsSum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemsSum other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Resolved == other.Resolved ||
                    this.Resolved != null &&
                    this.Resolved.Equals(other.Resolved)
                ) && 
                (
                    this.Unresolved == other.Unresolved ||
                    this.Unresolved != null &&
                    this.Unresolved.Equals(other.Unresolved)
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
                if (this.Resolved != null)
                    hash = hash * 59 + this.Resolved.GetHashCode();
                if (this.Unresolved != null)
                    hash = hash * 59 + this.Unresolved.GetHashCode();
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
