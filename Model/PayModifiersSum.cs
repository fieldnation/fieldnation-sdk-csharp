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
    /// PayModifiersSum
    /// </summary>
    [DataContract]
    public partial class PayModifiersSum :  IEquatable<PayModifiersSum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayModifiersSum" /> class.
        /// </summary>
        /// <param name="All">All.</param>
        /// <param name="Charged">Charged.</param>
        /// <param name="Uncharged">Uncharged.</param>
        public PayModifiersSum(decimal? All = default(decimal?), decimal? Charged = default(decimal?), decimal? Uncharged = default(decimal?))
        {
            this.All = All;
            this.Charged = Charged;
            this.Uncharged = Uncharged;
        }
        
        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public decimal? All { get; set; }

        /// <summary>
        /// Gets or Sets Charged
        /// </summary>
        [DataMember(Name="charged", EmitDefaultValue=false)]
        public decimal? Charged { get; set; }

        /// <summary>
        /// Gets or Sets Uncharged
        /// </summary>
        [DataMember(Name="uncharged", EmitDefaultValue=false)]
        public decimal? Uncharged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayModifiersSum {\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  Charged: ").Append(Charged).Append("\n");
            sb.Append("  Uncharged: ").Append(Uncharged).Append("\n");
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
            return this.Equals(obj as PayModifiersSum);
        }

        /// <summary>
        /// Returns true if PayModifiersSum instances are equal
        /// </summary>
        /// <param name="other">Instance of PayModifiersSum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayModifiersSum other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.All == other.All ||
                    this.All != null &&
                    this.All.Equals(other.All)
                ) && 
                (
                    this.Charged == other.Charged ||
                    this.Charged != null &&
                    this.Charged.Equals(other.Charged)
                ) && 
                (
                    this.Uncharged == other.Uncharged ||
                    this.Uncharged != null &&
                    this.Uncharged.Equals(other.Uncharged)
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
                if (this.All != null)
                    hash = hash * 59 + this.All.GetHashCode();
                if (this.Charged != null)
                    hash = hash * 59 + this.Charged.GetHashCode();
                if (this.Uncharged != null)
                    hash = hash * 59 + this.Uncharged.GetHashCode();
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
