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
    /// StaffrecruitmentsendcommunicationsworkOrderIdUsers
    /// </summary>
    [DataContract]
    public partial class StaffrecruitmentsendcommunicationsworkOrderIdUsers :  IEquatable<StaffrecruitmentsendcommunicationsworkOrderIdUsers>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Internal for "internal"
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffrecruitmentsendcommunicationsworkOrderIdUsers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffrecruitmentsendcommunicationsworkOrderIdUsers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffrecruitmentsendcommunicationsworkOrderIdUsers" /> class.
        /// </summary>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="Type">Type.</param>
        public StaffrecruitmentsendcommunicationsworkOrderIdUsers(int? UserId = default(int?), TypeEnum? Type = default(TypeEnum?))
        {
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for StaffrecruitmentsendcommunicationsworkOrderIdUsers and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffrecruitmentsendcommunicationsworkOrderIdUsers {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as StaffrecruitmentsendcommunicationsworkOrderIdUsers);
        }

        /// <summary>
        /// Returns true if StaffrecruitmentsendcommunicationsworkOrderIdUsers instances are equal
        /// </summary>
        /// <param name="other">Instance of StaffrecruitmentsendcommunicationsworkOrderIdUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffrecruitmentsendcommunicationsworkOrderIdUsers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
