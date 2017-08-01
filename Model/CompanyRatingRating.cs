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
    /// CompanyRatingRating
    /// </summary>
    [DataContract]
    public partial class CompanyRatingRating :  IEquatable<CompanyRatingRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRatingRating" /> class.
        /// </summary>
        /// <param name="Marketplace">Marketplace.</param>
        /// <param name="Mine">Mine.</param>
        /// <param name="ToggleVisible">ToggleVisible.</param>
        public CompanyRatingRating(Satisfaction Marketplace = default(Satisfaction), Satisfaction Mine = default(Satisfaction), bool? ToggleVisible = default(bool?))
        {
            this.Marketplace = Marketplace;
            this.Mine = Mine;
            this.ToggleVisible = ToggleVisible;
        }
        
        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name="marketplace", EmitDefaultValue=false)]
        public Satisfaction Marketplace { get; set; }

        /// <summary>
        /// Gets or Sets Mine
        /// </summary>
        [DataMember(Name="mine", EmitDefaultValue=false)]
        public Satisfaction Mine { get; set; }

        /// <summary>
        /// Gets or Sets ToggleVisible
        /// </summary>
        [DataMember(Name="toggle_visible", EmitDefaultValue=false)]
        public bool? ToggleVisible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyRatingRating {\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Mine: ").Append(Mine).Append("\n");
            sb.Append("  ToggleVisible: ").Append(ToggleVisible).Append("\n");
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
            return this.Equals(obj as CompanyRatingRating);
        }

        /// <summary>
        /// Returns true if CompanyRatingRating instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyRatingRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyRatingRating other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Marketplace == other.Marketplace ||
                    this.Marketplace != null &&
                    this.Marketplace.Equals(other.Marketplace)
                ) && 
                (
                    this.Mine == other.Mine ||
                    this.Mine != null &&
                    this.Mine.Equals(other.Mine)
                ) && 
                (
                    this.ToggleVisible == other.ToggleVisible ||
                    this.ToggleVisible != null &&
                    this.ToggleVisible.Equals(other.ToggleVisible)
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
                if (this.Marketplace != null)
                    hash = hash * 59 + this.Marketplace.GetHashCode();
                if (this.Mine != null)
                    hash = hash * 59 + this.Mine.GetHashCode();
                if (this.ToggleVisible != null)
                    hash = hash * 59 + this.ToggleVisible.GetHashCode();
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
