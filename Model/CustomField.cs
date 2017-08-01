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
    /// CustomField
    /// </summary>
    [DataContract]
    public partial class CustomField :  IEquatable<CustomField>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Text for "text"
            /// </summary>
            [EnumMember(Value = "text")]
            Text,
            
            /// <summary>
            /// Enum Numeric for "numeric"
            /// </summary>
            [EnumMember(Value = "numeric")]
            Numeric,
            
            /// <summary>
            /// Enum Date for "date"
            /// </summary>
            [EnumMember(Value = "date")]
            Date,
            
            /// <summary>
            /// Enum Datetime for "date_time"
            /// </summary>
            [EnumMember(Value = "date_time")]
            Datetime,
            
            /// <summary>
            /// Enum Time for "time"
            /// </summary>
            [EnumMember(Value = "time")]
            Time,
            
            /// <summary>
            /// Enum Predefined for "predefined"
            /// </summary>
            [EnumMember(Value = "predefined")]
            Predefined,
            
            /// <summary>
            /// Enum Phone for "phone"
            /// </summary>
            [EnumMember(Value = "phone")]
            Phone
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum Buyer for "buyer"
            /// </summary>
            [EnumMember(Value = "buyer")]
            Buyer,
            
            /// <summary>
            /// Enum Assignedprovider for "assigned_provider"
            /// </summary>
            [EnumMember(Value = "assigned_provider")]
            Assignedprovider
        }


        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagsEnum
        {
            
            /// <summary>
            /// Enum Unique for "unique"
            /// </summary>
            [EnumMember(Value = "unique")]
            Unique,
            
            /// <summary>
            /// Enum Required for "required"
            /// </summary>
            [EnumMember(Value = "required")]
            Required,
            
            /// <summary>
            /// Enum Internalid for "internal_id"
            /// </summary>
            [EnumMember(Value = "internal_id")]
            Internalid,
            
            /// <summary>
            /// Enum Requiredduringcheckin for "required_during_checkin"
            /// </summary>
            [EnumMember(Value = "required_during_checkin")]
            Requiredduringcheckin,
            
            /// <summary>
            /// Enum Includedinalerts for "included_in_alerts"
            /// </summary>
            [EnumMember(Value = "included_in_alerts")]
            Includedinalerts,
            
            /// <summary>
            /// Enum Showninheader for "shown_in_header"
            /// </summary>
            [EnumMember(Value = "shown_in_header")]
            Showninheader,
            
            /// <summary>
            /// Enum Seenbyprovider for "seen_by_provider"
            /// </summary>
            [EnumMember(Value = "seen_by_provider")]
            Seenbyprovider,
            
            /// <summary>
            /// Enum Seenbyclients for "seen_by_clients"
            /// </summary>
            [EnumMember(Value = "seen_by_clients")]
            Seenbyclients,
            
            /// <summary>
            /// Enum Visibletoclients for "visible_to_clients"
            /// </summary>
            [EnumMember(Value = "visible_to_clients")]
            Visibletoclients,
            
            /// <summary>
            /// Enum Clientrequestrequired for "client_request_required"
            /// </summary>
            [EnumMember(Value = "client_request_required")]
            Clientrequestrequired,
            
            /// <summary>
            /// Enum Clientrequestusefor for "client_request_use_for"
            /// </summary>
            [EnumMember(Value = "client_request_use_for")]
            Clientrequestusefor
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
            Edit
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name="flags", EmitDefaultValue=false)]
        public List<FlagsEnum> Flags { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Tip">Tip.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Options">Options.</param>
        /// <param name="Role">Role.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Dependency">Dependency.</param>
        /// <param name="Flags">Flags.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="Category">Category.</param>
        public CustomField(int? Id = default(int?), string Name = default(string), string Tip = default(string), TypeEnum? Type = default(TypeEnum?), List<string> Options = default(List<string>), RoleEnum? Role = default(RoleEnum?), string Value = default(string), CustomFieldDependency Dependency = default(CustomFieldDependency), List<FlagsEnum> Flags = default(List<FlagsEnum>), List<ActionsEnum> Actions = default(List<ActionsEnum>), string Category = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Tip = Tip;
            this.Type = Type;
            this.Options = Options;
            this.Role = Role;
            this.Value = Value;
            this.Dependency = Dependency;
            this.Flags = Flags;
            this.Actions = Actions;
            this.Category = Category;
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
        /// Gets or Sets Tip
        /// </summary>
        [DataMember(Name="tip", EmitDefaultValue=false)]
        public string Tip { get; set; }


        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Dependency
        /// </summary>
        [DataMember(Name="dependency", EmitDefaultValue=false)]
        public CustomFieldDependency Dependency { get; set; }



        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomField {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Dependency: ").Append(Dependency).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as CustomField);
        }

        /// <summary>
        /// Returns true if CustomField instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomField other)
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
                    this.Tip == other.Tip ||
                    this.Tip != null &&
                    this.Tip.Equals(other.Tip)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Dependency == other.Dependency ||
                    this.Dependency != null &&
                    this.Dependency.Equals(other.Dependency)
                ) && 
                (
                    this.Flags == other.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(other.Flags)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Tip != null)
                    hash = hash * 59 + this.Tip.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Dependency != null)
                    hash = hash * 59 + this.Dependency.GetHashCode();
                if (this.Flags != null)
                    hash = hash * 59 + this.Flags.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
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
