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
    /// ProblemType
    /// </summary>
    [DataContract]
    public partial class ProblemType :  IEquatable<ProblemType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemType" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="HasOther">HasOther.</param>
        /// <param name="Other">Other.</param>
        /// <param name="PerformanceEvent">PerformanceEvent.</param>
        /// <param name="FileWithSupport">FileWithSupport.</param>
        /// <param name="ShowPqapWarning">ShowPqapWarning.</param>
        /// <param name="Children">Children.</param>
        public ProblemType(int? Id = default(int?), string Name = default(string), bool? HasOther = default(bool?), string Other = default(string), bool? PerformanceEvent = default(bool?), bool? FileWithSupport = default(bool?), bool? ShowPqapWarning = default(bool?), List<ProblemType> Children = default(List<ProblemType>))
        {
            this.Id = Id;
            this.Name = Name;
            this.HasOther = HasOther;
            this.Other = Other;
            this.PerformanceEvent = PerformanceEvent;
            this.FileWithSupport = FileWithSupport;
            this.ShowPqapWarning = ShowPqapWarning;
            this.Children = Children;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HasOther
        /// </summary>
        [DataMember(Name="has_other", EmitDefaultValue=false)]
        public bool? HasOther { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceEvent
        /// </summary>
        [DataMember(Name="performance_event", EmitDefaultValue=false)]
        public bool? PerformanceEvent { get; set; }

        /// <summary>
        /// Gets or Sets FileWithSupport
        /// </summary>
        [DataMember(Name="file_with_support", EmitDefaultValue=false)]
        public bool? FileWithSupport { get; set; }

        /// <summary>
        /// Gets or Sets ShowPqapWarning
        /// </summary>
        [DataMember(Name="show_pqap_warning", EmitDefaultValue=false)]
        public bool? ShowPqapWarning { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<ProblemType> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HasOther: ").Append(HasOther).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  PerformanceEvent: ").Append(PerformanceEvent).Append("\n");
            sb.Append("  FileWithSupport: ").Append(FileWithSupport).Append("\n");
            sb.Append("  ShowPqapWarning: ").Append(ShowPqapWarning).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(obj as ProblemType);
        }

        /// <summary>
        /// Returns true if ProblemType instances are equal
        /// </summary>
        /// <param name="other">Instance of ProblemType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemType other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.HasOther == other.HasOther ||
                    this.HasOther != null &&
                    this.HasOther.Equals(other.HasOther)
                ) && 
                (
                    this.Other == other.Other ||
                    this.Other != null &&
                    this.Other.Equals(other.Other)
                ) && 
                (
                    this.PerformanceEvent == other.PerformanceEvent ||
                    this.PerformanceEvent != null &&
                    this.PerformanceEvent.Equals(other.PerformanceEvent)
                ) && 
                (
                    this.FileWithSupport == other.FileWithSupport ||
                    this.FileWithSupport != null &&
                    this.FileWithSupport.Equals(other.FileWithSupport)
                ) && 
                (
                    this.ShowPqapWarning == other.ShowPqapWarning ||
                    this.ShowPqapWarning != null &&
                    this.ShowPqapWarning.Equals(other.ShowPqapWarning)
                ) && 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.HasOther != null)
                    hash = hash * 59 + this.HasOther.GetHashCode();
                if (this.Other != null)
                    hash = hash * 59 + this.Other.GetHashCode();
                if (this.PerformanceEvent != null)
                    hash = hash * 59 + this.PerformanceEvent.GetHashCode();
                if (this.FileWithSupport != null)
                    hash = hash * 59 + this.FileWithSupport.GetHashCode();
                if (this.ShowPqapWarning != null)
                    hash = hash * 59 + this.ShowPqapWarning.GetHashCode();
                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();
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
