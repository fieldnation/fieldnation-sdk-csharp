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
    /// CompanyIntegration
    /// </summary>
    [DataContract]
    public partial class CompanyIntegration :  IEquatable<CompanyIntegration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIntegration" /> class.
        /// </summary>
        /// <param name="CompanyIntegrationId">CompanyIntegrationId.</param>
        /// <param name="CompanyId">CompanyId.</param>
        /// <param name="IntegrationType">IntegrationType.</param>
        /// <param name="Active">Active.</param>
        /// <param name="ApiKey">ApiKey.</param>
        /// <param name="ApiPass">ApiPass.</param>
        /// <param name="ApiDomainName">ApiDomainName.</param>
        /// <param name="DisableNotifications">DisableNotifications.</param>
        /// <param name="ExternalApiIntegrationId">ExternalApiIntegrationId.</param>
        public CompanyIntegration(string CompanyIntegrationId = default(string), string CompanyId = default(string), string IntegrationType = default(string), bool? Active = default(bool?), string ApiKey = default(string), string ApiPass = default(string), string ApiDomainName = default(string), bool? DisableNotifications = default(bool?), string ExternalApiIntegrationId = default(string))
        {
            this.CompanyIntegrationId = CompanyIntegrationId;
            this.CompanyId = CompanyId;
            this.IntegrationType = IntegrationType;
            this.Active = Active;
            this.ApiKey = ApiKey;
            this.ApiPass = ApiPass;
            this.ApiDomainName = ApiDomainName;
            this.DisableNotifications = DisableNotifications;
            this.ExternalApiIntegrationId = ExternalApiIntegrationId;
        }
        
        /// <summary>
        /// Gets or Sets CompanyIntegrationId
        /// </summary>
        [DataMember(Name="company_integration_id", EmitDefaultValue=false)]
        public string CompanyIntegrationId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationType
        /// </summary>
        [DataMember(Name="integration_type", EmitDefaultValue=false)]
        public string IntegrationType { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets ApiPass
        /// </summary>
        [DataMember(Name="api_pass", EmitDefaultValue=false)]
        public string ApiPass { get; set; }

        /// <summary>
        /// Gets or Sets ApiDomainName
        /// </summary>
        [DataMember(Name="api_domain_name", EmitDefaultValue=false)]
        public string ApiDomainName { get; set; }

        /// <summary>
        /// Gets or Sets DisableNotifications
        /// </summary>
        [DataMember(Name="disable_notifications", EmitDefaultValue=false)]
        public bool? DisableNotifications { get; set; }

        /// <summary>
        /// Gets or Sets ExternalApiIntegrationId
        /// </summary>
        [DataMember(Name="external_api_integration_id", EmitDefaultValue=false)]
        public string ExternalApiIntegrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyIntegration {\n");
            sb.Append("  CompanyIntegrationId: ").Append(CompanyIntegrationId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  ApiPass: ").Append(ApiPass).Append("\n");
            sb.Append("  ApiDomainName: ").Append(ApiDomainName).Append("\n");
            sb.Append("  DisableNotifications: ").Append(DisableNotifications).Append("\n");
            sb.Append("  ExternalApiIntegrationId: ").Append(ExternalApiIntegrationId).Append("\n");
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
            return this.Equals(obj as CompanyIntegration);
        }

        /// <summary>
        /// Returns true if CompanyIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyIntegration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyIntegrationId == other.CompanyIntegrationId ||
                    this.CompanyIntegrationId != null &&
                    this.CompanyIntegrationId.Equals(other.CompanyIntegrationId)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.IntegrationType == other.IntegrationType ||
                    this.IntegrationType != null &&
                    this.IntegrationType.Equals(other.IntegrationType)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.ApiPass == other.ApiPass ||
                    this.ApiPass != null &&
                    this.ApiPass.Equals(other.ApiPass)
                ) && 
                (
                    this.ApiDomainName == other.ApiDomainName ||
                    this.ApiDomainName != null &&
                    this.ApiDomainName.Equals(other.ApiDomainName)
                ) && 
                (
                    this.DisableNotifications == other.DisableNotifications ||
                    this.DisableNotifications != null &&
                    this.DisableNotifications.Equals(other.DisableNotifications)
                ) && 
                (
                    this.ExternalApiIntegrationId == other.ExternalApiIntegrationId ||
                    this.ExternalApiIntegrationId != null &&
                    this.ExternalApiIntegrationId.Equals(other.ExternalApiIntegrationId)
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
                if (this.CompanyIntegrationId != null)
                    hash = hash * 59 + this.CompanyIntegrationId.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.IntegrationType != null)
                    hash = hash * 59 + this.IntegrationType.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                if (this.ApiPass != null)
                    hash = hash * 59 + this.ApiPass.GetHashCode();
                if (this.ApiDomainName != null)
                    hash = hash * 59 + this.ApiDomainName.GetHashCode();
                if (this.DisableNotifications != null)
                    hash = hash * 59 + this.DisableNotifications.GetHashCode();
                if (this.ExternalApiIntegrationId != null)
                    hash = hash * 59 + this.ExternalApiIntegrationId.GetHashCode();
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
