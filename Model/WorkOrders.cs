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
    /// WorkOrders
    /// </summary>
    [DataContract]
    public partial class WorkOrders :  IEquatable<WorkOrders>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Feedback for "feedback"
            /// </summary>
            [EnumMember(Value = "feedback")]
            Feedback,
            
            /// <summary>
            /// Enum Paymentlink for "payment_link"
            /// </summary>
            [EnumMember(Value = "payment_link")]
            Paymentlink,
            
            /// <summary>
            /// Enum Addtypeofwork for "add_type_of_work"
            /// </summary>
            [EnumMember(Value = "add_type_of_work")]
            Addtypeofwork,
            
            /// <summary>
            /// Enum Remind for "remind"
            /// </summary>
            [EnumMember(Value = "remind")]
            Remind,
            
            /// <summary>
            /// Enum Create for "create"
            /// </summary>
            [EnumMember(Value = "create")]
            Create,
            
            /// <summary>
            /// Enum Import for "import"
            /// </summary>
            [EnumMember(Value = "import")]
            Import,
            
            /// <summary>
            /// Enum Highlightproblems for "highlight_problems"
            /// </summary>
            [EnumMember(Value = "highlight_problems")]
            Highlightproblems,
            
            /// <summary>
            /// Enum Publishstats for "publish_stats"
            /// </summary>
            [EnumMember(Value = "publish_stats")]
            Publishstats,
            
            /// <summary>
            /// Enum Advanceddatefiltering for "advanced_date_filtering"
            /// </summary>
            [EnumMember(Value = "advanced_date_filtering")]
            Advanceddatefiltering,
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Publish for "publish"
            /// </summary>
            [EnumMember(Value = "publish")]
            Publish,
            
            /// <summary>
            /// Enum Revert for "revert"
            /// </summary>
            [EnumMember(Value = "revert")]
            Revert,
            
            /// <summary>
            /// Enum Cancel for "cancel"
            /// </summary>
            [EnumMember(Value = "cancel")]
            Cancel,
            
            /// <summary>
            /// Enum Bundle for "bundle"
            /// </summary>
            [EnumMember(Value = "bundle")]
            Bundle,
            
            /// <summary>
            /// Enum Unbundle for "unbundle"
            /// </summary>
            [EnumMember(Value = "unbundle")]
            Unbundle,
            
            /// <summary>
            /// Enum Dispatch for "dispatch"
            /// </summary>
            [EnumMember(Value = "dispatch")]
            Dispatch,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message,
            
            /// <summary>
            /// Enum Hold for "hold"
            /// </summary>
            [EnumMember(Value = "hold")]
            Hold,
            
            /// <summary>
            /// Enum Downloadattachments for "download_attachments"
            /// </summary>
            [EnumMember(Value = "download_attachments")]
            Downloadattachments,
            
            /// <summary>
            /// Enum Approve for "approve"
            /// </summary>
            [EnumMember(Value = "approve")]
            Approve,
            
            /// <summary>
            /// Enum Autoassign for "auto_assign"
            /// </summary>
            [EnumMember(Value = "auto_assign")]
            Autoassign,
            
            /// <summary>
            /// Enum Locationfiltering for "location_filtering"
            /// </summary>
            [EnumMember(Value = "location_filtering")]
            Locationfiltering
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrders" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Results">Results.</param>
        /// <param name="Actions">Actions.</param>
        public WorkOrders(int? UserId = default(int?), ListEnvelope Metadata = default(ListEnvelope), List<WorkOrder> Results = default(List<WorkOrder>), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.UserId = UserId;
            this.Metadata = Metadata;
            this.Results = Results;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ListEnvelope Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<WorkOrder> Results { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrders {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as WorkOrders);
        }

        /// <summary>
        /// Returns true if WorkOrders instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrders other)
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
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
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
