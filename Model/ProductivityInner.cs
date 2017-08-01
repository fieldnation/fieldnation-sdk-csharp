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
    /// ProductivityInner
    /// </summary>
    [DataContract]
    public partial class ProductivityInner :  IEquatable<ProductivityInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductivityInner" /> class.
        /// </summary>
        /// <param name="Manager">Site Mangager name.</param>
        /// <param name="TodayPublished">Today&#39;s WO&#39;s Published.</param>
        /// <param name="TodayPending">Today&#39;s WO&#39;s Pending.</param>
        /// <param name="TodayInProgress">Today&#39;s WO&#39;s In Progress.</param>
        /// <param name="TodayCompleted">Today&#39;s WO&#39;s Completed.</param>
        /// <param name="TodayOnHold">Today&#39;s WO&#39;s ON Hold.</param>
        /// <param name="WeekPublished">Week&#39;s WO&#39;s Published.</param>
        /// <param name="WeekPending">Week&#39;s WO&#39;s Pending.</param>
        /// <param name="WeekInProgress">Week&#39;s WO&#39;s In Progress.</param>
        /// <param name="WeekCompleted">Week&#39;s WO&#39;s Completed.</param>
        /// <param name="WeekOnHold">Week&#39;s WO&#39;s ON Hold.</param>
        /// <param name="Tomorrow">WO&#39;s Tomorrow.</param>
        /// <param name="ThisWeek">WO&#39;s This Week.</param>
        /// <param name="NextWeek">WO&#39;s Next Week.</param>
        /// <param name="NextFourWeeks">WO&#39;s Next 4 Weeks.</param>
        /// <param name="Jeopardy">72HR Jeopardy.</param>
        /// <param name="Completed">WO&#39;s Completed to Date.</param>
        public ProductivityInner(string Manager = default(string), decimal? TodayPublished = default(decimal?), decimal? TodayPending = default(decimal?), decimal? TodayInProgress = default(decimal?), decimal? TodayCompleted = default(decimal?), decimal? TodayOnHold = default(decimal?), decimal? WeekPublished = default(decimal?), decimal? WeekPending = default(decimal?), decimal? WeekInProgress = default(decimal?), decimal? WeekCompleted = default(decimal?), decimal? WeekOnHold = default(decimal?), decimal? Tomorrow = default(decimal?), decimal? ThisWeek = default(decimal?), decimal? NextWeek = default(decimal?), decimal? NextFourWeeks = default(decimal?), decimal? Jeopardy = default(decimal?), decimal? Completed = default(decimal?))
        {
            this.Manager = Manager;
            this.TodayPublished = TodayPublished;
            this.TodayPending = TodayPending;
            this.TodayInProgress = TodayInProgress;
            this.TodayCompleted = TodayCompleted;
            this.TodayOnHold = TodayOnHold;
            this.WeekPublished = WeekPublished;
            this.WeekPending = WeekPending;
            this.WeekInProgress = WeekInProgress;
            this.WeekCompleted = WeekCompleted;
            this.WeekOnHold = WeekOnHold;
            this.Tomorrow = Tomorrow;
            this.ThisWeek = ThisWeek;
            this.NextWeek = NextWeek;
            this.NextFourWeeks = NextFourWeeks;
            this.Jeopardy = Jeopardy;
            this.Completed = Completed;
        }
        
        /// <summary>
        /// Site Mangager name
        /// </summary>
        /// <value>Site Mangager name</value>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public string Manager { get; set; }

        /// <summary>
        /// Today&#39;s WO&#39;s Published
        /// </summary>
        /// <value>Today&#39;s WO&#39;s Published</value>
        [DataMember(Name="today_published", EmitDefaultValue=false)]
        public decimal? TodayPublished { get; set; }

        /// <summary>
        /// Today&#39;s WO&#39;s Pending
        /// </summary>
        /// <value>Today&#39;s WO&#39;s Pending</value>
        [DataMember(Name="today_pending", EmitDefaultValue=false)]
        public decimal? TodayPending { get; set; }

        /// <summary>
        /// Today&#39;s WO&#39;s In Progress
        /// </summary>
        /// <value>Today&#39;s WO&#39;s In Progress</value>
        [DataMember(Name="today_in_progress", EmitDefaultValue=false)]
        public decimal? TodayInProgress { get; set; }

        /// <summary>
        /// Today&#39;s WO&#39;s Completed
        /// </summary>
        /// <value>Today&#39;s WO&#39;s Completed</value>
        [DataMember(Name="today_completed", EmitDefaultValue=false)]
        public decimal? TodayCompleted { get; set; }

        /// <summary>
        /// Today&#39;s WO&#39;s ON Hold
        /// </summary>
        /// <value>Today&#39;s WO&#39;s ON Hold</value>
        [DataMember(Name="today_on_hold", EmitDefaultValue=false)]
        public decimal? TodayOnHold { get; set; }

        /// <summary>
        /// Week&#39;s WO&#39;s Published
        /// </summary>
        /// <value>Week&#39;s WO&#39;s Published</value>
        [DataMember(Name="week_published", EmitDefaultValue=false)]
        public decimal? WeekPublished { get; set; }

        /// <summary>
        /// Week&#39;s WO&#39;s Pending
        /// </summary>
        /// <value>Week&#39;s WO&#39;s Pending</value>
        [DataMember(Name="week_pending", EmitDefaultValue=false)]
        public decimal? WeekPending { get; set; }

        /// <summary>
        /// Week&#39;s WO&#39;s In Progress
        /// </summary>
        /// <value>Week&#39;s WO&#39;s In Progress</value>
        [DataMember(Name="week_in_progress", EmitDefaultValue=false)]
        public decimal? WeekInProgress { get; set; }

        /// <summary>
        /// Week&#39;s WO&#39;s Completed
        /// </summary>
        /// <value>Week&#39;s WO&#39;s Completed</value>
        [DataMember(Name="week_completed", EmitDefaultValue=false)]
        public decimal? WeekCompleted { get; set; }

        /// <summary>
        /// Week&#39;s WO&#39;s ON Hold
        /// </summary>
        /// <value>Week&#39;s WO&#39;s ON Hold</value>
        [DataMember(Name="week_on_hold", EmitDefaultValue=false)]
        public decimal? WeekOnHold { get; set; }

        /// <summary>
        /// WO&#39;s Tomorrow
        /// </summary>
        /// <value>WO&#39;s Tomorrow</value>
        [DataMember(Name="tomorrow", EmitDefaultValue=false)]
        public decimal? Tomorrow { get; set; }

        /// <summary>
        /// WO&#39;s This Week
        /// </summary>
        /// <value>WO&#39;s This Week</value>
        [DataMember(Name="this_week", EmitDefaultValue=false)]
        public decimal? ThisWeek { get; set; }

        /// <summary>
        /// WO&#39;s Next Week
        /// </summary>
        /// <value>WO&#39;s Next Week</value>
        [DataMember(Name="next_week", EmitDefaultValue=false)]
        public decimal? NextWeek { get; set; }

        /// <summary>
        /// WO&#39;s Next 4 Weeks
        /// </summary>
        /// <value>WO&#39;s Next 4 Weeks</value>
        [DataMember(Name="next_four_weeks", EmitDefaultValue=false)]
        public decimal? NextFourWeeks { get; set; }

        /// <summary>
        /// 72HR Jeopardy
        /// </summary>
        /// <value>72HR Jeopardy</value>
        [DataMember(Name="jeopardy", EmitDefaultValue=false)]
        public decimal? Jeopardy { get; set; }

        /// <summary>
        /// WO&#39;s Completed to Date
        /// </summary>
        /// <value>WO&#39;s Completed to Date</value>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public decimal? Completed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductivityInner {\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  TodayPublished: ").Append(TodayPublished).Append("\n");
            sb.Append("  TodayPending: ").Append(TodayPending).Append("\n");
            sb.Append("  TodayInProgress: ").Append(TodayInProgress).Append("\n");
            sb.Append("  TodayCompleted: ").Append(TodayCompleted).Append("\n");
            sb.Append("  TodayOnHold: ").Append(TodayOnHold).Append("\n");
            sb.Append("  WeekPublished: ").Append(WeekPublished).Append("\n");
            sb.Append("  WeekPending: ").Append(WeekPending).Append("\n");
            sb.Append("  WeekInProgress: ").Append(WeekInProgress).Append("\n");
            sb.Append("  WeekCompleted: ").Append(WeekCompleted).Append("\n");
            sb.Append("  WeekOnHold: ").Append(WeekOnHold).Append("\n");
            sb.Append("  Tomorrow: ").Append(Tomorrow).Append("\n");
            sb.Append("  ThisWeek: ").Append(ThisWeek).Append("\n");
            sb.Append("  NextWeek: ").Append(NextWeek).Append("\n");
            sb.Append("  NextFourWeeks: ").Append(NextFourWeeks).Append("\n");
            sb.Append("  Jeopardy: ").Append(Jeopardy).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
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
            return this.Equals(obj as ProductivityInner);
        }

        /// <summary>
        /// Returns true if ProductivityInner instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductivityInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductivityInner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
                ) && 
                (
                    this.TodayPublished == other.TodayPublished ||
                    this.TodayPublished != null &&
                    this.TodayPublished.Equals(other.TodayPublished)
                ) && 
                (
                    this.TodayPending == other.TodayPending ||
                    this.TodayPending != null &&
                    this.TodayPending.Equals(other.TodayPending)
                ) && 
                (
                    this.TodayInProgress == other.TodayInProgress ||
                    this.TodayInProgress != null &&
                    this.TodayInProgress.Equals(other.TodayInProgress)
                ) && 
                (
                    this.TodayCompleted == other.TodayCompleted ||
                    this.TodayCompleted != null &&
                    this.TodayCompleted.Equals(other.TodayCompleted)
                ) && 
                (
                    this.TodayOnHold == other.TodayOnHold ||
                    this.TodayOnHold != null &&
                    this.TodayOnHold.Equals(other.TodayOnHold)
                ) && 
                (
                    this.WeekPublished == other.WeekPublished ||
                    this.WeekPublished != null &&
                    this.WeekPublished.Equals(other.WeekPublished)
                ) && 
                (
                    this.WeekPending == other.WeekPending ||
                    this.WeekPending != null &&
                    this.WeekPending.Equals(other.WeekPending)
                ) && 
                (
                    this.WeekInProgress == other.WeekInProgress ||
                    this.WeekInProgress != null &&
                    this.WeekInProgress.Equals(other.WeekInProgress)
                ) && 
                (
                    this.WeekCompleted == other.WeekCompleted ||
                    this.WeekCompleted != null &&
                    this.WeekCompleted.Equals(other.WeekCompleted)
                ) && 
                (
                    this.WeekOnHold == other.WeekOnHold ||
                    this.WeekOnHold != null &&
                    this.WeekOnHold.Equals(other.WeekOnHold)
                ) && 
                (
                    this.Tomorrow == other.Tomorrow ||
                    this.Tomorrow != null &&
                    this.Tomorrow.Equals(other.Tomorrow)
                ) && 
                (
                    this.ThisWeek == other.ThisWeek ||
                    this.ThisWeek != null &&
                    this.ThisWeek.Equals(other.ThisWeek)
                ) && 
                (
                    this.NextWeek == other.NextWeek ||
                    this.NextWeek != null &&
                    this.NextWeek.Equals(other.NextWeek)
                ) && 
                (
                    this.NextFourWeeks == other.NextFourWeeks ||
                    this.NextFourWeeks != null &&
                    this.NextFourWeeks.Equals(other.NextFourWeeks)
                ) && 
                (
                    this.Jeopardy == other.Jeopardy ||
                    this.Jeopardy != null &&
                    this.Jeopardy.Equals(other.Jeopardy)
                ) && 
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
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
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                if (this.TodayPublished != null)
                    hash = hash * 59 + this.TodayPublished.GetHashCode();
                if (this.TodayPending != null)
                    hash = hash * 59 + this.TodayPending.GetHashCode();
                if (this.TodayInProgress != null)
                    hash = hash * 59 + this.TodayInProgress.GetHashCode();
                if (this.TodayCompleted != null)
                    hash = hash * 59 + this.TodayCompleted.GetHashCode();
                if (this.TodayOnHold != null)
                    hash = hash * 59 + this.TodayOnHold.GetHashCode();
                if (this.WeekPublished != null)
                    hash = hash * 59 + this.WeekPublished.GetHashCode();
                if (this.WeekPending != null)
                    hash = hash * 59 + this.WeekPending.GetHashCode();
                if (this.WeekInProgress != null)
                    hash = hash * 59 + this.WeekInProgress.GetHashCode();
                if (this.WeekCompleted != null)
                    hash = hash * 59 + this.WeekCompleted.GetHashCode();
                if (this.WeekOnHold != null)
                    hash = hash * 59 + this.WeekOnHold.GetHashCode();
                if (this.Tomorrow != null)
                    hash = hash * 59 + this.Tomorrow.GetHashCode();
                if (this.ThisWeek != null)
                    hash = hash * 59 + this.ThisWeek.GetHashCode();
                if (this.NextWeek != null)
                    hash = hash * 59 + this.NextWeek.GetHashCode();
                if (this.NextFourWeeks != null)
                    hash = hash * 59 + this.NextFourWeeks.GetHashCode();
                if (this.Jeopardy != null)
                    hash = hash * 59 + this.Jeopardy.GetHashCode();
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
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
