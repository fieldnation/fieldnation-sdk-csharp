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
    /// Coords
    /// </summary>
    [DataContract]
    public partial class Coords :  IEquatable<Coords>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coords" /> class.
        /// </summary>
        /// <param name="Latitude">Latitude.</param>
        /// <param name="Longitude">Longitude.</param>
        /// <param name="Exact">Exact.</param>
        /// <param name="Success">Success.</param>
        /// <param name="Search">Search.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="MapHref">MapHref.</param>
        public Coords(decimal? Latitude = default(decimal?), decimal? Longitude = default(decimal?), bool? Exact = default(bool?), bool? Success = default(bool?), string Search = default(string), decimal? Distance = default(decimal?), string MapHref = default(string))
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Exact = Exact;
            this.Success = Success;
            this.Search = Search;
            this.Distance = Distance;
            this.MapHref = MapHref;
        }
        
        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Exact
        /// </summary>
        [DataMember(Name="exact", EmitDefaultValue=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public string Search { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }

        /// <summary>
        /// Gets or Sets MapHref
        /// </summary>
        [DataMember(Name="map_href", EmitDefaultValue=false)]
        public string MapHref { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coords {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Exact: ").Append(Exact).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  MapHref: ").Append(MapHref).Append("\n");
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
            return this.Equals(obj as Coords);
        }

        /// <summary>
        /// Returns true if Coords instances are equal
        /// </summary>
        /// <param name="other">Instance of Coords to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coords other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.Exact == other.Exact ||
                    this.Exact != null &&
                    this.Exact.Equals(other.Exact)
                ) && 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) && 
                (
                    this.Search == other.Search ||
                    this.Search != null &&
                    this.Search.Equals(other.Search)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.MapHref == other.MapHref ||
                    this.MapHref != null &&
                    this.MapHref.Equals(other.MapHref)
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
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.Exact != null)
                    hash = hash * 59 + this.Exact.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                if (this.Search != null)
                    hash = hash * 59 + this.Search.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.MapHref != null)
                    hash = hash * 59 + this.MapHref.GetHashCode();
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
