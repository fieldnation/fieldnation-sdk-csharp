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
    /// ProblemResolution
    /// </summary>
    [DataContract]
    public partial class ProblemResolution :  IEquatable<ProblemResolution>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Resolved for "resolved"
            /// </summary>
            [EnumMember(Value = "resolved")]
            Resolved,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open
        }


        /// <summary>
        /// Gets or Sets AllowedResolvers
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowedResolversEnum
        {
            
            /// <summary>
            /// Enum Support for "support"
            /// </summary>
            [EnumMember(Value = "support")]
            Support,
            
            /// <summary>
            /// Enum Buyer for "buyer"
            /// </summary>
            [EnumMember(Value = "buyer")]
            Buyer,
            
            /// <summary>
            /// Enum Assignedprovider for "assigned_provider"
            /// </summary>
            [EnumMember(Value = "assigned_provider")]
            Assignedprovider
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets AllowedResolvers
        /// </summary>
        [DataMember(Name="allowed_resolvers", EmitDefaultValue=false)]
        public List<AllowedResolversEnum> AllowedResolvers { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemResolution" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="At">At.</param>
        /// <param name="By">By.</param>
        /// <param name="AllowedResolvers">AllowedResolvers.</param>
        public ProblemResolution(StatusEnum? Status = default(StatusEnum?), DateTime? At = default(DateTime?), User By = default(User), List<AllowedResolversEnum> AllowedResolvers = default(List<AllowedResolversEnum>))
        {
            this.Status = Status;
            this.At = At;
            this.By = By;
            this.AllowedResolvers = AllowedResolvers;
        }
        

        /// <summary>
        /// Gets or Sets At
        /// </summary>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public DateTime? At { get; set; }

        /// <summary>
        /// Gets or Sets By
        /// </summary>
        [DataMember(Name="by", EmitDefaultValue=false)]
        public User By { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemResolution {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  AllowedResolvers: ").Append(AllowedResolvers).Append("\n");
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
            return this.Equals(obj as ProblemResolution);
        }

        /// <summary>
        /// Returns true if ProblemResolution instances are equal
        /// </summary>
        /// <param name="other">Instance of ProblemResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemResolution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.At == other.At ||
                    this.At != null &&
                    this.At.Equals(other.At)
                ) && 
                (
                    this.By == other.By ||
                    this.By != null &&
                    this.By.Equals(other.By)
                ) && 
                (
                    this.AllowedResolvers == other.AllowedResolvers ||
                    this.AllowedResolvers != null &&
                    this.AllowedResolvers.SequenceEqual(other.AllowedResolvers)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.At != null)
                    hash = hash * 59 + this.At.GetHashCode();
                if (this.By != null)
                    hash = hash * 59 + this.By.GetHashCode();
                if (this.AllowedResolvers != null)
                    hash = hash * 59 + this.AllowedResolvers.GetHashCode();
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
