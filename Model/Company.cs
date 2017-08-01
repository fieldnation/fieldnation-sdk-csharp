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
    /// Company
    /// </summary>
    [DataContract]
    public partial class Company :  IEquatable<Company>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Features">Features.</param>
        /// <param name="Rating">Rating.</param>
        /// <param name="Blocked">Blocked.</param>
        /// <param name="Location">Location.</param>
        /// <param name="About">About.</param>
        /// <param name="ProviderCount">ProviderCount.</param>
        /// <param name="Jobs">Jobs.</param>
        /// <param name="Photo">Photo.</param>
        public Company(int? Id = default(int?), string Name = default(string), List<string> Features = default(List<string>), Rating Rating = default(Rating), bool? Blocked = default(bool?), Location Location = default(Location), string About = default(string), int? ProviderCount = default(int?), CompanyJobs Jobs = default(CompanyJobs), string Photo = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Features = Features;
            this.Rating = Rating;
            this.Blocked = Blocked;
            this.Location = Location;
            this.About = About;
            this.ProviderCount = ProviderCount;
            this.Jobs = Jobs;
            this.Photo = Photo;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public Rating Rating { get; set; }

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name="about", EmitDefaultValue=false)]
        public string About { get; set; }

        /// <summary>
        /// Gets or Sets ProviderCount
        /// </summary>
        [DataMember(Name="provider_count", EmitDefaultValue=false)]
        public int? ProviderCount { get; set; }

        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public CompanyJobs Jobs { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name="photo", EmitDefaultValue=false)]
        public string Photo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  ProviderCount: ").Append(ProviderCount).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
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
            return this.Equals(obj as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="other">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
                ) && 
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
                ) && 
                (
                    this.Blocked == other.Blocked ||
                    this.Blocked != null &&
                    this.Blocked.Equals(other.Blocked)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.About == other.About ||
                    this.About != null &&
                    this.About.Equals(other.About)
                ) && 
                (
                    this.ProviderCount == other.ProviderCount ||
                    this.ProviderCount != null &&
                    this.ProviderCount.Equals(other.ProviderCount)
                ) && 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
                ) && 
                (
                    this.Photo == other.Photo ||
                    this.Photo != null &&
                    this.Photo.Equals(other.Photo)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();
                if (this.Blocked != null)
                    hash = hash * 59 + this.Blocked.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.About != null)
                    hash = hash * 59 + this.About.GetHashCode();
                if (this.ProviderCount != null)
                    hash = hash * 59 + this.ProviderCount.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.Photo != null)
                    hash = hash * 59 + this.Photo.GetHashCode();
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
