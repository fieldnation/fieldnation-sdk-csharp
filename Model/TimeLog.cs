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
    /// TimeLog
    /// </summary>
    [DataContract]
    public partial class TimeLog :  IEquatable<TimeLog>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum In for "checked_in"
            /// </summary>
            [EnumMember(Value = "checked_in")]
            In,
            
            /// <summary>
            /// Enum Out for "checked_out"
            /// </summary>
            [EnumMember(Value = "checked_out")]
            Out
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
            Edit,
            
            /// <summary>
            /// Enum Verify for "verify"
            /// </summary>
            [EnumMember(Value = "verify")]
            Verify,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeLog" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="_In">_In.</param>
        /// <param name="_Out">_Out.</param>
        /// <param name="Devices">Devices.</param>
        /// <param name="Hours">Hours.</param>
        /// <param name="Verified">Verified.</param>
        /// <param name="ShouldVerify">ShouldVerify.</param>
        /// <param name="WasLate">WasLate.</param>
        /// <param name="LoggedBy">LoggedBy.</param>
        /// <param name="OnMyWay">OnMyWay.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Actions">Actions.</param>
        public TimeLog(int? Id = default(int?), TimeZone TimeZone = default(TimeZone), CheckInOut _In = default(CheckInOut), CheckInOut _Out = default(CheckInOut), decimal? Devices = default(decimal?), decimal? Hours = default(decimal?), bool? Verified = default(bool?), bool? ShouldVerify = default(bool?), bool? WasLate = default(bool?), User LoggedBy = default(User), OnMyWay OnMyWay = default(OnMyWay), StatusEnum? Status = default(StatusEnum?), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.Id = Id;
            this.TimeZone = TimeZone;
            this._In = _In;
            this._Out = _Out;
            this.Devices = Devices;
            this.Hours = Hours;
            this.Verified = Verified;
            this.ShouldVerify = ShouldVerify;
            this.WasLate = WasLate;
            this.LoggedBy = LoggedBy;
            this.OnMyWay = OnMyWay;
            this.Status = Status;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets _In
        /// </summary>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public CheckInOut _In { get; set; }

        /// <summary>
        /// Gets or Sets _Out
        /// </summary>
        [DataMember(Name="out", EmitDefaultValue=false)]
        public CheckInOut _Out { get; set; }

        /// <summary>
        /// Gets or Sets Devices
        /// </summary>
        [DataMember(Name="devices", EmitDefaultValue=false)]
        public decimal? Devices { get; set; }

        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public decimal? Hours { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Gets or Sets ShouldVerify
        /// </summary>
        [DataMember(Name="should_verify", EmitDefaultValue=false)]
        public bool? ShouldVerify { get; set; }

        /// <summary>
        /// Gets or Sets WasLate
        /// </summary>
        [DataMember(Name="was_late", EmitDefaultValue=false)]
        public bool? WasLate { get; set; }

        /// <summary>
        /// Gets or Sets LoggedBy
        /// </summary>
        [DataMember(Name="logged_by", EmitDefaultValue=false)]
        public User LoggedBy { get; set; }

        /// <summary>
        /// Gets or Sets OnMyWay
        /// </summary>
        [DataMember(Name="on_my_way", EmitDefaultValue=false)]
        public OnMyWay OnMyWay { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  _In: ").Append(_In).Append("\n");
            sb.Append("  _Out: ").Append(_Out).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  ShouldVerify: ").Append(ShouldVerify).Append("\n");
            sb.Append("  WasLate: ").Append(WasLate).Append("\n");
            sb.Append("  LoggedBy: ").Append(LoggedBy).Append("\n");
            sb.Append("  OnMyWay: ").Append(OnMyWay).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as TimeLog);
        }

        /// <summary>
        /// Returns true if TimeLog instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this._In == other._In ||
                    this._In != null &&
                    this._In.Equals(other._In)
                ) && 
                (
                    this._Out == other._Out ||
                    this._Out != null &&
                    this._Out.Equals(other._Out)
                ) && 
                (
                    this.Devices == other.Devices ||
                    this.Devices != null &&
                    this.Devices.Equals(other.Devices)
                ) && 
                (
                    this.Hours == other.Hours ||
                    this.Hours != null &&
                    this.Hours.Equals(other.Hours)
                ) && 
                (
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
                ) && 
                (
                    this.ShouldVerify == other.ShouldVerify ||
                    this.ShouldVerify != null &&
                    this.ShouldVerify.Equals(other.ShouldVerify)
                ) && 
                (
                    this.WasLate == other.WasLate ||
                    this.WasLate != null &&
                    this.WasLate.Equals(other.WasLate)
                ) && 
                (
                    this.LoggedBy == other.LoggedBy ||
                    this.LoggedBy != null &&
                    this.LoggedBy.Equals(other.LoggedBy)
                ) && 
                (
                    this.OnMyWay == other.OnMyWay ||
                    this.OnMyWay != null &&
                    this.OnMyWay.Equals(other.OnMyWay)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this._In != null)
                    hash = hash * 59 + this._In.GetHashCode();
                if (this._Out != null)
                    hash = hash * 59 + this._Out.GetHashCode();
                if (this.Devices != null)
                    hash = hash * 59 + this.Devices.GetHashCode();
                if (this.Hours != null)
                    hash = hash * 59 + this.Hours.GetHashCode();
                if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();
                if (this.ShouldVerify != null)
                    hash = hash * 59 + this.ShouldVerify.GetHashCode();
                if (this.WasLate != null)
                    hash = hash * 59 + this.WasLate.GetHashCode();
                if (this.LoggedBy != null)
                    hash = hash * 59 + this.LoggedBy.GetHashCode();
                if (this.OnMyWay != null)
                    hash = hash * 59 + this.OnMyWay.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
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
