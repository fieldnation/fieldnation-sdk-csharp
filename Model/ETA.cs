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
    /// ETA
    /// </summary>
    [DataContract]
    public partial class ETA :  IEquatable<ETA>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            
            /// <summary>
            /// Enum Hours for "hours"
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours,
            
            /// <summary>
            /// Enum Between for "between"
            /// </summary>
            [EnumMember(Value = "between")]
            Between,
            
            /// <summary>
            /// Enum Exact for "exact"
            /// </summary>
            [EnumMember(Value = "exact")]
            Exact
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Add for "add"
            /// </summary>
            [EnumMember(Value = "add")]
            Add,
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Seteta for "set_eta"
            /// </summary>
            [EnumMember(Value = "set_eta")]
            Seteta,
            
            /// <summary>
            /// Enum Confirm for "confirm"
            /// </summary>
            [EnumMember(Value = "confirm")]
            Confirm,
            
            /// <summary>
            /// Enum Runninglate for "running_late"
            /// </summary>
            [EnumMember(Value = "running_late")]
            Runninglate,
            
            /// <summary>
            /// Enum Cancel for "cancel"
            /// </summary>
            [EnumMember(Value = "cancel")]
            Cancel,
            
            /// <summary>
            /// Enum Onmyway for "on_my_way"
            /// </summary>
            [EnumMember(Value = "on_my_way")]
            Onmyway,
            
            /// <summary>
            /// Enum Markreadytogo for "mark_ready_to_go"
            /// </summary>
            [EnumMember(Value = "mark_ready_to_go")]
            Markreadytogo
        }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ETA" /> class.
        /// </summary>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="User">User.</param>
        /// <param name="Mode">Mode.</param>
        /// <param name="Start">Start.</param>
        /// <param name="End">End.</param>
        /// <param name="HourEstimate">HourEstimate.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Condition">Condition.</param>
        /// <param name="Actions">Actions.</param>
        public ETA(int? WorkOrderId = default(int?), User User = default(User), ModeEnum? Mode = default(ModeEnum?), DateTime? Start = default(DateTime?), DateTime? End = default(DateTime?), decimal? HourEstimate = default(decimal?), string Notes = default(string), ETAStatus Status = default(ETAStatus), Condition Condition = default(Condition), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.WorkOrderId = WorkOrderId;
            this.User = User;
            this.Mode = Mode;
            this.Start = Start;
            this.End = End;
            this.HourEstimate = HourEstimate;
            this.Notes = Notes;
            this.Status = Status;
            this.Condition = Condition;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }


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
        /// Gets or Sets HourEstimate
        /// </summary>
        [DataMember(Name="hour_estimate", EmitDefaultValue=false)]
        public decimal? HourEstimate { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ETAStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public Condition Condition { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETA {\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  HourEstimate: ").Append(HourEstimate).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as ETA);
        }

        /// <summary>
        /// Returns true if ETA instances are equal
        /// </summary>
        /// <param name="other">Instance of ETA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETA other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkOrderId == other.WorkOrderId ||
                    this.WorkOrderId != null &&
                    this.WorkOrderId.Equals(other.WorkOrderId)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
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
                ) && 
                (
                    this.HourEstimate == other.HourEstimate ||
                    this.HourEstimate != null &&
                    this.HourEstimate.Equals(other.HourEstimate)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Condition == other.Condition ||
                    this.Condition != null &&
                    this.Condition.Equals(other.Condition)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                if (this.WorkOrderId != null)
                    hash = hash * 59 + this.WorkOrderId.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();
                if (this.HourEstimate != null)
                    hash = hash * 59 + this.HourEstimate.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Condition != null)
                    hash = hash * 59 + this.Condition.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
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
