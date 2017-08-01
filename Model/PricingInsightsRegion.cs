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
    /// PricingInsightsRegion
    /// </summary>
    [DataContract]
    public partial class PricingInsightsRegion :  IEquatable<PricingInsightsRegion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingInsightsRegion" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="Providers">Providers.</param>
        /// <param name="AverageRate">AverageRate.</param>
        public PricingInsightsRegion(string Name = default(string), int? Id = default(int?), decimal? Distance = default(decimal?), PricingInsightsRegionProviders Providers = default(PricingInsightsRegionProviders), PricingInsightsRegionAverageRate AverageRate = default(PricingInsightsRegionAverageRate))
        {
            this.Name = Name;
            this.Id = Id;
            this.Distance = Distance;
            this.Providers = Providers;
            this.AverageRate = AverageRate;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public PricingInsightsRegionProviders Providers { get; set; }

        /// <summary>
        /// Gets or Sets AverageRate
        /// </summary>
        [DataMember(Name="average_rate", EmitDefaultValue=false)]
        public PricingInsightsRegionAverageRate AverageRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingInsightsRegion {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  AverageRate: ").Append(AverageRate).Append("\n");
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
            return this.Equals(obj as PricingInsightsRegion);
        }

        /// <summary>
        /// Returns true if PricingInsightsRegion instances are equal
        /// </summary>
        /// <param name="other">Instance of PricingInsightsRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingInsightsRegion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Providers == other.Providers ||
                    this.Providers != null &&
                    this.Providers.Equals(other.Providers)
                ) && 
                (
                    this.AverageRate == other.AverageRate ||
                    this.AverageRate != null &&
                    this.AverageRate.Equals(other.AverageRate)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Providers != null)
                    hash = hash * 59 + this.Providers.GetHashCode();
                if (this.AverageRate != null)
                    hash = hash * 59 + this.AverageRate.GetHashCode();
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
