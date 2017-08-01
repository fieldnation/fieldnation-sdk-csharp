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
    /// Body
    /// </summary>
    [DataContract]
    public partial class Body :  IEquatable<Body>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Body() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="Users">Users (required).</param>
        /// <param name="EmailTemplate">EmailTemplate.</param>
        /// <param name="RobocallTemplate">RobocallTemplate.</param>
        public Body(List<StaffrecruitmentsendcommunicationsworkOrderIdUsers> Users = default(List<StaffrecruitmentsendcommunicationsworkOrderIdUsers>), int? EmailTemplate = default(int?), int? RobocallTemplate = default(int?))
        {
            // to ensure "Users" is required (not null)
            if (Users == null)
            {
                throw new InvalidDataException("Users is a required property for Body and cannot be null");
            }
            else
            {
                this.Users = Users;
            }
            this.EmailTemplate = EmailTemplate;
            this.RobocallTemplate = RobocallTemplate;
        }
        
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<StaffrecruitmentsendcommunicationsworkOrderIdUsers> Users { get; set; }

        /// <summary>
        /// Gets or Sets EmailTemplate
        /// </summary>
        [DataMember(Name="email_template", EmitDefaultValue=false)]
        public int? EmailTemplate { get; set; }

        /// <summary>
        /// Gets or Sets RobocallTemplate
        /// </summary>
        [DataMember(Name="robocall_template", EmitDefaultValue=false)]
        public int? RobocallTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  EmailTemplate: ").Append(EmailTemplate).Append("\n");
            sb.Append("  RobocallTemplate: ").Append(RobocallTemplate).Append("\n");
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
            return this.Equals(obj as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="other">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) && 
                (
                    this.EmailTemplate == other.EmailTemplate ||
                    this.EmailTemplate != null &&
                    this.EmailTemplate.Equals(other.EmailTemplate)
                ) && 
                (
                    this.RobocallTemplate == other.RobocallTemplate ||
                    this.RobocallTemplate != null &&
                    this.RobocallTemplate.Equals(other.RobocallTemplate)
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
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.EmailTemplate != null)
                    hash = hash * 59 + this.EmailTemplate.GetHashCode();
                if (this.RobocallTemplate != null)
                    hash = hash * 59 + this.RobocallTemplate.GetHashCode();
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
