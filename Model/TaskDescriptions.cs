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
    /// TaskDescriptions
    /// </summary>
    [DataContract]
    public partial class TaskDescriptions :  IEquatable<TaskDescriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDescriptions" /> class.
        /// </summary>
        /// <param name="Task">Task.</param>
        /// <param name="First">First.</param>
        /// <param name="Second">Second.</param>
        /// <param name="Third">Third.</param>
        /// <param name="Fourth">Fourth.</param>
        public TaskDescriptions(string Task = default(string), string First = default(string), string Second = default(string), string Third = default(string), string Fourth = default(string))
        {
            this.Task = Task;
            this.First = First;
            this.Second = Second;
            this.Third = Third;
            this.Fourth = Fourth;
        }
        
        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public string Task { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }

        /// <summary>
        /// Gets or Sets Second
        /// </summary>
        [DataMember(Name="second", EmitDefaultValue=false)]
        public string Second { get; set; }

        /// <summary>
        /// Gets or Sets Third
        /// </summary>
        [DataMember(Name="third", EmitDefaultValue=false)]
        public string Third { get; set; }

        /// <summary>
        /// Gets or Sets Fourth
        /// </summary>
        [DataMember(Name="fourth", EmitDefaultValue=false)]
        public string Fourth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDescriptions {\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
            sb.Append("  Third: ").Append(Third).Append("\n");
            sb.Append("  Fourth: ").Append(Fourth).Append("\n");
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
            return this.Equals(obj as TaskDescriptions);
        }

        /// <summary>
        /// Returns true if TaskDescriptions instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskDescriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDescriptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Task == other.Task ||
                    this.Task != null &&
                    this.Task.Equals(other.Task)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.Second == other.Second ||
                    this.Second != null &&
                    this.Second.Equals(other.Second)
                ) && 
                (
                    this.Third == other.Third ||
                    this.Third != null &&
                    this.Third.Equals(other.Third)
                ) && 
                (
                    this.Fourth == other.Fourth ||
                    this.Fourth != null &&
                    this.Fourth.Equals(other.Fourth)
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
                if (this.Task != null)
                    hash = hash * 59 + this.Task.GetHashCode();
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                if (this.Second != null)
                    hash = hash * 59 + this.Second.GetHashCode();
                if (this.Third != null)
                    hash = hash * 59 + this.Third.GetHashCode();
                if (this.Fourth != null)
                    hash = hash * 59 + this.Fourth.GetHashCode();
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
