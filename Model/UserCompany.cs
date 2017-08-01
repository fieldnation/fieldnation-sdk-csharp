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
    /// UserCompany
    /// </summary>
    [DataContract]
    public partial class UserCompany :  IEquatable<UserCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCompany" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Features">Features.</param>
        /// <param name="Technicians">Technicians.</param>
        /// <param name="Vendors">Vendors.</param>
        /// <param name="Jobs">Jobs.</param>
        public UserCompany(int? Id = default(int?), string Name = default(string), List<string> Features = default(List<string>), int? Technicians = default(int?), List<Company> Vendors = default(List<Company>), UserJobs Jobs = default(UserJobs))
        {
            this.Id = Id;
            this.Name = Name;
            this.Features = Features;
            this.Technicians = Technicians;
            this.Vendors = Vendors;
            this.Jobs = Jobs;
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
        /// Gets or Sets Technicians
        /// </summary>
        [DataMember(Name="technicians", EmitDefaultValue=false)]
        public int? Technicians { get; set; }

        /// <summary>
        /// Gets or Sets Vendors
        /// </summary>
        [DataMember(Name="vendors", EmitDefaultValue=false)]
        public List<Company> Vendors { get; set; }

        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public UserJobs Jobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCompany {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Technicians: ").Append(Technicians).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
            return this.Equals(obj as UserCompany);
        }

        /// <summary>
        /// Returns true if UserCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of UserCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCompany other)
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
                    this.Technicians == other.Technicians ||
                    this.Technicians != null &&
                    this.Technicians.Equals(other.Technicians)
                ) && 
                (
                    this.Vendors == other.Vendors ||
                    this.Vendors != null &&
                    this.Vendors.SequenceEqual(other.Vendors)
                ) && 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
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
                if (this.Technicians != null)
                    hash = hash * 59 + this.Technicians.GetHashCode();
                if (this.Vendors != null)
                    hash = hash * 59 + this.Vendors.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
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
