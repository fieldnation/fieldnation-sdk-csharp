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
    /// WorkOrderRatingsAssignedProvider
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsAssignedProvider :  IEquatable<WorkOrderRatingsAssignedProvider>, IValidatableObject
    {

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
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsAssignedProvider" /> class.
        /// </summary>
        /// <param name="Actions">Actions.</param>
        /// <param name="User">User.</param>
        /// <param name="WorkOrder">WorkOrder.</param>
        /// <param name="Overall">Overall.</param>
        /// <param name="Blocks">Blocks.</param>
        public WorkOrderRatingsAssignedProvider(List<ActionsEnum> Actions = default(List<ActionsEnum>), User User = default(User), WorkOrderRatingsAssignedProviderWorkOrder WorkOrder = default(WorkOrderRatingsAssignedProviderWorkOrder), WorkOrderRatingsAssignedProviderOverall Overall = default(WorkOrderRatingsAssignedProviderOverall), Block Blocks = default(Block))
        {
            this.Actions = Actions;
            this.User = User;
            this.WorkOrder = WorkOrder;
            this.Overall = Overall;
            this.Blocks = Blocks;
        }
        

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrder
        /// </summary>
        [DataMember(Name="work_order", EmitDefaultValue=false)]
        public WorkOrderRatingsAssignedProviderWorkOrder WorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public WorkOrderRatingsAssignedProviderOverall Overall { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public Block Blocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsAssignedProvider {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  WorkOrder: ").Append(WorkOrder).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsAssignedProvider);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsAssignedProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsAssignedProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsAssignedProvider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.WorkOrder == other.WorkOrder ||
                    this.WorkOrder != null &&
                    this.WorkOrder.Equals(other.WorkOrder)
                ) && 
                (
                    this.Overall == other.Overall ||
                    this.Overall != null &&
                    this.Overall.Equals(other.Overall)
                ) && 
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.Equals(other.Blocks)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.WorkOrder != null)
                    hash = hash * 59 + this.WorkOrder.GetHashCode();
                if (this.Overall != null)
                    hash = hash * 59 + this.Overall.GetHashCode();
                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();
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
