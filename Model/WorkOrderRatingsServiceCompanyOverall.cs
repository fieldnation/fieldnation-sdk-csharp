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
    /// WorkOrderRatingsServiceCompanyOverall
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsServiceCompanyOverall :  IEquatable<WorkOrderRatingsServiceCompanyOverall>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsServiceCompanyOverall" /> class.
        /// </summary>
        /// <param name="Ratings">Ratings.</param>
        /// <param name="Stars">Stars.</param>
        /// <param name="Penalized">Penalized.</param>
        /// <param name="Categories">Categories.</param>
        public WorkOrderRatingsServiceCompanyOverall(int? Ratings = default(int?), decimal? Stars = default(decimal?), bool? Penalized = default(bool?), List<WorkOrderRatingsServiceCompanyOverallCategories> Categories = default(List<WorkOrderRatingsServiceCompanyOverallCategories>))
        {
            this.Ratings = Ratings;
            this.Stars = Stars;
            this.Penalized = Penalized;
            this.Categories = Categories;
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
        /// Gets or Sets Penalized
        /// </summary>
        [DataMember(Name="penalized", EmitDefaultValue=false)]
        public bool? Penalized { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<WorkOrderRatingsServiceCompanyOverallCategories> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsServiceCompanyOverall {\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Penalized: ").Append(Penalized).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsServiceCompanyOverall);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsServiceCompanyOverall instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsServiceCompanyOverall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsServiceCompanyOverall other)
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
                    this.Penalized == other.Penalized ||
                    this.Penalized != null &&
                    this.Penalized.Equals(other.Penalized)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
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
                if (this.Penalized != null)
                    hash = hash * 59 + this.Penalized.GetHashCode();
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
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
