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
    /// Assignee
    /// </summary>
    [DataContract]
    public partial class Assignee :  IEquatable<Assignee>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Unassign for "unassign"
            /// </summary>
            [EnumMember(Value = "unassign")]
            Unassign,
            
            /// <summary>
            /// Enum Readytogo for "ready_to_go"
            /// </summary>
            [EnumMember(Value = "ready_to_go")]
            Readytogo
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Assignee" /> class.
        /// </summary>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Role">Role.</param>
        /// <param name="User">User.</param>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="StatusId">StatusId.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="ReasonId">ReasonId.</param>
        /// <param name="Comment">Comment.</param>
        public Assignee(string CorrelationId = default(string), string Role = default(string), User User = default(User), int? WorkOrderId = default(int?), int? StatusId = default(int?), List<ActionsEnum> Actions = default(List<ActionsEnum>), int? ReasonId = default(int?), string Comment = default(string))
        {
            this.CorrelationId = CorrelationId;
            this.Role = Role;
            this.User = User;
            this.WorkOrderId = WorkOrderId;
            this.StatusId = StatusId;
            this.Actions = Actions;
            this.ReasonId = ReasonId;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name="status_id", EmitDefaultValue=false)]
        public int? StatusId { get; set; }


        /// <summary>
        /// Gets or Sets ReasonId
        /// </summary>
        [DataMember(Name="reason_id", EmitDefaultValue=false)]
        public int? ReasonId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assignee {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  ReasonId: ").Append(ReasonId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as Assignee);
        }

        /// <summary>
        /// Returns true if Assignee instances are equal
        /// </summary>
        /// <param name="other">Instance of Assignee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assignee other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.WorkOrderId == other.WorkOrderId ||
                    this.WorkOrderId != null &&
                    this.WorkOrderId.Equals(other.WorkOrderId)
                ) && 
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.ReasonId == other.ReasonId ||
                    this.ReasonId != null &&
                    this.ReasonId.Equals(other.ReasonId)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.WorkOrderId != null)
                    hash = hash * 59 + this.WorkOrderId.GetHashCode();
                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.ReasonId != null)
                    hash = hash * 59 + this.ReasonId.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
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
