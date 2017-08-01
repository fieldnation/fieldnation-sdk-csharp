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
    /// AttachmentConflict
    /// </summary>
    [DataContract]
    public partial class AttachmentConflict :  IEquatable<AttachmentConflict>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Unique for "unique"
            /// </summary>
            [EnumMember(Value = "unique")]
            Unique,
            
            /// <summary>
            /// Enum Duplicate for "duplicate"
            /// </summary>
            [EnumMember(Value = "duplicate")]
            Duplicate
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentConflict" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="Conflicts">Conflicts.</param>
        public AttachmentConflict(StatusEnum? Status = default(StatusEnum?), int? WorkOrderId = default(int?), List<int?> Conflicts = default(List<int?>))
        {
            this.Status = Status;
            this.WorkOrderId = WorkOrderId;
            this.Conflicts = Conflicts;
        }
        

        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Conflicts
        /// </summary>
        [DataMember(Name="conflicts", EmitDefaultValue=false)]
        public List<int?> Conflicts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentConflict {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  Conflicts: ").Append(Conflicts).Append("\n");
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
            return this.Equals(obj as AttachmentConflict);
        }

        /// <summary>
        /// Returns true if AttachmentConflict instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentConflict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentConflict other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.WorkOrderId == other.WorkOrderId ||
                    this.WorkOrderId != null &&
                    this.WorkOrderId.Equals(other.WorkOrderId)
                ) && 
                (
                    this.Conflicts == other.Conflicts ||
                    this.Conflicts != null &&
                    this.Conflicts.SequenceEqual(other.Conflicts)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.WorkOrderId != null)
                    hash = hash * 59 + this.WorkOrderId.GetHashCode();
                if (this.Conflicts != null)
                    hash = hash * 59 + this.Conflicts.GetHashCode();
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
