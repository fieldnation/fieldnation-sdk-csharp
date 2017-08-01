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
    /// WorkOrderRatingsAssignedProviderWorkOrderCategories
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsAssignedProviderWorkOrderCategories :  IEquatable<WorkOrderRatingsAssignedProviderWorkOrderCategories>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Ontime for "on_time"
            /// </summary>
            [EnumMember(Value = "on_time")]
            Ontime,
            
            /// <summary>
            /// Enum Followinstructions for "follow_instructions"
            /// </summary>
            [EnumMember(Value = "follow_instructions")]
            Followinstructions,
            
            /// <summary>
            /// Enum Assignmentfulfilled for "assignment_fulfilled"
            /// </summary>
            [EnumMember(Value = "assignment_fulfilled")]
            Assignmentfulfilled,
            
            /// <summary>
            /// Enum Rightdeliverables for "right_deliverables"
            /// </summary>
            [EnumMember(Value = "right_deliverables")]
            Rightdeliverables
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsAssignedProviderWorkOrderCategories" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Value">Value.</param>
        public WorkOrderRatingsAssignedProviderWorkOrderCategories(TypeEnum? Type = default(TypeEnum?), int? Value = default(int?))
        {
            this.Type = Type;
            this.Value = Value;
        }
        

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsAssignedProviderWorkOrderCategories {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsAssignedProviderWorkOrderCategories);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsAssignedProviderWorkOrderCategories instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsAssignedProviderWorkOrderCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsAssignedProviderWorkOrderCategories other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
