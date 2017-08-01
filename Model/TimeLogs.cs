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
    /// TimeLogs
    /// </summary>
    [DataContract]
    public partial class TimeLogs :  IEquatable<TimeLogs>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Canverify for "can_verify"
            /// </summary>
            [EnumMember(Value = "can_verify")]
            Canverify,
            
            /// <summary>
            /// Enum Add for "add"
            /// </summary>
            [EnumMember(Value = "add")]
            Add,
            
            /// <summary>
            /// Enum Checkin for "checkin"
            /// </summary>
            [EnumMember(Value = "checkin")]
            Checkin
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeLogs" /> class.
        /// </summary>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="Hours">Hours.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Confirmed">Confirmed.</param>
        /// <param name="Onmyway">Onmyway.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="OpenTimeLog">OpenTimeLog.</param>
        /// <param name="Results">Results.</param>
        public TimeLogs(ListEnvelope Metadata = default(ListEnvelope), TimeZone TimeZone = default(TimeZone), decimal? Hours = default(decimal?), string Status = default(string), DateTime? Confirmed = default(DateTime?), OnMyWay Onmyway = default(OnMyWay), List<ActionsEnum> Actions = default(List<ActionsEnum>), TimeLog OpenTimeLog = default(TimeLog), List<TimeLog> Results = default(List<TimeLog>))
        {
            this.Metadata = Metadata;
            this.TimeZone = TimeZone;
            this.Hours = Hours;
            this.Status = Status;
            this.Confirmed = Confirmed;
            this.Onmyway = Onmyway;
            this.Actions = Actions;
            this.OpenTimeLog = OpenTimeLog;
            this.Results = Results;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ListEnvelope Metadata { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public decimal? Hours { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Confirmed
        /// </summary>
        [DataMember(Name="confirmed", EmitDefaultValue=false)]
        public DateTime? Confirmed { get; set; }

        /// <summary>
        /// Gets or Sets Onmyway
        /// </summary>
        [DataMember(Name="onmyway", EmitDefaultValue=false)]
        public OnMyWay Onmyway { get; set; }


        /// <summary>
        /// Gets or Sets OpenTimeLog
        /// </summary>
        [DataMember(Name="open_time_log", EmitDefaultValue=false)]
        public TimeLog OpenTimeLog { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<TimeLog> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeLogs {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Confirmed: ").Append(Confirmed).Append("\n");
            sb.Append("  Onmyway: ").Append(Onmyway).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  OpenTimeLog: ").Append(OpenTimeLog).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as TimeLogs);
        }

        /// <summary>
        /// Returns true if TimeLogs instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeLogs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Hours == other.Hours ||
                    this.Hours != null &&
                    this.Hours.Equals(other.Hours)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Confirmed == other.Confirmed ||
                    this.Confirmed != null &&
                    this.Confirmed.Equals(other.Confirmed)
                ) && 
                (
                    this.Onmyway == other.Onmyway ||
                    this.Onmyway != null &&
                    this.Onmyway.Equals(other.Onmyway)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.OpenTimeLog == other.OpenTimeLog ||
                    this.OpenTimeLog != null &&
                    this.OpenTimeLog.Equals(other.OpenTimeLog)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Hours != null)
                    hash = hash * 59 + this.Hours.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Confirmed != null)
                    hash = hash * 59 + this.Confirmed.GetHashCode();
                if (this.Onmyway != null)
                    hash = hash * 59 + this.Onmyway.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.OpenTimeLog != null)
                    hash = hash * 59 + this.OpenTimeLog.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
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
