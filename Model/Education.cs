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
    /// Education
    /// </summary>
    [DataContract]
    public partial class Education :  IEquatable<Education>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Education" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SchoolName">SchoolName.</param>
        /// <param name="Degree">Degree.</param>
        /// <param name="FieldOfStudy">FieldOfStudy.</param>
        /// <param name="Start">Start.</param>
        /// <param name="End">End.</param>
        public Education(int? Id = default(int?), string SchoolName = default(string), string Degree = default(string), string FieldOfStudy = default(string), DateTime? Start = default(DateTime?), DateTime? End = default(DateTime?))
        {
            this.Id = Id;
            this.SchoolName = SchoolName;
            this.Degree = Degree;
            this.FieldOfStudy = FieldOfStudy;
            this.Start = Start;
            this.End = End;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets SchoolName
        /// </summary>
        [DataMember(Name="school_name", EmitDefaultValue=false)]
        public string SchoolName { get; set; }

        /// <summary>
        /// Gets or Sets Degree
        /// </summary>
        [DataMember(Name="degree", EmitDefaultValue=false)]
        public string Degree { get; set; }

        /// <summary>
        /// Gets or Sets FieldOfStudy
        /// </summary>
        [DataMember(Name="field_of_study", EmitDefaultValue=false)]
        public string FieldOfStudy { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Education {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchoolName: ").Append(SchoolName).Append("\n");
            sb.Append("  Degree: ").Append(Degree).Append("\n");
            sb.Append("  FieldOfStudy: ").Append(FieldOfStudy).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(obj as Education);
        }

        /// <summary>
        /// Returns true if Education instances are equal
        /// </summary>
        /// <param name="other">Instance of Education to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Education other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SchoolName == other.SchoolName ||
                    this.SchoolName != null &&
                    this.SchoolName.Equals(other.SchoolName)
                ) && 
                (
                    this.Degree == other.Degree ||
                    this.Degree != null &&
                    this.Degree.Equals(other.Degree)
                ) && 
                (
                    this.FieldOfStudy == other.FieldOfStudy ||
                    this.FieldOfStudy != null &&
                    this.FieldOfStudy.Equals(other.FieldOfStudy)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SchoolName != null)
                    hash = hash * 59 + this.SchoolName.GetHashCode();
                if (this.Degree != null)
                    hash = hash * 59 + this.Degree.GetHashCode();
                if (this.FieldOfStudy != null)
                    hash = hash * 59 + this.FieldOfStudy.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();
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
