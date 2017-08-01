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
    /// InlineResponse2003
    /// </summary>
    [DataContract]
    public partial class InlineResponse2003 :  IEquatable<InlineResponse2003>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="ContactMethod">ContactMethod.</param>
        /// <param name="MessageId">MessageId.</param>
        /// <param name="EmailTemplate">EmailTemplate.</param>
        /// <param name="StaffTemplate">StaffTemplate.</param>
        /// <param name="ContactedAt">ContactedAt.</param>
        /// <param name="Staff">Staff.</param>
        public InlineResponse2003(int? UserId = default(int?), string ContactMethod = default(string), string MessageId = default(string), int? EmailTemplate = default(int?), int? StaffTemplate = default(int?), int? ContactedAt = default(int?), StaffrecruitmentsendcommunicationsworkOrderIdStaff Staff = default(StaffrecruitmentsendcommunicationsworkOrderIdStaff))
        {
            this.UserId = UserId;
            this.ContactMethod = ContactMethod;
            this.MessageId = MessageId;
            this.EmailTemplate = EmailTemplate;
            this.StaffTemplate = StaffTemplate;
            this.ContactedAt = ContactedAt;
            this.Staff = Staff;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets ContactMethod
        /// </summary>
        [DataMember(Name="contact_method", EmitDefaultValue=false)]
        public string ContactMethod { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets EmailTemplate
        /// </summary>
        [DataMember(Name="email_template", EmitDefaultValue=false)]
        public int? EmailTemplate { get; set; }

        /// <summary>
        /// Gets or Sets StaffTemplate
        /// </summary>
        [DataMember(Name="staff_template", EmitDefaultValue=false)]
        public int? StaffTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ContactedAt
        /// </summary>
        [DataMember(Name="contacted_at", EmitDefaultValue=false)]
        public int? ContactedAt { get; set; }

        /// <summary>
        /// Gets or Sets Staff
        /// </summary>
        [DataMember(Name="staff", EmitDefaultValue=false)]
        public StaffrecruitmentsendcommunicationsworkOrderIdStaff Staff { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003 {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  EmailTemplate: ").Append(EmailTemplate).Append("\n");
            sb.Append("  StaffTemplate: ").Append(StaffTemplate).Append("\n");
            sb.Append("  ContactedAt: ").Append(ContactedAt).Append("\n");
            sb.Append("  Staff: ").Append(Staff).Append("\n");
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
            return this.Equals(obj as InlineResponse2003);
        }

        /// <summary>
        /// Returns true if InlineResponse2003 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2003 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003 other)
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
                    this.ContactMethod == other.ContactMethod ||
                    this.ContactMethod != null &&
                    this.ContactMethod.Equals(other.ContactMethod)
                ) && 
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) && 
                (
                    this.EmailTemplate == other.EmailTemplate ||
                    this.EmailTemplate != null &&
                    this.EmailTemplate.Equals(other.EmailTemplate)
                ) && 
                (
                    this.StaffTemplate == other.StaffTemplate ||
                    this.StaffTemplate != null &&
                    this.StaffTemplate.Equals(other.StaffTemplate)
                ) && 
                (
                    this.ContactedAt == other.ContactedAt ||
                    this.ContactedAt != null &&
                    this.ContactedAt.Equals(other.ContactedAt)
                ) && 
                (
                    this.Staff == other.Staff ||
                    this.Staff != null &&
                    this.Staff.Equals(other.Staff)
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
                if (this.ContactMethod != null)
                    hash = hash * 59 + this.ContactMethod.GetHashCode();
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.EmailTemplate != null)
                    hash = hash * 59 + this.EmailTemplate.GetHashCode();
                if (this.StaffTemplate != null)
                    hash = hash * 59 + this.StaffTemplate.GetHashCode();
                if (this.ContactedAt != null)
                    hash = hash * 59 + this.ContactedAt.GetHashCode();
                if (this.Staff != null)
                    hash = hash * 59 + this.Staff.GetHashCode();
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
