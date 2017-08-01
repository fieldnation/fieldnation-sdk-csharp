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
    /// Tasks
    /// </summary>
    [DataContract]
    public partial class Tasks :  IEquatable<Tasks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tasks" /> class.
        /// </summary>
        /// <param name="_Tasks">_Tasks.</param>
        public Tasks(WorkordersworkOrderIdtasksTasks _Tasks = default(WorkordersworkOrderIdtasksTasks))
        {
            this._Tasks = _Tasks;
        }
        
        /// <summary>
        /// Gets or Sets _Tasks
        /// </summary>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        public WorkordersworkOrderIdtasksTasks _Tasks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tasks {\n");
            sb.Append("  _Tasks: ").Append(_Tasks).Append("\n");
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
            return this.Equals(obj as Tasks);
        }

        /// <summary>
        /// Returns true if Tasks instances are equal
        /// </summary>
        /// <param name="other">Instance of Tasks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tasks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Tasks == other._Tasks ||
                    this._Tasks != null &&
                    this._Tasks.Equals(other._Tasks)
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
                if (this._Tasks != null)
                    hash = hash * 59 + this._Tasks.GetHashCode();
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
