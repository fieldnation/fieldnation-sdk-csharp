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
    /// Message
    /// </summary>
    [DataContract]
    public partial class Message :  IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum INTERNAL for "INTERNAL"
            /// </summary>
            [EnumMember(Value = "INTERNAL")]
            INTERNAL,
            
            /// <summary>
            /// Enum ASSIGNEDTECH for "ASSIGNEDTECH"
            /// </summary>
            [EnumMember(Value = "ASSIGNEDTECH")]
            ASSIGNEDTECH,
            
            /// <summary>
            /// Enum REQUESTEDTECHS for "REQUESTEDTECHS"
            /// </summary>
            [EnumMember(Value = "REQUESTEDTECHS")]
            REQUESTEDTECHS,
            
            /// <summary>
            /// Enum SPECIFICTECH for "SPECIFICTECH"
            /// </summary>
            [EnumMember(Value = "SPECIFICTECH")]
            SPECIFICTECH,
            
            /// <summary>
            /// Enum FROMTECH for "FROMTECH"
            /// </summary>
            [EnumMember(Value = "FROMTECH")]
            FROMTECH,
            
            /// <summary>
            /// Enum REPLY for "REPLY"
            /// </summary>
            [EnumMember(Value = "REPLY")]
            REPLY,
            
            /// <summary>
            /// Enum TECHTOMANAGER for "TECHTOMANAGER"
            /// </summary>
            [EnumMember(Value = "TECHTOMANAGER")]
            TECHTOMANAGER,
            
            /// <summary>
            /// Enum ROUTEDTECHS for "ROUTEDTECHS"
            /// </summary>
            [EnumMember(Value = "ROUTEDTECHS")]
            ROUTEDTECHS,
            
            /// <summary>
            /// Enum REPLYTOTHREAD for "REPLYTOTHREAD"
            /// </summary>
            [EnumMember(Value = "REPLYTOTHREAD")]
            REPLYTOTHREAD,
            
            /// <summary>
            /// Enum STAFFNOTE for "STAFF_NOTE"
            /// </summary>
            [EnumMember(Value = "STAFF_NOTE")]
            STAFFNOTE
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="From">From.</param>
        /// <param name="To">To.</param>
        /// <param name="Role">Role.</param>
        /// <param name="MsgId">MsgId.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="Read">Read.</param>
        /// <param name="Created">Created.</param>
        /// <param name="_Message">_Message.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="Replies">Replies.</param>
        public Message(MessageFrom From = default(MessageFrom), MessageTo To = default(MessageTo), string Role = default(string), int? MsgId = default(int?), int? ParentId = default(int?), bool? Read = default(bool?), DateTime? Created = default(DateTime?), string _Message = default(string), TypeEnum? Type = default(TypeEnum?), List<string> Actions = default(List<string>), Messages Replies = default(Messages))
        {
            this.From = From;
            this.To = To;
            this.Role = Role;
            this.MsgId = MsgId;
            this.ParentId = ParentId;
            this.Read = Read;
            this.Created = Created;
            this._Message = _Message;
            this.Type = Type;
            this.Actions = Actions;
            this.Replies = Replies;
        }
        
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public MessageFrom From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public MessageTo To { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets MsgId
        /// </summary>
        [DataMember(Name="msg_id", EmitDefaultValue=false)]
        public int? MsgId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets _Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string _Message { get; set; }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Replies
        /// </summary>
        [DataMember(Name="replies", EmitDefaultValue=false)]
        public Messages Replies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  MsgId: ").Append(MsgId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  _Message: ").Append(_Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Replies: ").Append(Replies).Append("\n");
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
            return this.Equals(obj as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="other">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.MsgId == other.MsgId ||
                    this.MsgId != null &&
                    this.MsgId.Equals(other.MsgId)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this._Message == other._Message ||
                    this._Message != null &&
                    this._Message.Equals(other._Message)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.Replies == other.Replies ||
                    this.Replies != null &&
                    this.Replies.Equals(other.Replies)
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
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.MsgId != null)
                    hash = hash * 59 + this.MsgId.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this._Message != null)
                    hash = hash * 59 + this._Message.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Replies != null)
                    hash = hash * 59 + this.Replies.GetHashCode();
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
