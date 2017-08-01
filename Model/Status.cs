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
    /// Status
    /// </summary>
    [DataContract]
    public partial class Status :  IEquatable<Status>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Display">Display.</param>
        /// <param name="ProblemReported">ProblemReported.</param>
        /// <param name="IsRouted">IsRouted.</param>
        /// <param name="Problem">Problem.</param>
        /// <param name="Code">Code.</param>
        /// <param name="SubStatus">SubStatus.</param>
        /// <param name="Delay">Delay.</param>
        /// <param name="Ncns">Ncns.</param>
        /// <param name="Confirmed">Confirmed.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        public Status(int? Id = default(int?), string Name = default(string), string Display = default(string), bool? ProblemReported = default(bool?), bool? IsRouted = default(bool?), Problem Problem = default(Problem), string Code = default(string), string SubStatus = default(string), int? Delay = default(int?), bool? Ncns = default(bool?), bool? Confirmed = default(bool?), string CorrelationId = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Display = Display;
            this.ProblemReported = ProblemReported;
            this.IsRouted = IsRouted;
            this.Problem = Problem;
            this.Code = Code;
            this.SubStatus = SubStatus;
            this.Delay = Delay;
            this.Ncns = Ncns;
            this.Confirmed = Confirmed;
            this.CorrelationId = CorrelationId;
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
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }

        /// <summary>
        /// Gets or Sets ProblemReported
        /// </summary>
        [DataMember(Name="problem_reported", EmitDefaultValue=false)]
        public bool? ProblemReported { get; set; }

        /// <summary>
        /// Gets or Sets IsRouted
        /// </summary>
        [DataMember(Name="is_routed", EmitDefaultValue=false)]
        public bool? IsRouted { get; set; }

        /// <summary>
        /// Gets or Sets Problem
        /// </summary>
        [DataMember(Name="problem", EmitDefaultValue=false)]
        public Problem Problem { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets SubStatus
        /// </summary>
        [DataMember(Name="sub_status", EmitDefaultValue=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// Gets or Sets Delay
        /// </summary>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// Gets or Sets Ncns
        /// </summary>
        [DataMember(Name="ncns", EmitDefaultValue=false)]
        public bool? Ncns { get; set; }

        /// <summary>
        /// Gets or Sets Confirmed
        /// </summary>
        [DataMember(Name="confirmed", EmitDefaultValue=false)]
        public bool? Confirmed { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Status {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  ProblemReported: ").Append(ProblemReported).Append("\n");
            sb.Append("  IsRouted: ").Append(IsRouted).Append("\n");
            sb.Append("  Problem: ").Append(Problem).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SubStatus: ").Append(SubStatus).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  Ncns: ").Append(Ncns).Append("\n");
            sb.Append("  Confirmed: ").Append(Confirmed).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
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
            return this.Equals(obj as Status);
        }

        /// <summary>
        /// Returns true if Status instances are equal
        /// </summary>
        /// <param name="other">Instance of Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Status other)
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
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) && 
                (
                    this.ProblemReported == other.ProblemReported ||
                    this.ProblemReported != null &&
                    this.ProblemReported.Equals(other.ProblemReported)
                ) && 
                (
                    this.IsRouted == other.IsRouted ||
                    this.IsRouted != null &&
                    this.IsRouted.Equals(other.IsRouted)
                ) && 
                (
                    this.Problem == other.Problem ||
                    this.Problem != null &&
                    this.Problem.Equals(other.Problem)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.SubStatus == other.SubStatus ||
                    this.SubStatus != null &&
                    this.SubStatus.Equals(other.SubStatus)
                ) && 
                (
                    this.Delay == other.Delay ||
                    this.Delay != null &&
                    this.Delay.Equals(other.Delay)
                ) && 
                (
                    this.Ncns == other.Ncns ||
                    this.Ncns != null &&
                    this.Ncns.Equals(other.Ncns)
                ) && 
                (
                    this.Confirmed == other.Confirmed ||
                    this.Confirmed != null &&
                    this.Confirmed.Equals(other.Confirmed)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
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
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                if (this.ProblemReported != null)
                    hash = hash * 59 + this.ProblemReported.GetHashCode();
                if (this.IsRouted != null)
                    hash = hash * 59 + this.IsRouted.GetHashCode();
                if (this.Problem != null)
                    hash = hash * 59 + this.Problem.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.SubStatus != null)
                    hash = hash * 59 + this.SubStatus.GetHashCode();
                if (this.Delay != null)
                    hash = hash * 59 + this.Delay.GetHashCode();
                if (this.Ncns != null)
                    hash = hash * 59 + this.Ncns.GetHashCode();
                if (this.Confirmed != null)
                    hash = hash * 59 + this.Confirmed.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
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
