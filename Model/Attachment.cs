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
    /// Attachment
    /// </summary>
    [DataContract]
    public partial class Attachment :  IEquatable<Attachment>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Approved for "approved"
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "denied"
            /// </summary>
            [EnumMember(Value = "denied")]
            Denied
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum View for "view"
            /// </summary>
            [EnumMember(Value = "view")]
            View,
            
            /// <summary>
            /// Enum Visibility for "visibility"
            /// </summary>
            [EnumMember(Value = "visibility")]
            Visibility,
            
            /// <summary>
            /// Enum Makepublic for "make_public"
            /// </summary>
            [EnumMember(Value = "make_public")]
            Makepublic,
            
            /// <summary>
            /// Enum Makeprivate for "make_private"
            /// </summary>
            [EnumMember(Value = "make_private")]
            Makeprivate,
            
            /// <summary>
            /// Enum Notes for "notes"
            /// </summary>
            [EnumMember(Value = "notes")]
            Notes,
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete,
            
            /// <summary>
            /// Enum Approve for "approve"
            /// </summary>
            [EnumMember(Value = "approve")]
            Approve,
            
            /// <summary>
            /// Enum Deny for "deny"
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny,
            
            /// <summary>
            /// Enum Reopen for "reopen"
            /// </summary>
            [EnumMember(Value = "reopen")]
            Reopen
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="FolderId">FolderId.</param>
        /// <param name="File">File.</param>
        /// <param name="Coords">Coords.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Reviewer">Reviewer.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusDescription">StatusDescription.</param>
        /// <param name="ShowBeforeAssignment">ShowBeforeAssignment.</param>
        /// <param name="Task">Task.</param>
        /// <param name="Reviewed">Reviewed.</param>
        /// <param name="Actions">Actions.</param>
        public Attachment(int? Id = default(int?), int? FolderId = default(int?), System.IO.Stream File = default(System.IO.Stream), Coords Coords = default(Coords), DateTime? Created = default(DateTime?), User Author = default(User), User Reviewer = default(User), string Notes = default(string), StatusEnum? Status = default(StatusEnum?), string StatusDescription = default(string), bool? ShowBeforeAssignment = default(bool?), Task Task = default(Task), DateTime? Reviewed = default(DateTime?), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.Id = Id;
            this.FolderId = FolderId;
            this.File = File;
            this.Coords = Coords;
            this.Created = Created;
            this.Author = Author;
            this.Reviewer = Reviewer;
            this.Notes = Notes;
            this.Status = Status;
            this.StatusDescription = StatusDescription;
            this.ShowBeforeAssignment = ShowBeforeAssignment;
            this.Task = Task;
            this.Reviewed = Reviewed;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name="folder_id", EmitDefaultValue=false)]
        public int? FolderId { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Gets or Sets Coords
        /// </summary>
        [DataMember(Name="coords", EmitDefaultValue=false)]
        public Coords Coords { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public User Author { get; set; }

        /// <summary>
        /// Gets or Sets Reviewer
        /// </summary>
        [DataMember(Name="reviewer", EmitDefaultValue=false)]
        public User Reviewer { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }


        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="status_description", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets ShowBeforeAssignment
        /// </summary>
        [DataMember(Name="show_before_assignment", EmitDefaultValue=false)]
        public bool? ShowBeforeAssignment { get; set; }

        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public Task Task { get; set; }

        /// <summary>
        /// Gets or Sets Reviewed
        /// </summary>
        [DataMember(Name="reviewed", EmitDefaultValue=false)]
        public DateTime? Reviewed { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Coords: ").Append(Coords).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  ShowBeforeAssignment: ").Append(ShowBeforeAssignment).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  Reviewed: ").Append(Reviewed).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="other">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment other)
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
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.File == other.File ||
                    this.File != null &&
                    this.File.Equals(other.File)
                ) && 
                (
                    this.Coords == other.Coords ||
                    this.Coords != null &&
                    this.Coords.Equals(other.Coords)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Reviewer == other.Reviewer ||
                    this.Reviewer != null &&
                    this.Reviewer.Equals(other.Reviewer)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusDescription == other.StatusDescription ||
                    this.StatusDescription != null &&
                    this.StatusDescription.Equals(other.StatusDescription)
                ) && 
                (
                    this.ShowBeforeAssignment == other.ShowBeforeAssignment ||
                    this.ShowBeforeAssignment != null &&
                    this.ShowBeforeAssignment.Equals(other.ShowBeforeAssignment)
                ) && 
                (
                    this.Task == other.Task ||
                    this.Task != null &&
                    this.Task.Equals(other.Task)
                ) && 
                (
                    this.Reviewed == other.Reviewed ||
                    this.Reviewed != null &&
                    this.Reviewed.Equals(other.Reviewed)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.File != null)
                    hash = hash * 59 + this.File.GetHashCode();
                if (this.Coords != null)
                    hash = hash * 59 + this.Coords.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Reviewer != null)
                    hash = hash * 59 + this.Reviewer.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hash = hash * 59 + this.StatusDescription.GetHashCode();
                if (this.ShowBeforeAssignment != null)
                    hash = hash * 59 + this.ShowBeforeAssignment.GetHashCode();
                if (this.Task != null)
                    hash = hash * 59 + this.Task.GetHashCode();
                if (this.Reviewed != null)
                    hash = hash * 59 + this.Reviewed.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
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
