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
    /// File
    /// </summary>
    [DataContract]
    public partial class File :  IEquatable<File>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum File for "file"
            /// </summary>
            [EnumMember(Value = "file")]
            File,
            
            /// <summary>
            /// Enum Link for "link"
            /// </summary>
            [EnumMember(Value = "link")]
            Link
        }

        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StorageEnum
        {
            
            /// <summary>
            /// Enum S3 for "s3"
            /// </summary>
            [EnumMember(Value = "s3")]
            S3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public StorageEnum? Storage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Icon">Icon.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Description">Description.</param>
        /// <param name="SizeBytes">SizeBytes.</param>
        /// <param name="Mime">Mime.</param>
        /// <param name="Hash">Hash.</param>
        /// <param name="Storage">Storage.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Link">Link.</param>
        /// <param name="PreviewFull">PreviewFull.</param>
        public File(string Name = default(string), string Icon = default(string), TypeEnum? Type = default(TypeEnum?), string Description = default(string), int? SizeBytes = default(int?), string Mime = default(string), string Hash = default(string), StorageEnum? Storage = default(StorageEnum?), string Thumbnail = default(string), string Link = default(string), string PreviewFull = default(string))
        {
            this.Name = Name;
            this.Icon = Icon;
            this.Type = Type;
            this.Description = Description;
            this.SizeBytes = SizeBytes;
            this.Mime = Mime;
            this.Hash = Hash;
            this.Storage = Storage;
            this.Thumbnail = Thumbnail;
            this.Link = Link;
            this.PreviewFull = PreviewFull;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }


        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SizeBytes
        /// </summary>
        [DataMember(Name="size_bytes", EmitDefaultValue=false)]
        public int? SizeBytes { get; set; }

        /// <summary>
        /// Gets or Sets Mime
        /// </summary>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }


        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets PreviewFull
        /// </summary>
        [DataMember(Name="preview_full", EmitDefaultValue=false)]
        public string PreviewFull { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class File {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  PreviewFull: ").Append(PreviewFull).Append("\n");
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
            return this.Equals(obj as File);
        }

        /// <summary>
        /// Returns true if File instances are equal
        /// </summary>
        /// <param name="other">Instance of File to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(File other)
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
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.SizeBytes == other.SizeBytes ||
                    this.SizeBytes != null &&
                    this.SizeBytes.Equals(other.SizeBytes)
                ) && 
                (
                    this.Mime == other.Mime ||
                    this.Mime != null &&
                    this.Mime.Equals(other.Mime)
                ) && 
                (
                    this.Hash == other.Hash ||
                    this.Hash != null &&
                    this.Hash.Equals(other.Hash)
                ) && 
                (
                    this.Storage == other.Storage ||
                    this.Storage != null &&
                    this.Storage.Equals(other.Storage)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
                ) && 
                (
                    this.PreviewFull == other.PreviewFull ||
                    this.PreviewFull != null &&
                    this.PreviewFull.Equals(other.PreviewFull)
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
                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.SizeBytes != null)
                    hash = hash * 59 + this.SizeBytes.GetHashCode();
                if (this.Mime != null)
                    hash = hash * 59 + this.Mime.GetHashCode();
                if (this.Hash != null)
                    hash = hash * 59 + this.Hash.GetHashCode();
                if (this.Storage != null)
                    hash = hash * 59 + this.Storage.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();
                if (this.PreviewFull != null)
                    hash = hash * 59 + this.PreviewFull.GetHashCode();
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
