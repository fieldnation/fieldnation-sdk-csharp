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
    /// Swap
    /// </summary>
    [DataContract]
    public partial class Swap :  IEquatable<Swap>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Accept for "accept"
            /// </summary>
            [EnumMember(Value = "accept")]
            Accept,
            
            /// <summary>
            /// Enum Deny for "deny"
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Denied for "denied"
            /// </summary>
            [EnumMember(Value = "denied")]
            Denied,
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Swap" /> class.
        /// </summary>
        /// <param name="Actions">Actions.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Status">Status.</param>
        /// <param name="From">From.</param>
        /// <param name="To">To.</param>
        /// <param name="Requestor">Requestor.</param>
        /// <param name="Actor">Actor.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Accepted">Accepted.</param>
        /// <param name="Denied">Denied.</param>
        public Swap(List<ActionsEnum> Actions = default(List<ActionsEnum>), int? Id = default(int?), string Description = default(string), StatusEnum? Status = default(StatusEnum?), User From = default(User), User To = default(User), User Requestor = default(User), User Actor = default(User), DateTime? Created = default(DateTime?), DateTime? Accepted = default(DateTime?), DateTime? Denied = default(DateTime?))
        {
            this.Actions = Actions;
            this.Id = Id;
            this.Description = Description;
            this.Status = Status;
            this.From = From;
            this.To = To;
            this.Requestor = Requestor;
            this.Actor = Actor;
            this.Created = Created;
            this.Accepted = Accepted;
            this.Denied = Denied;
        }
        

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public User From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public User To { get; set; }

        /// <summary>
        /// Gets or Sets Requestor
        /// </summary>
        [DataMember(Name="requestor", EmitDefaultValue=false)]
        public User Requestor { get; set; }

        /// <summary>
        /// Gets or Sets Actor
        /// </summary>
        [DataMember(Name="actor", EmitDefaultValue=false)]
        public User Actor { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Accepted
        /// </summary>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public DateTime? Accepted { get; set; }

        /// <summary>
        /// Gets or Sets Denied
        /// </summary>
        [DataMember(Name="denied", EmitDefaultValue=false)]
        public DateTime? Denied { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Swap {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Requestor: ").Append(Requestor).Append("\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Denied: ").Append(Denied).Append("\n");
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
            return this.Equals(obj as Swap);
        }

        /// <summary>
        /// Returns true if Swap instances are equal
        /// </summary>
        /// <param name="other">Instance of Swap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Swap other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.Requestor == other.Requestor ||
                    this.Requestor != null &&
                    this.Requestor.Equals(other.Requestor)
                ) && 
                (
                    this.Actor == other.Actor ||
                    this.Actor != null &&
                    this.Actor.Equals(other.Actor)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Accepted == other.Accepted ||
                    this.Accepted != null &&
                    this.Accepted.Equals(other.Accepted)
                ) && 
                (
                    this.Denied == other.Denied ||
                    this.Denied != null &&
                    this.Denied.Equals(other.Denied)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                if (this.Requestor != null)
                    hash = hash * 59 + this.Requestor.GetHashCode();
                if (this.Actor != null)
                    hash = hash * 59 + this.Actor.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Accepted != null)
                    hash = hash * 59 + this.Accepted.GetHashCode();
                if (this.Denied != null)
                    hash = hash * 59 + this.Denied.GetHashCode();
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
