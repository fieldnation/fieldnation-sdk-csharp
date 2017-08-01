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
    /// EtaMassAccept
    /// </summary>
    [DataContract]
    public partial class EtaMassAccept :  IEquatable<EtaMassAccept>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EtaMassAccept" /> class.
        /// </summary>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="BundleId">BundleId.</param>
        /// <param name="Start">Start.</param>
        /// <param name="HourEstimate">HourEstimate.</param>
        /// <param name="Notes">Notes.</param>
        public EtaMassAccept(int? WorkOrderId = default(int?), int? BundleId = default(int?), DateTime? Start = default(DateTime?), decimal? HourEstimate = default(decimal?), string Notes = default(string))
        {
            this.WorkOrderId = WorkOrderId;
            this.BundleId = BundleId;
            this.Start = Start;
            this.HourEstimate = HourEstimate;
            this.Notes = Notes;
        }
        
        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }

        /// <summary>
        /// Gets or Sets BundleId
        /// </summary>
        [DataMember(Name="bundle_id", EmitDefaultValue=false)]
        public int? BundleId { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EtaMassAccept {\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  HourEstimate: ").Append(HourEstimate).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(obj as EtaMassAccept);
        }

        /// <summary>
        /// Returns true if EtaMassAccept instances are equal
        /// </summary>
        /// <param name="other">Instance of EtaMassAccept to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EtaMassAccept other)
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
                    this.BundleId == other.BundleId ||
                    this.BundleId != null &&
                    this.BundleId.Equals(other.BundleId)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
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
                if (this.BundleId != null)
                    hash = hash * 59 + this.BundleId.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.HourEstimate != null)
                    hash = hash * 59 + this.HourEstimate.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
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
