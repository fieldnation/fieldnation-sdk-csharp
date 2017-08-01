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
    /// Tag
    /// </summary>
    [DataContract]
    public partial class Tag :  IEquatable<Tag>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypesEnum
        {
            
            /// <summary>
            /// Enum Substatus for "substatus"
            /// </summary>
            [EnumMember(Value = "substatus")]
            Substatus,
            
            /// <summary>
            /// Enum Hold for "hold"
            /// </summary>
            [EnumMember(Value = "hold")]
            Hold,
            
            /// <summary>
            /// Enum Problem for "problem"
            /// </summary>
            [EnumMember(Value = "problem")]
            Problem,
            
            /// <summary>
            /// Enum Showindashboard for "show_in_dashboard"
            /// </summary>
            [EnumMember(Value = "show_in_dashboard")]
            Showindashboard,
            
            /// <summary>
            /// Enum Hidefromprovider for "hide_from_provider"
            /// </summary>
            [EnumMember(Value = "hide_from_provider")]
            Hidefromprovider,
            
            /// <summary>
            /// Enum Customcompany for "custom_company"
            /// </summary>
            [EnumMember(Value = "custom_company")]
            Customcompany,
            
            /// <summary>
            /// Enum Providercanedit for "provider_can_edit"
            /// </summary>
            [EnumMember(Value = "provider_can_edit")]
            Providercanedit
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete,
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit
        }


        /// <summary>
        /// Gets or Sets ValidStatuses
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidStatusesEnum
        {
            
            /// <summary>
            /// Enum Created for "created"
            /// </summary>
            [EnumMember(Value = "created")]
            Created,
            
            /// <summary>
            /// Enum Published for "published"
            /// </summary>
            [EnumMember(Value = "published")]
            Published,
            
            /// <summary>
            /// Enum Routed for "routed"
            /// </summary>
            [EnumMember(Value = "routed")]
            Routed,
            
            /// <summary>
            /// Enum Assigned for "assigned"
            /// </summary>
            [EnumMember(Value = "assigned")]
            Assigned,
            
            /// <summary>
            /// Enum Workdone for "workdone"
            /// </summary>
            [EnumMember(Value = "workdone")]
            Workdone,
            
            /// <summary>
            /// Enum Approved for "approved"
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved,
            
            /// <summary>
            /// Enum Paid for "paid"
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid,
            
            /// <summary>
            /// Enum Canceled for "canceled"
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled
        }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<TypesEnum> Types { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Gets or Sets ValidStatuses
        /// </summary>
        [DataMember(Name="valid_statuses", EmitDefaultValue=false)]
        public List<ValidStatusesEnum> ValidStatuses { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Label">Label.</param>
        /// <param name="HexColor">HexColor.</param>
        /// <param name="Types">Types.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="ValidStatuses">ValidStatuses.</param>
        public Tag(int? Id = default(int?), User Author = default(User), DateTime? Created = default(DateTime?), string Label = default(string), string HexColor = default(string), List<TypesEnum> Types = default(List<TypesEnum>), List<ActionsEnum> Actions = default(List<ActionsEnum>), List<ValidStatusesEnum> ValidStatuses = default(List<ValidStatusesEnum>))
        {
            this.Id = Id;
            this.Author = Author;
            this.Created = Created;
            this.Label = Label;
            this.HexColor = HexColor;
            this.Types = Types;
            this.Actions = Actions;
            this.ValidStatuses = ValidStatuses;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public User Author { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets HexColor
        /// </summary>
        [DataMember(Name="hex_color", EmitDefaultValue=false)]
        public string HexColor { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  ValidStatuses: ").Append(ValidStatuses).Append("\n");
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
            return this.Equals(obj as Tag);
        }

        /// <summary>
        /// Returns true if Tag instances are equal
        /// </summary>
        /// <param name="other">Instance of Tag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tag other)
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
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.HexColor == other.HexColor ||
                    this.HexColor != null &&
                    this.HexColor.Equals(other.HexColor)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.ValidStatuses == other.ValidStatuses ||
                    this.ValidStatuses != null &&
                    this.ValidStatuses.SequenceEqual(other.ValidStatuses)
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
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.HexColor != null)
                    hash = hash * 59 + this.HexColor.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.ValidStatuses != null)
                    hash = hash * 59 + this.ValidStatuses.GetHashCode();
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
