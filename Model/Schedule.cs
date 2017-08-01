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
    /// Schedule
    /// </summary>
    [DataContract]
    public partial class Schedule :  IEquatable<Schedule>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TodayTomorrow
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TodayTomorrowEnum
        {
            
            /// <summary>
            /// Enum Today for "Today"
            /// </summary>
            [EnumMember(Value = "Today")]
            Today,
            
            /// <summary>
            /// Enum Tomorrow for "Tomorrow"
            /// </summary>
            [EnumMember(Value = "Tomorrow")]
            Tomorrow,
            
            /// <summary>
            /// Enum Empty for ""
            /// </summary>
            [EnumMember(Value = "")]
            Empty
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit
        }

        /// <summary>
        /// Gets or Sets TodayTomorrow
        /// </summary>
        [DataMember(Name="today_tomorrow", EmitDefaultValue=false)]
        public TodayTomorrowEnum? TodayTomorrow { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="TodayTomorrow">TodayTomorrow.</param>
        /// <param name="ServiceWindow">ServiceWindow.</param>
        /// <param name="OnMyWay">OnMyWay.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="Role">Role.</param>
        /// <param name="StatusId">StatusId.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="NoRefresh">NoRefresh.</param>
        public Schedule(int? WorkOrderId = default(int?), string CorrelationId = default(string), TodayTomorrowEnum? TodayTomorrow = default(TodayTomorrowEnum?), ScheduleServiceWindow ServiceWindow = default(ScheduleServiceWindow), OnMyWay OnMyWay = default(OnMyWay), TimeZone TimeZone = default(TimeZone), string Role = default(string), int? StatusId = default(int?), List<ActionsEnum> Actions = default(List<ActionsEnum>), bool? NoRefresh = default(bool?))
        {
            this.WorkOrderId = WorkOrderId;
            this.CorrelationId = CorrelationId;
            this.TodayTomorrow = TodayTomorrow;
            this.ServiceWindow = ServiceWindow;
            this.OnMyWay = OnMyWay;
            this.TimeZone = TimeZone;
            this.Role = Role;
            this.StatusId = StatusId;
            this.Actions = Actions;
            this.NoRefresh = NoRefresh;
        }
        
        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }


        /// <summary>
        /// Gets or Sets ServiceWindow
        /// </summary>
        [DataMember(Name="service_window", EmitDefaultValue=false)]
        public ScheduleServiceWindow ServiceWindow { get; set; }

        /// <summary>
        /// Gets or Sets OnMyWay
        /// </summary>
        [DataMember(Name="on_my_way", EmitDefaultValue=false)]
        public OnMyWay OnMyWay { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name="status_id", EmitDefaultValue=false)]
        public int? StatusId { get; set; }


        /// <summary>
        /// Gets or Sets NoRefresh
        /// </summary>
        [DataMember(Name="no_refresh", EmitDefaultValue=false)]
        public bool? NoRefresh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  TodayTomorrow: ").Append(TodayTomorrow).Append("\n");
            sb.Append("  ServiceWindow: ").Append(ServiceWindow).Append("\n");
            sb.Append("  OnMyWay: ").Append(OnMyWay).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  NoRefresh: ").Append(NoRefresh).Append("\n");
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
            return this.Equals(obj as Schedule);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="other">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkOrderId == other.WorkOrderId ||
                    this.WorkOrderId != null &&
                    this.WorkOrderId.Equals(other.WorkOrderId)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.TodayTomorrow == other.TodayTomorrow ||
                    this.TodayTomorrow != null &&
                    this.TodayTomorrow.Equals(other.TodayTomorrow)
                ) && 
                (
                    this.ServiceWindow == other.ServiceWindow ||
                    this.ServiceWindow != null &&
                    this.ServiceWindow.Equals(other.ServiceWindow)
                ) && 
                (
                    this.OnMyWay == other.OnMyWay ||
                    this.OnMyWay != null &&
                    this.OnMyWay.Equals(other.OnMyWay)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.NoRefresh == other.NoRefresh ||
                    this.NoRefresh != null &&
                    this.NoRefresh.Equals(other.NoRefresh)
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
                if (this.WorkOrderId != null)
                    hash = hash * 59 + this.WorkOrderId.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.TodayTomorrow != null)
                    hash = hash * 59 + this.TodayTomorrow.GetHashCode();
                if (this.ServiceWindow != null)
                    hash = hash * 59 + this.ServiceWindow.GetHashCode();
                if (this.OnMyWay != null)
                    hash = hash * 59 + this.OnMyWay.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.NoRefresh != null)
                    hash = hash * 59 + this.NoRefresh.GetHashCode();
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
