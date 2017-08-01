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
    /// AttachmentFolder
    /// </summary>
    [DataContract]
    public partial class AttachmentFolder :  IEquatable<AttachmentFolder>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Slot for "slot"
            /// </summary>
            [EnumMember(Value = "slot")]
            Slot,
            
            /// <summary>
            /// Enum Document for "document"
            /// </summary>
            [EnumMember(Value = "document")]
            Document
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Upload for "upload"
            /// </summary>
            [EnumMember(Value = "upload")]
            Upload,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentFolder" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="MinFiles">MinFiles.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Results">Results.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="Task">Task.</param>
        public AttachmentFolder(int? Id = default(int?), TypeEnum? Type = default(TypeEnum?), int? MinFiles = default(int?), string Name = default(string), List<Attachment> Results = default(List<Attachment>), List<ActionsEnum> Actions = default(List<ActionsEnum>), Task Task = default(Task))
        {
            this.Id = Id;
            this.Type = Type;
            this.MinFiles = MinFiles;
            this.Name = Name;
            this.Results = Results;
            this.Actions = Actions;
            this.Task = Task;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets MinFiles
        /// </summary>
        [DataMember(Name="min_files", EmitDefaultValue=false)]
        public int? MinFiles { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<Attachment> Results { get; set; }


        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public Task Task { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentFolder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinFiles: ").Append(MinFiles).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
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
            return this.Equals(obj as AttachmentFolder);
        }

        /// <summary>
        /// Returns true if AttachmentFolder instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentFolder other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.MinFiles == other.MinFiles ||
                    this.MinFiles != null &&
                    this.MinFiles.Equals(other.MinFiles)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.Task == other.Task ||
                    this.Task != null &&
                    this.Task.Equals(other.Task)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.MinFiles != null)
                    hash = hash * 59 + this.MinFiles.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Task != null)
                    hash = hash * 59 + this.Task.GetHashCode();
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
