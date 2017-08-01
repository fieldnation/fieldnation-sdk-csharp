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
    /// WorkOrderRatingsBuyer
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsBuyer :  IEquatable<WorkOrderRatingsBuyer>, IValidatableObject
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
            Edit
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsBuyer" /> class.
        /// </summary>
        /// <param name="Actions">Actions.</param>
        /// <param name="Manager">Manager.</param>
        /// <param name="Company">Company.</param>
        /// <param name="Overall">Overall.</param>
        /// <param name="WorkOrder">WorkOrder.</param>
        /// <param name="Blocks">Blocks.</param>
        public WorkOrderRatingsBuyer(List<ActionsEnum> Actions = default(List<ActionsEnum>), User Manager = default(User), ShipmentTask Company = default(ShipmentTask), WorkOrderRatingsBuyerOverall Overall = default(WorkOrderRatingsBuyerOverall), WorkOrderRatingsBuyerWorkOrder WorkOrder = default(WorkOrderRatingsBuyerWorkOrder), Block Blocks = default(Block))
        {
            this.Actions = Actions;
            this.Manager = Manager;
            this.Company = Company;
            this.Overall = Overall;
            this.WorkOrder = WorkOrder;
            this.Blocks = Blocks;
        }
        

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public User Manager { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public ShipmentTask Company { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public WorkOrderRatingsBuyerOverall Overall { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrder
        /// </summary>
        [DataMember(Name="work_order", EmitDefaultValue=false)]
        public WorkOrderRatingsBuyerWorkOrder WorkOrder { get; set; }

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
            sb.Append("class WorkOrderRatingsBuyer {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  WorkOrder: ").Append(WorkOrder).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsBuyer);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsBuyer instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsBuyer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsBuyer other)
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
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Overall == other.Overall ||
                    this.Overall != null &&
                    this.Overall.Equals(other.Overall)
                ) && 
                (
                    this.WorkOrder == other.WorkOrder ||
                    this.WorkOrder != null &&
                    this.WorkOrder.Equals(other.WorkOrder)
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
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Overall != null)
                    hash = hash * 59 + this.Overall.GetHashCode();
                if (this.WorkOrder != null)
                    hash = hash * 59 + this.WorkOrder.GetHashCode();
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
