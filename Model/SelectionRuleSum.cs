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
    /// SelectionRuleSum
    /// </summary>
    [DataContract]
    public partial class SelectionRuleSum :  IEquatable<SelectionRuleSum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionRuleSum" /> class.
        /// </summary>
        /// <param name="Match">Match.</param>
        /// <param name="NoMatchOptional">NoMatchOptional.</param>
        /// <param name="NoMatchRequired">NoMatchRequired.</param>
        /// <param name="Total">Total.</param>
        public SelectionRuleSum(int? Match = default(int?), int? NoMatchOptional = default(int?), int? NoMatchRequired = default(int?), int? Total = default(int?))
        {
            this.Match = Match;
            this.NoMatchOptional = NoMatchOptional;
            this.NoMatchRequired = NoMatchRequired;
            this.Total = Total;
        }
        
        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name="match", EmitDefaultValue=false)]
        public int? Match { get; set; }

        /// <summary>
        /// Gets or Sets NoMatchOptional
        /// </summary>
        [DataMember(Name="no_match_optional", EmitDefaultValue=false)]
        public int? NoMatchOptional { get; set; }

        /// <summary>
        /// Gets or Sets NoMatchRequired
        /// </summary>
        [DataMember(Name="no_match_required", EmitDefaultValue=false)]
        public int? NoMatchRequired { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectionRuleSum {\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  NoMatchOptional: ").Append(NoMatchOptional).Append("\n");
            sb.Append("  NoMatchRequired: ").Append(NoMatchRequired).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as SelectionRuleSum);
        }

        /// <summary>
        /// Returns true if SelectionRuleSum instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectionRuleSum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectionRuleSum other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Match == other.Match ||
                    this.Match != null &&
                    this.Match.Equals(other.Match)
                ) && 
                (
                    this.NoMatchOptional == other.NoMatchOptional ||
                    this.NoMatchOptional != null &&
                    this.NoMatchOptional.Equals(other.NoMatchOptional)
                ) && 
                (
                    this.NoMatchRequired == other.NoMatchRequired ||
                    this.NoMatchRequired != null &&
                    this.NoMatchRequired.Equals(other.NoMatchRequired)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.Match != null)
                    hash = hash * 59 + this.Match.GetHashCode();
                if (this.NoMatchOptional != null)
                    hash = hash * 59 + this.NoMatchOptional.GetHashCode();
                if (this.NoMatchRequired != null)
                    hash = hash * 59 + this.NoMatchRequired.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
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
