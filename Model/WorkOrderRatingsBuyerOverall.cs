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
    /// WorkOrderRatingsBuyerOverall
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsBuyerOverall :  IEquatable<WorkOrderRatingsBuyerOverall>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsBuyerOverall" /> class.
        /// </summary>
        /// <param name="Ratings">Ratings.</param>
        /// <param name="Stars">Stars.</param>
        /// <param name="Jobs">Jobs.</param>
        /// <param name="PercentClearExpectations">PercentClearExpectations.</param>
        /// <param name="PercentRespectful">PercentRespectful.</param>
        /// <param name="ApprovalDays">ApprovalDays.</param>
        /// <param name="ApprovalPeriod">ApprovalPeriod.</param>
        /// <param name="PercentApproval">PercentApproval.</param>
        public WorkOrderRatingsBuyerOverall(int? Ratings = default(int?), decimal? Stars = default(decimal?), int? Jobs = default(int?), int? PercentClearExpectations = default(int?), int? PercentRespectful = default(int?), int? ApprovalDays = default(int?), int? ApprovalPeriod = default(int?), List<WorkOrderRatingsBuyerOverallPercentApproval> PercentApproval = default(List<WorkOrderRatingsBuyerOverallPercentApproval>))
        {
            this.Ratings = Ratings;
            this.Stars = Stars;
            this.Jobs = Jobs;
            this.PercentClearExpectations = PercentClearExpectations;
            this.PercentRespectful = PercentRespectful;
            this.ApprovalDays = ApprovalDays;
            this.ApprovalPeriod = ApprovalPeriod;
            this.PercentApproval = PercentApproval;
        }
        
        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name="ratings", EmitDefaultValue=false)]
        public int? Ratings { get; set; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [DataMember(Name="stars", EmitDefaultValue=false)]
        public decimal? Stars { get; set; }

        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public int? Jobs { get; set; }

        /// <summary>
        /// Gets or Sets PercentClearExpectations
        /// </summary>
        [DataMember(Name="percent_clear_expectations", EmitDefaultValue=false)]
        public int? PercentClearExpectations { get; set; }

        /// <summary>
        /// Gets or Sets PercentRespectful
        /// </summary>
        [DataMember(Name="percent_respectful", EmitDefaultValue=false)]
        public int? PercentRespectful { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalDays
        /// </summary>
        [DataMember(Name="approval_days", EmitDefaultValue=false)]
        public int? ApprovalDays { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalPeriod
        /// </summary>
        [DataMember(Name="approval_period", EmitDefaultValue=false)]
        public int? ApprovalPeriod { get; set; }

        /// <summary>
        /// Gets or Sets PercentApproval
        /// </summary>
        [DataMember(Name="percent_approval", EmitDefaultValue=false)]
        public List<WorkOrderRatingsBuyerOverallPercentApproval> PercentApproval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsBuyerOverall {\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  PercentClearExpectations: ").Append(PercentClearExpectations).Append("\n");
            sb.Append("  PercentRespectful: ").Append(PercentRespectful).Append("\n");
            sb.Append("  ApprovalDays: ").Append(ApprovalDays).Append("\n");
            sb.Append("  ApprovalPeriod: ").Append(ApprovalPeriod).Append("\n");
            sb.Append("  PercentApproval: ").Append(PercentApproval).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsBuyerOverall);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsBuyerOverall instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsBuyerOverall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsBuyerOverall other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ratings == other.Ratings ||
                    this.Ratings != null &&
                    this.Ratings.Equals(other.Ratings)
                ) && 
                (
                    this.Stars == other.Stars ||
                    this.Stars != null &&
                    this.Stars.Equals(other.Stars)
                ) && 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
                ) && 
                (
                    this.PercentClearExpectations == other.PercentClearExpectations ||
                    this.PercentClearExpectations != null &&
                    this.PercentClearExpectations.Equals(other.PercentClearExpectations)
                ) && 
                (
                    this.PercentRespectful == other.PercentRespectful ||
                    this.PercentRespectful != null &&
                    this.PercentRespectful.Equals(other.PercentRespectful)
                ) && 
                (
                    this.ApprovalDays == other.ApprovalDays ||
                    this.ApprovalDays != null &&
                    this.ApprovalDays.Equals(other.ApprovalDays)
                ) && 
                (
                    this.ApprovalPeriod == other.ApprovalPeriod ||
                    this.ApprovalPeriod != null &&
                    this.ApprovalPeriod.Equals(other.ApprovalPeriod)
                ) && 
                (
                    this.PercentApproval == other.PercentApproval ||
                    this.PercentApproval != null &&
                    this.PercentApproval.SequenceEqual(other.PercentApproval)
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
                if (this.Ratings != null)
                    hash = hash * 59 + this.Ratings.GetHashCode();
                if (this.Stars != null)
                    hash = hash * 59 + this.Stars.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.PercentClearExpectations != null)
                    hash = hash * 59 + this.PercentClearExpectations.GetHashCode();
                if (this.PercentRespectful != null)
                    hash = hash * 59 + this.PercentRespectful.GetHashCode();
                if (this.ApprovalDays != null)
                    hash = hash * 59 + this.ApprovalDays.GetHashCode();
                if (this.ApprovalPeriod != null)
                    hash = hash * 59 + this.ApprovalPeriod.GetHashCode();
                if (this.PercentApproval != null)
                    hash = hash * 59 + this.PercentApproval.GetHashCode();
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
