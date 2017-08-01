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
    /// Milestones
    /// </summary>
    [DataContract]
    public partial class Milestones :  IEquatable<Milestones>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Milestones" /> class.
        /// </summary>
        /// <param name="TimeToDispatch">TimeToDispatch.</param>
        /// <param name="TimeToWorkDone">TimeToWorkDone.</param>
        /// <param name="TimeAlive">TimeAlive.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Published">Published.</param>
        /// <param name="Routed">Routed.</param>
        /// <param name="Assigned">Assigned.</param>
        /// <param name="Workdone">Workdone.</param>
        /// <param name="Approved">Approved.</param>
        /// <param name="Paid">Paid.</param>
        /// <param name="Canceled">Canceled.</param>
        public Milestones(decimal? TimeToDispatch = default(decimal?), decimal? TimeToWorkDone = default(decimal?), decimal? TimeAlive = default(decimal?), DateTime? Created = default(DateTime?), DateTime? Published = default(DateTime?), DateTime? Routed = default(DateTime?), DateTime? Assigned = default(DateTime?), DateTime? Workdone = default(DateTime?), DateTime? Approved = default(DateTime?), DateTime? Paid = default(DateTime?), DateTime? Canceled = default(DateTime?))
        {
            this.TimeToDispatch = TimeToDispatch;
            this.TimeToWorkDone = TimeToWorkDone;
            this.TimeAlive = TimeAlive;
            this.Created = Created;
            this.Published = Published;
            this.Routed = Routed;
            this.Assigned = Assigned;
            this.Workdone = Workdone;
            this.Approved = Approved;
            this.Paid = Paid;
            this.Canceled = Canceled;
        }
        
        /// <summary>
        /// Gets or Sets TimeToDispatch
        /// </summary>
        [DataMember(Name="time_to_dispatch", EmitDefaultValue=false)]
        public decimal? TimeToDispatch { get; set; }

        /// <summary>
        /// Gets or Sets TimeToWorkDone
        /// </summary>
        [DataMember(Name="time_to_work_done", EmitDefaultValue=false)]
        public decimal? TimeToWorkDone { get; set; }

        /// <summary>
        /// Gets or Sets TimeAlive
        /// </summary>
        [DataMember(Name="time_alive", EmitDefaultValue=false)]
        public decimal? TimeAlive { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public DateTime? Published { get; set; }

        /// <summary>
        /// Gets or Sets Routed
        /// </summary>
        [DataMember(Name="routed", EmitDefaultValue=false)]
        public DateTime? Routed { get; set; }

        /// <summary>
        /// Gets or Sets Assigned
        /// </summary>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public DateTime? Assigned { get; set; }

        /// <summary>
        /// Gets or Sets Workdone
        /// </summary>
        [DataMember(Name="workdone", EmitDefaultValue=false)]
        public DateTime? Workdone { get; set; }

        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public DateTime? Approved { get; set; }

        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public DateTime? Paid { get; set; }

        /// <summary>
        /// Gets or Sets Canceled
        /// </summary>
        [DataMember(Name="canceled", EmitDefaultValue=false)]
        public DateTime? Canceled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Milestones {\n");
            sb.Append("  TimeToDispatch: ").Append(TimeToDispatch).Append("\n");
            sb.Append("  TimeToWorkDone: ").Append(TimeToWorkDone).Append("\n");
            sb.Append("  TimeAlive: ").Append(TimeAlive).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Routed: ").Append(Routed).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  Workdone: ").Append(Workdone).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  Canceled: ").Append(Canceled).Append("\n");
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
            return this.Equals(obj as Milestones);
        }

        /// <summary>
        /// Returns true if Milestones instances are equal
        /// </summary>
        /// <param name="other">Instance of Milestones to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Milestones other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TimeToDispatch == other.TimeToDispatch ||
                    this.TimeToDispatch != null &&
                    this.TimeToDispatch.Equals(other.TimeToDispatch)
                ) && 
                (
                    this.TimeToWorkDone == other.TimeToWorkDone ||
                    this.TimeToWorkDone != null &&
                    this.TimeToWorkDone.Equals(other.TimeToWorkDone)
                ) && 
                (
                    this.TimeAlive == other.TimeAlive ||
                    this.TimeAlive != null &&
                    this.TimeAlive.Equals(other.TimeAlive)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) && 
                (
                    this.Routed == other.Routed ||
                    this.Routed != null &&
                    this.Routed.Equals(other.Routed)
                ) && 
                (
                    this.Assigned == other.Assigned ||
                    this.Assigned != null &&
                    this.Assigned.Equals(other.Assigned)
                ) && 
                (
                    this.Workdone == other.Workdone ||
                    this.Workdone != null &&
                    this.Workdone.Equals(other.Workdone)
                ) && 
                (
                    this.Approved == other.Approved ||
                    this.Approved != null &&
                    this.Approved.Equals(other.Approved)
                ) && 
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) && 
                (
                    this.Canceled == other.Canceled ||
                    this.Canceled != null &&
                    this.Canceled.Equals(other.Canceled)
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
                if (this.TimeToDispatch != null)
                    hash = hash * 59 + this.TimeToDispatch.GetHashCode();
                if (this.TimeToWorkDone != null)
                    hash = hash * 59 + this.TimeToWorkDone.GetHashCode();
                if (this.TimeAlive != null)
                    hash = hash * 59 + this.TimeAlive.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                if (this.Routed != null)
                    hash = hash * 59 + this.Routed.GetHashCode();
                if (this.Assigned != null)
                    hash = hash * 59 + this.Assigned.GetHashCode();
                if (this.Workdone != null)
                    hash = hash * 59 + this.Workdone.GetHashCode();
                if (this.Approved != null)
                    hash = hash * 59 + this.Approved.GetHashCode();
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                if (this.Canceled != null)
                    hash = hash * 59 + this.Canceled.GetHashCode();
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
