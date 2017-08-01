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
    /// Problem
    /// </summary>
    [DataContract]
    public partial class Problem :  IEquatable<Problem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactEnum
        {
            
            /// <summary>
            /// Enum Support for "support"
            /// </summary>
            [EnumMember(Value = "support")]
            Support,
            
            /// <summary>
            /// Enum Buyer for "buyer"
            /// </summary>
            [EnumMember(Value = "buyer")]
            Buyer,
            
            /// <summary>
            /// Enum Provider for "provider"
            /// </summary>
            [EnumMember(Value = "provider")]
            Provider,
            
            /// <summary>
            /// Enum All for "all"
            /// </summary>
            [EnumMember(Value = "all")]
            All
        }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactEnum? Contact { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Problem" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="Contact">Contact.</param>
        /// <param name="Watchers">Watchers.</param>
        /// <param name="Escalate">Escalate.</param>
        /// <param name="Resolution">Resolution.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Message">Message.</param>
        public Problem(int? Id = default(int?), ProblemType Type = default(ProblemType), string Comments = default(string), ContactEnum? Contact = default(ContactEnum?), List<int?> Watchers = default(List<int?>), bool? Escalate = default(bool?), ProblemResolution Resolution = default(ProblemResolution), User Author = default(User), DateTime? Created = default(DateTime?), ShipmentTask Message = default(ShipmentTask))
        {
            this.Id = Id;
            this.Type = Type;
            this.Comments = Comments;
            this.Contact = Contact;
            this.Watchers = Watchers;
            this.Escalate = Escalate;
            this.Resolution = Resolution;
            this.Author = Author;
            this.Created = Created;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ProblemType Type { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }


        /// <summary>
        /// Gets or Sets Watchers
        /// </summary>
        [DataMember(Name="watchers", EmitDefaultValue=false)]
        public List<int?> Watchers { get; set; }

        /// <summary>
        /// Gets or Sets Escalate
        /// </summary>
        [DataMember(Name="escalate", EmitDefaultValue=false)]
        public bool? Escalate { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public ProblemResolution Resolution { get; set; }

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
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public ShipmentTask Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Problem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Watchers: ").Append(Watchers).Append("\n");
            sb.Append("  Escalate: ").Append(Escalate).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as Problem);
        }

        /// <summary>
        /// Returns true if Problem instances are equal
        /// </summary>
        /// <param name="other">Instance of Problem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Problem other)
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
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Watchers == other.Watchers ||
                    this.Watchers != null &&
                    this.Watchers.SequenceEqual(other.Watchers)
                ) && 
                (
                    this.Escalate == other.Escalate ||
                    this.Escalate != null &&
                    this.Escalate.Equals(other.Escalate)
                ) && 
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
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
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.Watchers != null)
                    hash = hash * 59 + this.Watchers.GetHashCode();
                if (this.Escalate != null)
                    hash = hash * 59 + this.Escalate.GetHashCode();
                if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
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
