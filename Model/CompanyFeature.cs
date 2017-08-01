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
    /// CompanyFeature
    /// </summary>
    [DataContract]
    public partial class CompanyFeature :  IEquatable<CompanyFeature>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Enabled for "enabled"
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "disabled"
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled,
            
            /// <summary>
            /// Enum Requested for "requested"
            /// </summary>
            [EnumMember(Value = "requested")]
            Requested,
            
            /// <summary>
            /// Enum Denied for "denied"
            /// </summary>
            [EnumMember(Value = "denied")]
            Denied
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyFeature" /> class.
        /// </summary>
        /// <param name="CompanyFeaturesId">CompanyFeaturesId.</param>
        /// <param name="CompanyId">CompanyId.</param>
        /// <param name="FeatureId">FeatureId.</param>
        /// <param name="Status">Status.</param>
        public CompanyFeature(int? CompanyFeaturesId = default(int?), int? CompanyId = default(int?), int? FeatureId = default(int?), StatusEnum? Status = default(StatusEnum?))
        {
            this.CompanyFeaturesId = CompanyFeaturesId;
            this.CompanyId = CompanyId;
            this.FeatureId = FeatureId;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets CompanyFeaturesId
        /// </summary>
        [DataMember(Name="company_features_id", EmitDefaultValue=false)]
        public int? CompanyFeaturesId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets FeatureId
        /// </summary>
        [DataMember(Name="feature_id", EmitDefaultValue=false)]
        public int? FeatureId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyFeature {\n");
            sb.Append("  CompanyFeaturesId: ").Append(CompanyFeaturesId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as CompanyFeature);
        }

        /// <summary>
        /// Returns true if CompanyFeature instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyFeature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyFeaturesId == other.CompanyFeaturesId ||
                    this.CompanyFeaturesId != null &&
                    this.CompanyFeaturesId.Equals(other.CompanyFeaturesId)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.FeatureId == other.FeatureId ||
                    this.FeatureId != null &&
                    this.FeatureId.Equals(other.FeatureId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.CompanyFeaturesId != null)
                    hash = hash * 59 + this.CompanyFeaturesId.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.FeatureId != null)
                    hash = hash * 59 + this.FeatureId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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
