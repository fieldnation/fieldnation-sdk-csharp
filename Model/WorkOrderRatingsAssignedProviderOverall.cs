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
    /// WorkOrderRatingsAssignedProviderOverall
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsAssignedProviderOverall :  IEquatable<WorkOrderRatingsAssignedProviderOverall>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsAssignedProviderOverall" /> class.
        /// </summary>
        /// <param name="Company">Company.</param>
        /// <param name="Marketplace">Marketplace.</param>
        public WorkOrderRatingsAssignedProviderOverall(ProviderRatings Company = default(ProviderRatings), ProviderRatings Marketplace = default(ProviderRatings))
        {
            this.Company = Company;
            this.Marketplace = Marketplace;
        }
        
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public ProviderRatings Company { get; set; }

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name="marketplace", EmitDefaultValue=false)]
        public ProviderRatings Marketplace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsAssignedProviderOverall {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsAssignedProviderOverall);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsAssignedProviderOverall instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsAssignedProviderOverall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsAssignedProviderOverall other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Marketplace == other.Marketplace ||
                    this.Marketplace != null &&
                    this.Marketplace.Equals(other.Marketplace)
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
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Marketplace != null)
                    hash = hash * 59 + this.Marketplace.GetHashCode();
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
