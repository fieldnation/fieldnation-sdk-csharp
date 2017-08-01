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
    /// WorkOrderOverview
    /// </summary>
    [DataContract]
    public partial class WorkOrderOverview :  IEquatable<WorkOrderOverview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderOverview" /> class.
        /// </summary>
        /// <param name="TypeOfWork">TypeOfWork.</param>
        /// <param name="Company">Company.</param>
        public WorkOrderOverview(WorkOrderOverviewTypeOfWork TypeOfWork = default(WorkOrderOverviewTypeOfWork), WorkOrderOverviewCompany Company = default(WorkOrderOverviewCompany))
        {
            this.TypeOfWork = TypeOfWork;
            this.Company = Company;
        }
        
        /// <summary>
        /// Gets or Sets TypeOfWork
        /// </summary>
        [DataMember(Name="type_of_work", EmitDefaultValue=false)]
        public WorkOrderOverviewTypeOfWork TypeOfWork { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public WorkOrderOverviewCompany Company { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderOverview {\n");
            sb.Append("  TypeOfWork: ").Append(TypeOfWork).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
            return this.Equals(obj as WorkOrderOverview);
        }

        /// <summary>
        /// Returns true if WorkOrderOverview instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderOverview other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TypeOfWork == other.TypeOfWork ||
                    this.TypeOfWork != null &&
                    this.TypeOfWork.Equals(other.TypeOfWork)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
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
                if (this.TypeOfWork != null)
                    hash = hash * 59 + this.TypeOfWork.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
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
