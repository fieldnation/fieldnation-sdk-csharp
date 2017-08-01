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
    /// ShipmentCarrier
    /// </summary>
    [DataContract]
    public partial class ShipmentCarrier :  IEquatable<ShipmentCarrier>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum Fedex for "fedex"
            /// </summary>
            [EnumMember(Value = "fedex")]
            Fedex,
            
            /// <summary>
            /// Enum Ups for "ups"
            /// </summary>
            [EnumMember(Value = "ups")]
            Ups,
            
            /// <summary>
            /// Enum Usps for "usps"
            /// </summary>
            [EnumMember(Value = "usps")]
            Usps,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentCarrier" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Other">Other.</param>
        /// <param name="Tracking">Tracking.</param>
        /// <param name="Arrival">Arrival.</param>
        /// <param name="Arrived">Arrived.</param>
        public ShipmentCarrier(NameEnum? Name = default(NameEnum?), string Other = default(string), string Tracking = default(string), DateTime? Arrival = default(DateTime?), DateTime? Arrived = default(DateTime?))
        {
            this.Name = Name;
            this.Other = Other;
            this.Tracking = Tracking;
            this.Arrival = Arrival;
            this.Arrived = Arrived;
        }
        

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets Tracking
        /// </summary>
        [DataMember(Name="tracking", EmitDefaultValue=false)]
        public string Tracking { get; set; }

        /// <summary>
        /// Gets or Sets Arrival
        /// </summary>
        [DataMember(Name="arrival", EmitDefaultValue=false)]
        public DateTime? Arrival { get; set; }

        /// <summary>
        /// Gets or Sets Arrived
        /// </summary>
        [DataMember(Name="arrived", EmitDefaultValue=false)]
        public DateTime? Arrived { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentCarrier {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  Arrival: ").Append(Arrival).Append("\n");
            sb.Append("  Arrived: ").Append(Arrived).Append("\n");
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
            return this.Equals(obj as ShipmentCarrier);
        }

        /// <summary>
        /// Returns true if ShipmentCarrier instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipmentCarrier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentCarrier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Other == other.Other ||
                    this.Other != null &&
                    this.Other.Equals(other.Other)
                ) && 
                (
                    this.Tracking == other.Tracking ||
                    this.Tracking != null &&
                    this.Tracking.Equals(other.Tracking)
                ) && 
                (
                    this.Arrival == other.Arrival ||
                    this.Arrival != null &&
                    this.Arrival.Equals(other.Arrival)
                ) && 
                (
                    this.Arrived == other.Arrived ||
                    this.Arrived != null &&
                    this.Arrived.Equals(other.Arrived)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Other != null)
                    hash = hash * 59 + this.Other.GetHashCode();
                if (this.Tracking != null)
                    hash = hash * 59 + this.Tracking.GetHashCode();
                if (this.Arrival != null)
                    hash = hash * 59 + this.Arrival.GetHashCode();
                if (this.Arrived != null)
                    hash = hash * 59 + this.Arrived.GetHashCode();
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
