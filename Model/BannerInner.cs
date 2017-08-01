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
    /// BannerInner
    /// </summary>
    [DataContract]
    public partial class BannerInner :  IEquatable<BannerInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BannerInner" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="Image">Image.</param>
        /// <param name="Href">Href.</param>
        /// <param name="Deleted">Deleted.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Groups">Groups.</param>
        /// <param name="CompanyIds">CompanyIds.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="StartsAt">StartsAt.</param>
        /// <param name="EndsAt">EndsAt.</param>
        public BannerInner(int? Id = default(int?), int? UserId = default(int?), string Image = default(string), string Href = default(string), bool? Deleted = default(bool?), User Author = default(User), List<int?> Groups = default(List<int?>), List<int?> CompanyIds = default(List<int?>), Utc CreatedAt = default(Utc), Utc StartsAt = default(Utc), Utc EndsAt = default(Utc))
        {
            this.Id = Id;
            this.UserId = UserId;
            this.Image = Image;
            this.Href = Href;
            this.Deleted = Deleted;
            this.Author = Author;
            this.Groups = Groups;
            this.CompanyIds = CompanyIds;
            this.CreatedAt = CreatedAt;
            this.StartsAt = StartsAt;
            this.EndsAt = EndsAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public User Author { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<int?> Groups { get; set; }

        /// <summary>
        /// Gets or Sets CompanyIds
        /// </summary>
        [DataMember(Name="company_ids", EmitDefaultValue=false)]
        public List<int?> CompanyIds { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public Utc CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets StartsAt
        /// </summary>
        [DataMember(Name="starts_at", EmitDefaultValue=false)]
        public Utc StartsAt { get; set; }

        /// <summary>
        /// Gets or Sets EndsAt
        /// </summary>
        [DataMember(Name="ends_at", EmitDefaultValue=false)]
        public Utc EndsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BannerInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  CompanyIds: ").Append(CompanyIds).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  EndsAt: ").Append(EndsAt).Append("\n");
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
            return this.Equals(obj as BannerInner);
        }

        /// <summary>
        /// Returns true if BannerInner instances are equal
        /// </summary>
        /// <param name="other">Instance of BannerInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BannerInner other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.CompanyIds == other.CompanyIds ||
                    this.CompanyIds != null &&
                    this.CompanyIds.SequenceEqual(other.CompanyIds)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.StartsAt == other.StartsAt ||
                    this.StartsAt != null &&
                    this.StartsAt.Equals(other.StartsAt)
                ) && 
                (
                    this.EndsAt == other.EndsAt ||
                    this.EndsAt != null &&
                    this.EndsAt.Equals(other.EndsAt)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.CompanyIds != null)
                    hash = hash * 59 + this.CompanyIds.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.StartsAt != null)
                    hash = hash * 59 + this.StartsAt.GetHashCode();
                if (this.EndsAt != null)
                    hash = hash * 59 + this.EndsAt.GetHashCode();
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
