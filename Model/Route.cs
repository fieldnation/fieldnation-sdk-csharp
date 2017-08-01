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
    /// Route
    /// </summary>
    [DataContract]
    public partial class Route :  IEquatable<Route>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Deny for "deny"
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny,
            
            /// <summary>
            /// Enum Accept for "accept"
            /// </summary>
            [EnumMember(Value = "accept")]
            Accept
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Declined">Declined.</param>
        /// <param name="Assigned">Assigned.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Technician">Technician.</param>
        /// <param name="Routed">Routed.</param>
        /// <param name="Actions">Actions.</param>
        public Route(int? Id = default(int?), bool? Declined = default(bool?), bool? Assigned = default(bool?), DateTime? Created = default(DateTime?), User Technician = default(User), User Routed = default(User), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.Id = Id;
            this.Declined = Declined;
            this.Assigned = Assigned;
            this.Created = Created;
            this.Technician = Technician;
            this.Routed = Routed;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Declined
        /// </summary>
        [DataMember(Name="declined", EmitDefaultValue=false)]
        public bool? Declined { get; set; }

        /// <summary>
        /// Gets or Sets Assigned
        /// </summary>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public bool? Assigned { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Technician
        /// </summary>
        [DataMember(Name="technician", EmitDefaultValue=false)]
        public User Technician { get; set; }

        /// <summary>
        /// Gets or Sets Routed
        /// </summary>
        [DataMember(Name="routed", EmitDefaultValue=false)]
        public User Routed { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Route {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Declined: ").Append(Declined).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Technician: ").Append(Technician).Append("\n");
            sb.Append("  Routed: ").Append(Routed).Append("\n");
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
            return this.Equals(obj as Route);
        }

        /// <summary>
        /// Returns true if Route instances are equal
        /// </summary>
        /// <param name="other">Instance of Route to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Route other)
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
                    this.Declined == other.Declined ||
                    this.Declined != null &&
                    this.Declined.Equals(other.Declined)
                ) && 
                (
                    this.Assigned == other.Assigned ||
                    this.Assigned != null &&
                    this.Assigned.Equals(other.Assigned)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Technician == other.Technician ||
                    this.Technician != null &&
                    this.Technician.Equals(other.Technician)
                ) && 
                (
                    this.Routed == other.Routed ||
                    this.Routed != null &&
                    this.Routed.Equals(other.Routed)
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
                if (this.Declined != null)
                    hash = hash * 59 + this.Declined.GetHashCode();
                if (this.Assigned != null)
                    hash = hash * 59 + this.Assigned.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Technician != null)
                    hash = hash * 59 + this.Technician.GetHashCode();
                if (this.Routed != null)
                    hash = hash * 59 + this.Routed.GetHashCode();
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
