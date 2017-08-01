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
    /// Task
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Incomplete for "incomplete"
            /// </summary>
            [EnumMember(Value = "incomplete")]
            Incomplete
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Incomplete for "incomplete"
            /// </summary>
            [EnumMember(Value = "incomplete")]
            Incomplete,
            
            /// <summary>
            /// Enum Alerts for "alerts"
            /// </summary>
            [EnumMember(Value = "alerts")]
            Alerts,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
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
            /// Enum Reorder for "reorder"
            /// </summary>
            [EnumMember(Value = "reorder")]
            Reorder
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
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Alerts">Alerts.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Descriptions">Descriptions.</param>
        /// <param name="Label">Label.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="CheckIn">CheckIn.</param>
        /// <param name="CheckOut">CheckOut.</param>
        /// <param name="ClosingNotes">ClosingNotes.</param>
        /// <param name="Attachments">Attachments.</param>
        /// <param name="CustomField">CustomField.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Signature">Signature.</param>
        /// <param name="Shipment">Shipment.</param>
        /// <param name="Eta">Eta.</param>
        public Task(int? Id = default(int?), List<TaskAlert> Alerts = default(List<TaskAlert>), string Description = default(string), TaskDescriptions Descriptions = default(TaskDescriptions), string Label = default(string), TaskGroup Group = default(TaskGroup), StatusEnum? Status = default(StatusEnum?), List<ActionsEnum> Actions = default(List<ActionsEnum>), TaskType Type = default(TaskType), DateTime? Created = default(DateTime?), User Author = default(User), DateTime? Completed = default(DateTime?), TimeLog CheckIn = default(TimeLog), TimeLog CheckOut = default(TimeLog), string ClosingNotes = default(string), AttachmentFolder Attachments = default(AttachmentFolder), CustomField CustomField = default(CustomField), string Phone = default(string), string Email = default(string), Signature Signature = default(Signature), Shipment Shipment = default(Shipment), ETA Eta = default(ETA))
        {
            this.Id = Id;
            this.Alerts = Alerts;
            this.Description = Description;
            this.Descriptions = Descriptions;
            this.Label = Label;
            this.Group = Group;
            this.Status = Status;
            this.Actions = Actions;
            this.Type = Type;
            this.Created = Created;
            this.Author = Author;
            this.Completed = Completed;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.ClosingNotes = ClosingNotes;
            this.Attachments = Attachments;
            this.CustomField = CustomField;
            this.Phone = Phone;
            this.Email = Email;
            this.Signature = Signature;
            this.Shipment = Shipment;
            this.Eta = Eta;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<TaskAlert> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Descriptions
        /// </summary>
        [DataMember(Name="descriptions", EmitDefaultValue=false)]
        public TaskDescriptions Descriptions { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public TaskGroup Group { get; set; }



        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TaskType Type { get; set; }

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
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public DateTime? Completed { get; set; }

        /// <summary>
        /// Gets or Sets CheckIn
        /// </summary>
        [DataMember(Name="check_in", EmitDefaultValue=false)]
        public TimeLog CheckIn { get; set; }

        /// <summary>
        /// Gets or Sets CheckOut
        /// </summary>
        [DataMember(Name="check_out", EmitDefaultValue=false)]
        public TimeLog CheckOut { get; set; }

        /// <summary>
        /// Gets or Sets ClosingNotes
        /// </summary>
        [DataMember(Name="closing_notes", EmitDefaultValue=false)]
        public string ClosingNotes { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public AttachmentFolder Attachments { get; set; }

        /// <summary>
        /// Gets or Sets CustomField
        /// </summary>
        [DataMember(Name="custom_field", EmitDefaultValue=false)]
        public CustomField CustomField { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public Signature Signature { get; set; }

        /// <summary>
        /// Gets or Sets Shipment
        /// </summary>
        [DataMember(Name="shipment", EmitDefaultValue=false)]
        public Shipment Shipment { get; set; }

        /// <summary>
        /// Gets or Sets Eta
        /// </summary>
        [DataMember(Name="eta", EmitDefaultValue=false)]
        public ETA Eta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CheckIn: ").Append(CheckIn).Append("\n");
            sb.Append("  CheckOut: ").Append(CheckOut).Append("\n");
            sb.Append("  ClosingNotes: ").Append(ClosingNotes).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Shipment: ").Append(Shipment).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
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
            return this.Equals(obj as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="other">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task other)
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
                    this.Alerts == other.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(other.Alerts)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Descriptions == other.Descriptions ||
                    this.Descriptions != null &&
                    this.Descriptions.Equals(other.Descriptions)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
                ) && 
                (
                    this.CheckIn == other.CheckIn ||
                    this.CheckIn != null &&
                    this.CheckIn.Equals(other.CheckIn)
                ) && 
                (
                    this.CheckOut == other.CheckOut ||
                    this.CheckOut != null &&
                    this.CheckOut.Equals(other.CheckOut)
                ) && 
                (
                    this.ClosingNotes == other.ClosingNotes ||
                    this.ClosingNotes != null &&
                    this.ClosingNotes.Equals(other.ClosingNotes)
                ) && 
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.Equals(other.Attachments)
                ) && 
                (
                    this.CustomField == other.CustomField ||
                    this.CustomField != null &&
                    this.CustomField.Equals(other.CustomField)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Signature == other.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(other.Signature)
                ) && 
                (
                    this.Shipment == other.Shipment ||
                    this.Shipment != null &&
                    this.Shipment.Equals(other.Shipment)
                ) && 
                (
                    this.Eta == other.Eta ||
                    this.Eta != null &&
                    this.Eta.Equals(other.Eta)
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
                if (this.Alerts != null)
                    hash = hash * 59 + this.Alerts.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Descriptions != null)
                    hash = hash * 59 + this.Descriptions.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                if (this.CheckIn != null)
                    hash = hash * 59 + this.CheckIn.GetHashCode();
                if (this.CheckOut != null)
                    hash = hash * 59 + this.CheckOut.GetHashCode();
                if (this.ClosingNotes != null)
                    hash = hash * 59 + this.ClosingNotes.GetHashCode();
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                if (this.CustomField != null)
                    hash = hash * 59 + this.CustomField.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Signature != null)
                    hash = hash * 59 + this.Signature.GetHashCode();
                if (this.Shipment != null)
                    hash = hash * 59 + this.Shipment.GetHashCode();
                if (this.Eta != null)
                    hash = hash * 59 + this.Eta.GetHashCode();
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
