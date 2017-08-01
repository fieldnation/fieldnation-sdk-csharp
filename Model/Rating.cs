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
    /// Rating
    /// </summary>
    [DataContract]
    public partial class Rating :  IEquatable<Rating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rating" /> class.
        /// </summary>
        /// <param name="Stars">Stars.</param>
        /// <param name="TotalRatings">TotalRatings.</param>
        /// <param name="OnTimePercent">OnTimePercent.</param>
        /// <param name="FollowInstructionsPercent">FollowInstructionsPercent.</param>
        /// <param name="AssignmentFulfilledPercent">AssignmentFulfilledPercent.</param>
        /// <param name="RightDeliverablesPercent">RightDeliverablesPercent.</param>
        /// <param name="Days90">Days90.</param>
        /// <param name="Days180">Days180.</param>
        /// <param name="Company">Company.</param>
        public Rating(decimal? Stars = default(decimal?), int? TotalRatings = default(int?), decimal? OnTimePercent = default(decimal?), decimal? FollowInstructionsPercent = default(decimal?), decimal? AssignmentFulfilledPercent = default(decimal?), decimal? RightDeliverablesPercent = default(decimal?), RatingDays90 Days90 = default(RatingDays90), RatingDays90 Days180 = default(RatingDays90), RatingCompany Company = default(RatingCompany))
        {
            this.Stars = Stars;
            this.TotalRatings = TotalRatings;
            this.OnTimePercent = OnTimePercent;
            this.FollowInstructionsPercent = FollowInstructionsPercent;
            this.AssignmentFulfilledPercent = AssignmentFulfilledPercent;
            this.RightDeliverablesPercent = RightDeliverablesPercent;
            this.Days90 = Days90;
            this.Days180 = Days180;
            this.Company = Company;
        }
        
        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [DataMember(Name="stars", EmitDefaultValue=false)]
        public decimal? Stars { get; set; }

        /// <summary>
        /// Gets or Sets TotalRatings
        /// </summary>
        [DataMember(Name="total_ratings", EmitDefaultValue=false)]
        public int? TotalRatings { get; set; }

        /// <summary>
        /// Gets or Sets OnTimePercent
        /// </summary>
        [DataMember(Name="on_time_percent", EmitDefaultValue=false)]
        public decimal? OnTimePercent { get; set; }

        /// <summary>
        /// Gets or Sets FollowInstructionsPercent
        /// </summary>
        [DataMember(Name="follow_instructions_percent", EmitDefaultValue=false)]
        public decimal? FollowInstructionsPercent { get; set; }

        /// <summary>
        /// Gets or Sets AssignmentFulfilledPercent
        /// </summary>
        [DataMember(Name="assignment_fulfilled_percent", EmitDefaultValue=false)]
        public decimal? AssignmentFulfilledPercent { get; set; }

        /// <summary>
        /// Gets or Sets RightDeliverablesPercent
        /// </summary>
        [DataMember(Name="right_deliverables_percent", EmitDefaultValue=false)]
        public decimal? RightDeliverablesPercent { get; set; }

        /// <summary>
        /// Gets or Sets Days90
        /// </summary>
        [DataMember(Name="days90", EmitDefaultValue=false)]
        public RatingDays90 Days90 { get; set; }

        /// <summary>
        /// Gets or Sets Days180
        /// </summary>
        [DataMember(Name="days180", EmitDefaultValue=false)]
        public RatingDays90 Days180 { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public RatingCompany Company { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rating {\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  TotalRatings: ").Append(TotalRatings).Append("\n");
            sb.Append("  OnTimePercent: ").Append(OnTimePercent).Append("\n");
            sb.Append("  FollowInstructionsPercent: ").Append(FollowInstructionsPercent).Append("\n");
            sb.Append("  AssignmentFulfilledPercent: ").Append(AssignmentFulfilledPercent).Append("\n");
            sb.Append("  RightDeliverablesPercent: ").Append(RightDeliverablesPercent).Append("\n");
            sb.Append("  Days90: ").Append(Days90).Append("\n");
            sb.Append("  Days180: ").Append(Days180).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
            return this.Equals(obj as Rating);
        }

        /// <summary>
        /// Returns true if Rating instances are equal
        /// </summary>
        /// <param name="other">Instance of Rating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rating other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Stars == other.Stars ||
                    this.Stars != null &&
                    this.Stars.Equals(other.Stars)
                ) && 
                (
                    this.TotalRatings == other.TotalRatings ||
                    this.TotalRatings != null &&
                    this.TotalRatings.Equals(other.TotalRatings)
                ) && 
                (
                    this.OnTimePercent == other.OnTimePercent ||
                    this.OnTimePercent != null &&
                    this.OnTimePercent.Equals(other.OnTimePercent)
                ) && 
                (
                    this.FollowInstructionsPercent == other.FollowInstructionsPercent ||
                    this.FollowInstructionsPercent != null &&
                    this.FollowInstructionsPercent.Equals(other.FollowInstructionsPercent)
                ) && 
                (
                    this.AssignmentFulfilledPercent == other.AssignmentFulfilledPercent ||
                    this.AssignmentFulfilledPercent != null &&
                    this.AssignmentFulfilledPercent.Equals(other.AssignmentFulfilledPercent)
                ) && 
                (
                    this.RightDeliverablesPercent == other.RightDeliverablesPercent ||
                    this.RightDeliverablesPercent != null &&
                    this.RightDeliverablesPercent.Equals(other.RightDeliverablesPercent)
                ) && 
                (
                    this.Days90 == other.Days90 ||
                    this.Days90 != null &&
                    this.Days90.Equals(other.Days90)
                ) && 
                (
                    this.Days180 == other.Days180 ||
                    this.Days180 != null &&
                    this.Days180.Equals(other.Days180)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
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
                if (this.Stars != null)
                    hash = hash * 59 + this.Stars.GetHashCode();
                if (this.TotalRatings != null)
                    hash = hash * 59 + this.TotalRatings.GetHashCode();
                if (this.OnTimePercent != null)
                    hash = hash * 59 + this.OnTimePercent.GetHashCode();
                if (this.FollowInstructionsPercent != null)
                    hash = hash * 59 + this.FollowInstructionsPercent.GetHashCode();
                if (this.AssignmentFulfilledPercent != null)
                    hash = hash * 59 + this.AssignmentFulfilledPercent.GetHashCode();
                if (this.RightDeliverablesPercent != null)
                    hash = hash * 59 + this.RightDeliverablesPercent.GetHashCode();
                if (this.Days90 != null)
                    hash = hash * 59 + this.Days90.GetHashCode();
                if (this.Days180 != null)
                    hash = hash * 59 + this.Days180.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
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
