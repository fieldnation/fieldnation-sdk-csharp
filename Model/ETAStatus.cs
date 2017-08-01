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
    /// ETAStatus
    /// </summary>
    [DataContract]
    public partial class ETAStatus :  IEquatable<ETAStatus>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum Unconfirmed for "unconfirmed"
            /// </summary>
            [EnumMember(Value = "unconfirmed")]
            Unconfirmed,
            
            /// <summary>
            /// Enum Confirmed for "confirmed"
            /// </summary>
            [EnumMember(Value = "confirmed")]
            Confirmed,
            
            /// <summary>
            /// Enum Set for "set"
            /// </summary>
            [EnumMember(Value = "set")]
            Set,
            
            /// <summary>
            /// Enum Readytogo for "readytogo"
            /// </summary>
            [EnumMember(Value = "readytogo")]
            Readytogo,
            
            /// <summary>
            /// Enum Onmyway for "onmyway"
            /// </summary>
            [EnumMember(Value = "onmyway")]
            Onmyway
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ETAStatus" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Updated">Updated.</param>
        public ETAStatus(NameEnum? Name = default(NameEnum?), DateTime? Updated = default(DateTime?))
        {
            this.Name = Name;
            this.Updated = Updated;
        }
        

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETAStatus {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(obj as ETAStatus);
        }

        /// <summary>
        /// Returns true if ETAStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ETAStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETAStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
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
