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
    /// CheckInOut
    /// </summary>
    [DataContract]
    public partial class CheckInOut :  IEquatable<CheckInOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckInOut" /> class.
        /// </summary>
        /// <param name="TimeLog">TimeLog.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Actor">Actor.</param>
        /// <param name="Coords">Coords.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="DistanceFromCheckIn">DistanceFromCheckIn.</param>
        /// <param name="Verified">Verified.</param>
        public CheckInOut(ShipmentTask TimeLog = default(ShipmentTask), DateTime? Created = default(DateTime?), User Actor = default(User), Coords Coords = default(Coords), decimal? Distance = default(decimal?), decimal? DistanceFromCheckIn = default(decimal?), bool? Verified = default(bool?))
        {
            this.TimeLog = TimeLog;
            this.Created = Created;
            this.Actor = Actor;
            this.Coords = Coords;
            this.Distance = Distance;
            this.DistanceFromCheckIn = DistanceFromCheckIn;
            this.Verified = Verified;
        }
        
        /// <summary>
        /// Gets or Sets TimeLog
        /// </summary>
        [DataMember(Name="time_log", EmitDefaultValue=false)]
        public ShipmentTask TimeLog { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Actor
        /// </summary>
        [DataMember(Name="actor", EmitDefaultValue=false)]
        public User Actor { get; set; }

        /// <summary>
        /// Gets or Sets Coords
        /// </summary>
        [DataMember(Name="coords", EmitDefaultValue=false)]
        public Coords Coords { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }

        /// <summary>
        /// Gets or Sets DistanceFromCheckIn
        /// </summary>
        [DataMember(Name="distance_from_check_in", EmitDefaultValue=false)]
        public decimal? DistanceFromCheckIn { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckInOut {\n");
            sb.Append("  TimeLog: ").Append(TimeLog).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  Coords: ").Append(Coords).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DistanceFromCheckIn: ").Append(DistanceFromCheckIn).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return this.Equals(obj as CheckInOut);
        }

        /// <summary>
        /// Returns true if CheckInOut instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckInOut other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TimeLog == other.TimeLog ||
                    this.TimeLog != null &&
                    this.TimeLog.Equals(other.TimeLog)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Actor == other.Actor ||
                    this.Actor != null &&
                    this.Actor.Equals(other.Actor)
                ) && 
                (
                    this.Coords == other.Coords ||
                    this.Coords != null &&
                    this.Coords.Equals(other.Coords)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.DistanceFromCheckIn == other.DistanceFromCheckIn ||
                    this.DistanceFromCheckIn != null &&
                    this.DistanceFromCheckIn.Equals(other.DistanceFromCheckIn)
                ) && 
                (
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
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
                if (this.TimeLog != null)
                    hash = hash * 59 + this.TimeLog.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Actor != null)
                    hash = hash * 59 + this.Actor.GetHashCode();
                if (this.Coords != null)
                    hash = hash * 59 + this.Coords.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.DistanceFromCheckIn != null)
                    hash = hash * 59 + this.DistanceFromCheckIn.GetHashCode();
                if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();
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
