﻿/* 
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
    /// ListEnvelopeTimings
    /// </summary>
    [DataContract]
    public partial class ListEnvelopeTimings :  IEquatable<ListEnvelopeTimings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvelopeTimings" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Time">Time.</param>
        public ListEnvelopeTimings(string Name = default(string), int? Time = default(int?))
        {
            this.Name = Name;
            this.Time = Time;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public int? Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnvelopeTimings {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as ListEnvelopeTimings);
        }

        /// <summary>
        /// Returns true if ListEnvelopeTimings instances are equal
        /// </summary>
        /// <param name="other">Instance of ListEnvelopeTimings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListEnvelopeTimings other)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
            yield break;
        }
    }

}
