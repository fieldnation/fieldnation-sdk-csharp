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
    /// LocationCoordinates
    /// </summary>
    [DataContract]
    public partial class LocationCoordinates :  IEquatable<LocationCoordinates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationCoordinates" /> class.
        /// </summary>
        /// <param name="Type">Type of the object being looked up.</param>
        /// <param name="Id">Id of the item being looked up..</param>
        /// <param name="Latitude">Latitude of the item being looked up..</param>
        /// <param name="Longitude">Longitude of the item being looked up..</param>
        /// <param name="Exact">Whether the coordinates are an exact match..</param>
        /// <param name="City">City of the item.</param>
        /// <param name="State">State of the item.</param>
        /// <param name="Zip">Zip/Postal Code of the item.</param>
        /// <param name="Country">Country of the item.</param>
        public LocationCoordinates(string Type = default(string), int? Id = default(int?), decimal? Latitude = default(decimal?), decimal? Longitude = default(decimal?), bool? Exact = default(bool?), string City = default(string), string State = default(string), string Zip = default(string), string Country = default(string))
        {
            this.Type = Type;
            this.Id = Id;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Exact = Exact;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
        }
        
        /// <summary>
        /// Type of the object being looked up
        /// </summary>
        /// <value>Type of the object being looked up</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Id of the item being looked up.
        /// </summary>
        /// <value>Id of the item being looked up.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Latitude of the item being looked up.
        /// </summary>
        /// <value>Latitude of the item being looked up.</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Longitude of the item being looked up.
        /// </summary>
        /// <value>Longitude of the item being looked up.</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Whether the coordinates are an exact match.
        /// </summary>
        /// <value>Whether the coordinates are an exact match.</value>
        [DataMember(Name="exact", EmitDefaultValue=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// City of the item
        /// </summary>
        /// <value>City of the item</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State of the item
        /// </summary>
        /// <value>State of the item</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Zip/Postal Code of the item
        /// </summary>
        /// <value>Zip/Postal Code of the item</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Country of the item
        /// </summary>
        /// <value>Country of the item</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationCoordinates {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Exact: ").Append(Exact).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as LocationCoordinates);
        }

        /// <summary>
        /// Returns true if LocationCoordinates instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationCoordinates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationCoordinates other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
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
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.Exact != null)
                    hash = hash * 59 + this.Exact.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
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
