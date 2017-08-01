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
    /// WorkHistoryInnerResults
    /// </summary>
    [DataContract]
    public partial class WorkHistoryInnerResults :  IEquatable<WorkHistoryInnerResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkHistoryInnerResults" /> class.
        /// </summary>
        /// <param name="TypeOfWorkId">TypeOfWorkId.</param>
        /// <param name="TypeOfWork">TypeOfWork.</param>
        /// <param name="Jobs">Jobs.</param>
        /// <param name="AverageHourlyRate">AverageHourlyRate.</param>
        public WorkHistoryInnerResults(int? TypeOfWorkId = default(int?), string TypeOfWork = default(string), int? Jobs = default(int?), decimal? AverageHourlyRate = default(decimal?))
        {
            this.TypeOfWorkId = TypeOfWorkId;
            this.TypeOfWork = TypeOfWork;
            this.Jobs = Jobs;
            this.AverageHourlyRate = AverageHourlyRate;
        }
        
        /// <summary>
        /// Gets or Sets TypeOfWorkId
        /// </summary>
        [DataMember(Name="type_of_work_id", EmitDefaultValue=false)]
        public int? TypeOfWorkId { get; set; }

        /// <summary>
        /// Gets or Sets TypeOfWork
        /// </summary>
        [DataMember(Name="type_of_work", EmitDefaultValue=false)]
        public string TypeOfWork { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkHistoryInnerResults {\n");
            sb.Append("  TypeOfWorkId: ").Append(TypeOfWorkId).Append("\n");
            sb.Append("  TypeOfWork: ").Append(TypeOfWork).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  AverageHourlyRate: ").Append(AverageHourlyRate).Append("\n");
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
            return this.Equals(obj as WorkHistoryInnerResults);
        }

        /// <summary>
        /// Returns true if WorkHistoryInnerResults instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkHistoryInnerResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkHistoryInnerResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TypeOfWorkId == other.TypeOfWorkId ||
                    this.TypeOfWorkId != null &&
                    this.TypeOfWorkId.Equals(other.TypeOfWorkId)
                ) && 
                (
                    this.TypeOfWork == other.TypeOfWork ||
                    this.TypeOfWork != null &&
                    this.TypeOfWork.Equals(other.TypeOfWork)
                ) && 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
                ) && 
                (
                    this.AverageHourlyRate == other.AverageHourlyRate ||
                    this.AverageHourlyRate != null &&
                    this.AverageHourlyRate.Equals(other.AverageHourlyRate)
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
                if (this.TypeOfWorkId != null)
                    hash = hash * 59 + this.TypeOfWorkId.GetHashCode();
                if (this.TypeOfWork != null)
                    hash = hash * 59 + this.TypeOfWork.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.AverageHourlyRate != null)
                    hash = hash * 59 + this.AverageHourlyRate.GetHashCode();
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
