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
    /// WorkOrderRatings
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatings :  IEquatable<WorkOrderRatings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatings" /> class.
        /// </summary>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Buyer">Buyer.</param>
        /// <param name="AssignedProvider">AssignedProvider.</param>
        /// <param name="ServiceCompany">ServiceCompany.</param>
        public WorkOrderRatings(string CorrelationId = default(string), WorkOrderRatingsBuyer Buyer = default(WorkOrderRatingsBuyer), WorkOrderRatingsAssignedProvider AssignedProvider = default(WorkOrderRatingsAssignedProvider), WorkOrderRatingsServiceCompany ServiceCompany = default(WorkOrderRatingsServiceCompany))
        {
            this.CorrelationId = CorrelationId;
            this.Buyer = Buyer;
            this.AssignedProvider = AssignedProvider;
            this.ServiceCompany = ServiceCompany;
        }
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Buyer
        /// </summary>
        [DataMember(Name="buyer", EmitDefaultValue=false)]
        public WorkOrderRatingsBuyer Buyer { get; set; }

        /// <summary>
        /// Gets or Sets AssignedProvider
        /// </summary>
        [DataMember(Name="assigned_provider", EmitDefaultValue=false)]
        public WorkOrderRatingsAssignedProvider AssignedProvider { get; set; }

        /// <summary>
        /// Gets or Sets ServiceCompany
        /// </summary>
        [DataMember(Name="service_company", EmitDefaultValue=false)]
        public WorkOrderRatingsServiceCompany ServiceCompany { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatings {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  AssignedProvider: ").Append(AssignedProvider).Append("\n");
            sb.Append("  ServiceCompany: ").Append(ServiceCompany).Append("\n");
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
            return this.Equals(obj as WorkOrderRatings);
        }

        /// <summary>
        /// Returns true if WorkOrderRatings instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Buyer == other.Buyer ||
                    this.Buyer != null &&
                    this.Buyer.Equals(other.Buyer)
                ) && 
                (
                    this.AssignedProvider == other.AssignedProvider ||
                    this.AssignedProvider != null &&
                    this.AssignedProvider.Equals(other.AssignedProvider)
                ) && 
                (
                    this.ServiceCompany == other.ServiceCompany ||
                    this.ServiceCompany != null &&
                    this.ServiceCompany.Equals(other.ServiceCompany)
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
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Buyer != null)
                    hash = hash * 59 + this.Buyer.GetHashCode();
                if (this.AssignedProvider != null)
                    hash = hash * 59 + this.AssignedProvider.GetHashCode();
                if (this.ServiceCompany != null)
                    hash = hash * 59 + this.ServiceCompany.GetHashCode();
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
