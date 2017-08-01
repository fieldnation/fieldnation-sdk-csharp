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
    /// WorkOrderOverviewCompany
    /// </summary>
    [DataContract]
    public partial class WorkOrderOverviewCompany :  IEquatable<WorkOrderOverviewCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderOverviewCompany" /> class.
        /// </summary>
        /// <param name="AverageDuration">AverageDuration.</param>
        /// <param name="Jobs">Jobs.</param>
        /// <param name="Paid">Paid.</param>
        /// <param name="PercentCounters">PercentCounters.</param>
        /// <param name="PercentExpenses">PercentExpenses.</param>
        /// <param name="ActiveJobs">ActiveJobs.</param>
        /// <param name="CancelledJobs">CancelledJobs.</param>
        public WorkOrderOverviewCompany(int? AverageDuration = default(int?), int? Jobs = default(int?), decimal? Paid = default(decimal?), decimal? PercentCounters = default(decimal?), decimal? PercentExpenses = default(decimal?), int? ActiveJobs = default(int?), int? CancelledJobs = default(int?))
        {
            this.AverageDuration = AverageDuration;
            this.Jobs = Jobs;
            this.Paid = Paid;
            this.PercentCounters = PercentCounters;
            this.PercentExpenses = PercentExpenses;
            this.ActiveJobs = ActiveJobs;
            this.CancelledJobs = CancelledJobs;
        }
        
        /// <summary>
        /// Gets or Sets AverageDuration
        /// </summary>
        [DataMember(Name="average_duration", EmitDefaultValue=false)]
        public int? AverageDuration { get; set; }

        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public int? Jobs { get; set; }

        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public decimal? Paid { get; set; }

        /// <summary>
        /// Gets or Sets PercentCounters
        /// </summary>
        [DataMember(Name="percent_counters", EmitDefaultValue=false)]
        public decimal? PercentCounters { get; set; }

        /// <summary>
        /// Gets or Sets PercentExpenses
        /// </summary>
        [DataMember(Name="percent_expenses", EmitDefaultValue=false)]
        public decimal? PercentExpenses { get; set; }

        /// <summary>
        /// Gets or Sets ActiveJobs
        /// </summary>
        [DataMember(Name="active_jobs", EmitDefaultValue=false)]
        public int? ActiveJobs { get; set; }

        /// <summary>
        /// Gets or Sets CancelledJobs
        /// </summary>
        [DataMember(Name="cancelled_jobs", EmitDefaultValue=false)]
        public int? CancelledJobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderOverviewCompany {\n");
            sb.Append("  AverageDuration: ").Append(AverageDuration).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  PercentCounters: ").Append(PercentCounters).Append("\n");
            sb.Append("  PercentExpenses: ").Append(PercentExpenses).Append("\n");
            sb.Append("  ActiveJobs: ").Append(ActiveJobs).Append("\n");
            sb.Append("  CancelledJobs: ").Append(CancelledJobs).Append("\n");
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
            return this.Equals(obj as WorkOrderOverviewCompany);
        }

        /// <summary>
        /// Returns true if WorkOrderOverviewCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderOverviewCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderOverviewCompany other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AverageDuration == other.AverageDuration ||
                    this.AverageDuration != null &&
                    this.AverageDuration.Equals(other.AverageDuration)
                ) && 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
                ) && 
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) && 
                (
                    this.PercentCounters == other.PercentCounters ||
                    this.PercentCounters != null &&
                    this.PercentCounters.Equals(other.PercentCounters)
                ) && 
                (
                    this.PercentExpenses == other.PercentExpenses ||
                    this.PercentExpenses != null &&
                    this.PercentExpenses.Equals(other.PercentExpenses)
                ) && 
                (
                    this.ActiveJobs == other.ActiveJobs ||
                    this.ActiveJobs != null &&
                    this.ActiveJobs.Equals(other.ActiveJobs)
                ) && 
                (
                    this.CancelledJobs == other.CancelledJobs ||
                    this.CancelledJobs != null &&
                    this.CancelledJobs.Equals(other.CancelledJobs)
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
                if (this.AverageDuration != null)
                    hash = hash * 59 + this.AverageDuration.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                if (this.PercentCounters != null)
                    hash = hash * 59 + this.PercentCounters.GetHashCode();
                if (this.PercentExpenses != null)
                    hash = hash * 59 + this.PercentExpenses.GetHashCode();
                if (this.ActiveJobs != null)
                    hash = hash * 59 + this.ActiveJobs.GetHashCode();
                if (this.CancelledJobs != null)
                    hash = hash * 59 + this.CancelledJobs.GetHashCode();
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
