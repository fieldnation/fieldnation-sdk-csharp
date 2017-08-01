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
    /// Local
    /// </summary>
    [DataContract]
    public partial class Local :  IEquatable<Local>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Local" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="Time">Time.</param>
        public Local(string Date = default(string), string Time = default(string))
        {
            this.Date = Date;
            this.Time = Time;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Local {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(obj as Local);
        }

        /// <summary>
        /// Returns true if Local instances are equal
        /// </summary>
        /// <param name="other">Instance of Local to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Local other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
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
            // Date (string) pattern
            Regex regexDate = new Regex(@"^20[0-9]{2}-[0-9]{2}-[0-9]{2}$", RegexOptions.CultureInvariant);
            if (false == regexDate.Match(this.Date).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Date, must match a pattern of " + regexDate, new [] { "Date" });
            }

            // Time (string) pattern
            Regex regexTime = new Regex(@"^[0-9]{2}:[0-9]{2}$", RegexOptions.CultureInvariant);
            if (false == regexTime.Match(this.Time).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Time, must match a pattern of " + regexTime, new [] { "Time" });
            }

            yield break;
        }
    }

}
