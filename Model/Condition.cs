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
    /// Condition
    /// </summary>
    [DataContract]
    public partial class Condition :  IEquatable<Condition>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Empty for ""
            /// </summary>
            [EnumMember(Value = "")]
            Empty,
            
            /// <summary>
            /// Enum Onschedule for "on_schedule"
            /// </summary>
            [EnumMember(Value = "on_schedule")]
            Onschedule,
            
            /// <summary>
            /// Enum Delayed for "delayed"
            /// </summary>
            [EnumMember(Value = "delayed")]
            Delayed,
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Atrisk for "at_risk"
            /// </summary>
            [EnumMember(Value = "at_risk")]
            Atrisk,
            
            /// <summary>
            /// Enum Reschedulerequested for "reschedule_requested"
            /// </summary>
            [EnumMember(Value = "reschedule_requested")]
            Reschedulerequested
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Created">Created.</param>
        /// <param name="DriveTime">DriveTime.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="Status">Status.</param>
        /// <param name="EstimatedDelay">EstimatedDelay.</param>
        /// <param name="Coords">Coords.</param>
        /// <param name="Route">Route.</param>
        public Condition(User User = default(User), DateTime? Created = default(DateTime?), int? DriveTime = default(int?), decimal? Distance = default(decimal?), StatusEnum? Status = default(StatusEnum?), int? EstimatedDelay = default(int?), Coords Coords = default(Coords), Coords Route = default(Coords))
        {
            this.User = User;
            this.Created = Created;
            this.DriveTime = DriveTime;
            this.Distance = Distance;
            this.Status = Status;
            this.EstimatedDelay = EstimatedDelay;
            this.Coords = Coords;
            this.Route = Route;
        }
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets DriveTime
        /// </summary>
        [DataMember(Name="drive_time", EmitDefaultValue=false)]
        public int? DriveTime { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }


        /// <summary>
        /// Gets or Sets EstimatedDelay
        /// </summary>
        [DataMember(Name="estimated_delay", EmitDefaultValue=false)]
        public int? EstimatedDelay { get; set; }

        /// <summary>
        /// Gets or Sets Coords
        /// </summary>
        [DataMember(Name="coords", EmitDefaultValue=false)]
        public Coords Coords { get; set; }

        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public Coords Route { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DriveTime: ").Append(DriveTime).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EstimatedDelay: ").Append(EstimatedDelay).Append("\n");
            sb.Append("  Coords: ").Append(Coords).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
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
            return this.Equals(obj as Condition);
        }

        /// <summary>
        /// Returns true if Condition instances are equal
        /// </summary>
        /// <param name="other">Instance of Condition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Condition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.DriveTime == other.DriveTime ||
                    this.DriveTime != null &&
                    this.DriveTime.Equals(other.DriveTime)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.EstimatedDelay == other.EstimatedDelay ||
                    this.EstimatedDelay != null &&
                    this.EstimatedDelay.Equals(other.EstimatedDelay)
                ) && 
                (
                    this.Coords == other.Coords ||
                    this.Coords != null &&
                    this.Coords.Equals(other.Coords)
                ) && 
                (
                    this.Route == other.Route ||
                    this.Route != null &&
                    this.Route.Equals(other.Route)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.DriveTime != null)
                    hash = hash * 59 + this.DriveTime.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.EstimatedDelay != null)
                    hash = hash * 59 + this.EstimatedDelay.GetHashCode();
                if (this.Coords != null)
                    hash = hash * 59 + this.Coords.GetHashCode();
                if (this.Route != null)
                    hash = hash * 59 + this.Route.GetHashCode();
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
