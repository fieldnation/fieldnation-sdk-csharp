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
    /// Satisfaction
    /// </summary>
    [DataContract]
    public partial class Satisfaction :  IEquatable<Satisfaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Satisfaction" /> class.
        /// </summary>
        /// <param name="Stars">Stars.</param>
        /// <param name="ClearExpectation">ClearExpectation.</param>
        /// <param name="RespectRating">RespectRating.</param>
        /// <param name="AverageDaysToApproval">AverageDaysToApproval.</param>
        /// <param name="TotalRatings">TotalRatings.</param>
        public Satisfaction(decimal? Stars = default(decimal?), int? ClearExpectation = default(int?), int? RespectRating = default(int?), int? AverageDaysToApproval = default(int?), int? TotalRatings = default(int?))
        {
            this.Stars = Stars;
            this.ClearExpectation = ClearExpectation;
            this.RespectRating = RespectRating;
            this.AverageDaysToApproval = AverageDaysToApproval;
            this.TotalRatings = TotalRatings;
        }
        
        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [DataMember(Name="stars", EmitDefaultValue=false)]
        public decimal? Stars { get; set; }

        /// <summary>
        /// Gets or Sets ClearExpectation
        /// </summary>
        [DataMember(Name="clear_expectation", EmitDefaultValue=false)]
        public int? ClearExpectation { get; set; }

        /// <summary>
        /// Gets or Sets RespectRating
        /// </summary>
        [DataMember(Name="respect_rating", EmitDefaultValue=false)]
        public int? RespectRating { get; set; }

        /// <summary>
        /// Gets or Sets AverageDaysToApproval
        /// </summary>
        [DataMember(Name="average_days_to_approval", EmitDefaultValue=false)]
        public int? AverageDaysToApproval { get; set; }

        /// <summary>
        /// Gets or Sets TotalRatings
        /// </summary>
        [DataMember(Name="total_ratings", EmitDefaultValue=false)]
        public int? TotalRatings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Satisfaction {\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  ClearExpectation: ").Append(ClearExpectation).Append("\n");
            sb.Append("  RespectRating: ").Append(RespectRating).Append("\n");
            sb.Append("  AverageDaysToApproval: ").Append(AverageDaysToApproval).Append("\n");
            sb.Append("  TotalRatings: ").Append(TotalRatings).Append("\n");
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
            return this.Equals(obj as Satisfaction);
        }

        /// <summary>
        /// Returns true if Satisfaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Satisfaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Satisfaction other)
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
                    this.ClearExpectation == other.ClearExpectation ||
                    this.ClearExpectation != null &&
                    this.ClearExpectation.Equals(other.ClearExpectation)
                ) && 
                (
                    this.RespectRating == other.RespectRating ||
                    this.RespectRating != null &&
                    this.RespectRating.Equals(other.RespectRating)
                ) && 
                (
                    this.AverageDaysToApproval == other.AverageDaysToApproval ||
                    this.AverageDaysToApproval != null &&
                    this.AverageDaysToApproval.Equals(other.AverageDaysToApproval)
                ) && 
                (
                    this.TotalRatings == other.TotalRatings ||
                    this.TotalRatings != null &&
                    this.TotalRatings.Equals(other.TotalRatings)
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
                if (this.ClearExpectation != null)
                    hash = hash * 59 + this.ClearExpectation.GetHashCode();
                if (this.RespectRating != null)
                    hash = hash * 59 + this.RespectRating.GetHashCode();
                if (this.AverageDaysToApproval != null)
                    hash = hash * 59 + this.AverageDaysToApproval.GetHashCode();
                if (this.TotalRatings != null)
                    hash = hash * 59 + this.TotalRatings.GetHashCode();
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
