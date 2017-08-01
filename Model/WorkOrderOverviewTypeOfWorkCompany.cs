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
    /// WorkOrderOverviewTypeOfWorkCompany
    /// </summary>
    [DataContract]
    public partial class WorkOrderOverviewTypeOfWorkCompany :  IEquatable<WorkOrderOverviewTypeOfWorkCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderOverviewTypeOfWorkCompany" /> class.
        /// </summary>
        /// <param name="Jobs">Jobs.</param>
        /// <param name="AverageHourlyRate">AverageHourlyRate.</param>
        /// <param name="AverageDuration">AverageDuration.</param>
        public WorkOrderOverviewTypeOfWorkCompany(int? Jobs = default(int?), decimal? AverageHourlyRate = default(decimal?), decimal? AverageDuration = default(decimal?))
        {
            this.Jobs = Jobs;
            this.AverageHourlyRate = AverageHourlyRate;
            this.AverageDuration = AverageDuration;
        }
        
        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public int? Jobs { get; set; }

        /// <summary>
        /// Gets or Sets AverageHourlyRate
        /// </summary>
        [DataMember(Name="average_hourly_rate", EmitDefaultValue=false)]
        public decimal? AverageHourlyRate { get; set; }

        /// <summary>
        /// Gets or Sets AverageDuration
        /// </summary>
        [DataMember(Name="average_duration", EmitDefaultValue=false)]
        public decimal? AverageDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderOverviewTypeOfWorkCompany {\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  AverageHourlyRate: ").Append(AverageHourlyRate).Append("\n");
            sb.Append("  AverageDuration: ").Append(AverageDuration).Append("\n");
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
            return this.Equals(obj as WorkOrderOverviewTypeOfWorkCompany);
        }

        /// <summary>
        /// Returns true if WorkOrderOverviewTypeOfWorkCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderOverviewTypeOfWorkCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderOverviewTypeOfWorkCompany other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
                ) && 
                (
                    this.AverageHourlyRate == other.AverageHourlyRate ||
                    this.AverageHourlyRate != null &&
                    this.AverageHourlyRate.Equals(other.AverageHourlyRate)
                ) && 
                (
                    this.AverageDuration == other.AverageDuration ||
                    this.AverageDuration != null &&
                    this.AverageDuration.Equals(other.AverageDuration)
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
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.AverageHourlyRate != null)
                    hash = hash * 59 + this.AverageHourlyRate.GetHashCode();
                if (this.AverageDuration != null)
                    hash = hash * 59 + this.AverageDuration.GetHashCode();
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
