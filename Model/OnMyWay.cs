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
    /// OnMyWay
    /// </summary>
    [DataContract]
    public partial class OnMyWay :  IEquatable<OnMyWay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnMyWay" /> class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="Created">Created.</param>
        /// <param name="DriveTime">DriveTime.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Substatus">Substatus.</param>
        /// <param name="EstimatedDelay">EstimatedDelay.</param>
        /// <param name="Coords">Coords.</param>
        public OnMyWay(bool? Active = default(bool?), DateTime? Created = default(DateTime?), int? DriveTime = default(int?), decimal? Distance = default(decimal?), string Status = default(string), string Substatus = default(string), int? EstimatedDelay = default(int?), Coords Coords = default(Coords))
        {
            this.Active = Active;
            this.Created = Created;
            this.DriveTime = DriveTime;
            this.Distance = Distance;
            this.Status = Status;
            this.Substatus = Substatus;
            this.EstimatedDelay = EstimatedDelay;
            this.Coords = Coords;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Substatus
        /// </summary>
        [DataMember(Name="substatus", EmitDefaultValue=false)]
        public string Substatus { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnMyWay {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DriveTime: ").Append(DriveTime).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Substatus: ").Append(Substatus).Append("\n");
            sb.Append("  EstimatedDelay: ").Append(EstimatedDelay).Append("\n");
            sb.Append("  Coords: ").Append(Coords).Append("\n");
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
            return this.Equals(obj as OnMyWay);
        }

        /// <summary>
        /// Returns true if OnMyWay instances are equal
        /// </summary>
        /// <param name="other">Instance of OnMyWay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnMyWay other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                    this.Substatus == other.Substatus ||
                    this.Substatus != null &&
                    this.Substatus.Equals(other.Substatus)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.DriveTime != null)
                    hash = hash * 59 + this.DriveTime.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Substatus != null)
                    hash = hash * 59 + this.Substatus.GetHashCode();
                if (this.EstimatedDelay != null)
                    hash = hash * 59 + this.EstimatedDelay.GetHashCode();
                if (this.Coords != null)
                    hash = hash * 59 + this.Coords.GetHashCode();
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
