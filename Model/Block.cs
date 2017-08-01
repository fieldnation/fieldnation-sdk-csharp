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
    /// Block
    /// </summary>
    [DataContract]
    public partial class Block :  IEquatable<Block>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Add for "add"
            /// </summary>
            [EnumMember(Value = "add")]
            Add,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }


        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypesEnum
        {
            
            /// <summary>
            /// Enum Workorder for "work_order"
            /// </summary>
            [EnumMember(Value = "work_order")]
            Workorder,
            
            /// <summary>
            /// Enum Company for "company"
            /// </summary>
            [EnumMember(Value = "company")]
            Company,
            
            /// <summary>
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum Location for "location"
            /// </summary>
            [EnumMember(Value = "location")]
            Location,
            
            /// <summary>
            /// Enum Project for "project"
            /// </summary>
            [EnumMember(Value = "project")]
            Project,
            
            /// <summary>
            /// Enum Servicecompany for "service_company"
            /// </summary>
            [EnumMember(Value = "service_company")]
            Servicecompany
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<TypesEnum> Types { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        /// <param name="Actions">Actions.</param>
        /// <param name="Blocked">Blocked.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Author">Author.</param>
        /// <param name="ReasonId">ReasonId.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Types">Types.</param>
        public Block(List<ActionsEnum> Actions = default(List<ActionsEnum>), bool? Blocked = default(bool?), DateTime? Created = default(DateTime?), User Author = default(User), int? ReasonId = default(int?), string Reason = default(string), string Category = default(string), List<TypesEnum> Types = default(List<TypesEnum>))
        {
            this.Actions = Actions;
            this.Blocked = Blocked;
            this.Created = Created;
            this.Author = Author;
            this.ReasonId = ReasonId;
            this.Reason = Reason;
            this.Category = Category;
            this.Types = Types;
        }
        

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public bool? Blocked { get; set; }

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
        /// Gets or Sets ReasonId
        /// </summary>
        [DataMember(Name="reason_id", EmitDefaultValue=false)]
        public int? ReasonId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

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
            sb.Append("class Block {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  ReasonId: ").Append(ReasonId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(obj as Block);
        }

        /// <summary>
        /// Returns true if Block instances are equal
        /// </summary>
        /// <param name="other">Instance of Block to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Block other)
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
                    this.Blocked == other.Blocked ||
                    this.Blocked != null &&
                    this.Blocked.Equals(other.Blocked)
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
                    this.ReasonId == other.ReasonId ||
                    this.ReasonId != null &&
                    this.ReasonId.Equals(other.ReasonId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
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
                if (this.Blocked != null)
                    hash = hash * 59 + this.Blocked.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.ReasonId != null)
                    hash = hash * 59 + this.ReasonId.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
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
