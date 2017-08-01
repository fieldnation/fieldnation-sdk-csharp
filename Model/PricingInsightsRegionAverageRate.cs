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
    /// PricingInsightsRegionAverageRate
    /// </summary>
    [DataContract]
    public partial class PricingInsightsRegionAverageRate :  IEquatable<PricingInsightsRegionAverageRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingInsightsRegionAverageRate" /> class.
        /// </summary>
        /// <param name="FirstQuartile">FirstQuartile.</param>
        /// <param name="Median">Median.</param>
        /// <param name="ThirdQuartile">ThirdQuartile.</param>
        public PricingInsightsRegionAverageRate(decimal? FirstQuartile = default(decimal?), decimal? Median = default(decimal?), decimal? ThirdQuartile = default(decimal?))
        {
            this.FirstQuartile = FirstQuartile;
            this.Median = Median;
            this.ThirdQuartile = ThirdQuartile;
        }
        
        /// <summary>
        /// Gets or Sets FirstQuartile
        /// </summary>
        [DataMember(Name="first_quartile", EmitDefaultValue=false)]
        public decimal? FirstQuartile { get; set; }

        /// <summary>
        /// Gets or Sets Median
        /// </summary>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public decimal? Median { get; set; }

        /// <summary>
        /// Gets or Sets ThirdQuartile
        /// </summary>
        [DataMember(Name="third_quartile", EmitDefaultValue=false)]
        public decimal? ThirdQuartile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingInsightsRegionAverageRate {\n");
            sb.Append("  FirstQuartile: ").Append(FirstQuartile).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  ThirdQuartile: ").Append(ThirdQuartile).Append("\n");
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
            return this.Equals(obj as PricingInsightsRegionAverageRate);
        }

        /// <summary>
        /// Returns true if PricingInsightsRegionAverageRate instances are equal
        /// </summary>
        /// <param name="other">Instance of PricingInsightsRegionAverageRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingInsightsRegionAverageRate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstQuartile == other.FirstQuartile ||
                    this.FirstQuartile != null &&
                    this.FirstQuartile.Equals(other.FirstQuartile)
                ) && 
                (
                    this.Median == other.Median ||
                    this.Median != null &&
                    this.Median.Equals(other.Median)
                ) && 
                (
                    this.ThirdQuartile == other.ThirdQuartile ||
                    this.ThirdQuartile != null &&
                    this.ThirdQuartile.Equals(other.ThirdQuartile)
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
                if (this.FirstQuartile != null)
                    hash = hash * 59 + this.FirstQuartile.GetHashCode();
                if (this.Median != null)
                    hash = hash * 59 + this.Median.GetHashCode();
                if (this.ThirdQuartile != null)
                    hash = hash * 59 + this.ThirdQuartile.GetHashCode();
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
