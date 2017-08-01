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
    /// WorkOrderRatingsBuyerOverallPercentApproval
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsBuyerOverallPercentApproval :  IEquatable<WorkOrderRatingsBuyerOverallPercentApproval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsBuyerOverallPercentApproval" /> class.
        /// </summary>
        /// <param name="Days">Days.</param>
        /// <param name="Percent">Percent.</param>
        public WorkOrderRatingsBuyerOverallPercentApproval(int? Days = default(int?), int? Percent = default(int?))
        {
            this.Days = Days;
            this.Percent = Percent;
        }
        
        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public int? Days { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public int? Percent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsBuyerOverallPercentApproval {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsBuyerOverallPercentApproval);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsBuyerOverallPercentApproval instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsBuyerOverallPercentApproval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsBuyerOverallPercentApproval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Days == other.Days ||
                    this.Days != null &&
                    this.Days.Equals(other.Days)
                ) && 
                (
                    this.Percent == other.Percent ||
                    this.Percent != null &&
                    this.Percent.Equals(other.Percent)
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
                if (this.Days != null)
                    hash = hash * 59 + this.Days.GetHashCode();
                if (this.Percent != null)
                    hash = hash * 59 + this.Percent.GetHashCode();
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
