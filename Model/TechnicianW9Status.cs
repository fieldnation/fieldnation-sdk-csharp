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
    /// TechnicianW9Status
    /// </summary>
    [DataContract]
    public partial class TechnicianW9Status :  IEquatable<TechnicianW9Status>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicianW9Status" /> class.
        /// </summary>
        /// <param name="StatusName">StatusName.</param>
        /// <param name="TechnicianW9StatusId">TechnicianW9StatusId.</param>
        public TechnicianW9Status(string StatusName = default(string), int? TechnicianW9StatusId = default(int?))
        {
            this.StatusName = StatusName;
            this.TechnicianW9StatusId = TechnicianW9StatusId;
        }
        
        /// <summary>
        /// Gets or Sets StatusName
        /// </summary>
        [DataMember(Name="status_name", EmitDefaultValue=false)]
        public string StatusName { get; set; }

        /// <summary>
        /// Gets or Sets TechnicianW9StatusId
        /// </summary>
        [DataMember(Name="technician_w9_status_id", EmitDefaultValue=false)]
        public int? TechnicianW9StatusId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TechnicianW9Status {\n");
            sb.Append("  StatusName: ").Append(StatusName).Append("\n");
            sb.Append("  TechnicianW9StatusId: ").Append(TechnicianW9StatusId).Append("\n");
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
            return this.Equals(obj as TechnicianW9Status);
        }

        /// <summary>
        /// Returns true if TechnicianW9Status instances are equal
        /// </summary>
        /// <param name="other">Instance of TechnicianW9Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TechnicianW9Status other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StatusName == other.StatusName ||
                    this.StatusName != null &&
                    this.StatusName.Equals(other.StatusName)
                ) && 
                (
                    this.TechnicianW9StatusId == other.TechnicianW9StatusId ||
                    this.TechnicianW9StatusId != null &&
                    this.TechnicianW9StatusId.Equals(other.TechnicianW9StatusId)
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
                if (this.StatusName != null)
                    hash = hash * 59 + this.StatusName.GetHashCode();
                if (this.TechnicianW9StatusId != null)
                    hash = hash * 59 + this.TechnicianW9StatusId.GetHashCode();
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
