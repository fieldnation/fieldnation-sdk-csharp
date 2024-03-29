﻿/* 
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
    /// PricingInsights
    /// </summary>
    [DataContract]
    public partial class PricingInsights :  IEquatable<PricingInsights>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingInsights" /> class.
        /// </summary>
        /// <param name="Region">Region.</param>
        public PricingInsights(PricingInsightsRegion Region = default(PricingInsightsRegion))
        {
            this.Region = Region;
        }
        
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public PricingInsightsRegion Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingInsights {\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
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
            return this.Equals(obj as PricingInsights);
        }

        /// <summary>
        /// Returns true if PricingInsights instances are equal
        /// </summary>
        /// <param name="other">Instance of PricingInsights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingInsights other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
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
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
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
