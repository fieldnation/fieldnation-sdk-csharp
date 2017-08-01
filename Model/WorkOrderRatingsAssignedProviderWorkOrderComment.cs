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
    /// WorkOrderRatingsAssignedProviderWorkOrderComment
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsAssignedProviderWorkOrderComment :  IEquatable<WorkOrderRatingsAssignedProviderWorkOrderComment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsAssignedProviderWorkOrderComment" /> class.
        /// </summary>
        /// <param name="Message">Message.</param>
        /// <param name="_Private">_Private.</param>
        public WorkOrderRatingsAssignedProviderWorkOrderComment(string Message = default(string), bool? _Private = default(bool?))
        {
            this.Message = Message;
            this._Private = _Private;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets _Private
        /// </summary>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public bool? _Private { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsAssignedProviderWorkOrderComment {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  _Private: ").Append(_Private).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsAssignedProviderWorkOrderComment);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsAssignedProviderWorkOrderComment instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsAssignedProviderWorkOrderComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsAssignedProviderWorkOrderComment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this._Private == other._Private ||
                    this._Private != null &&
                    this._Private.Equals(other._Private)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this._Private != null)
                    hash = hash * 59 + this._Private.GetHashCode();
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
