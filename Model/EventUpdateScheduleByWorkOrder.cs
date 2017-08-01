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
    /// EventUpdateScheduleByWorkOrder
    /// </summary>
    [DataContract]
    public partial class EventUpdateScheduleByWorkOrder :  IEquatable<EventUpdateScheduleByWorkOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventUpdateScheduleByWorkOrder" /> class.
        /// </summary>
        /// <param name="Old">Old.</param>
        /// <param name="_New">_New.</param>
        public EventUpdateScheduleByWorkOrder(EventUpdateScheduleByWorkOrderOld Old = default(EventUpdateScheduleByWorkOrderOld), EventUpdateScheduleByWorkOrderOld _New = default(EventUpdateScheduleByWorkOrderOld))
        {
            this.Old = Old;
            this._New = _New;
        }
        
        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name="old", EmitDefaultValue=false)]
        public EventUpdateScheduleByWorkOrderOld Old { get; set; }

        /// <summary>
        /// Gets or Sets _New
        /// </summary>
        [DataMember(Name="new", EmitDefaultValue=false)]
        public EventUpdateScheduleByWorkOrderOld _New { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventUpdateScheduleByWorkOrder {\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
            sb.Append("  _New: ").Append(_New).Append("\n");
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
            return this.Equals(obj as EventUpdateScheduleByWorkOrder);
        }

        /// <summary>
        /// Returns true if EventUpdateScheduleByWorkOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of EventUpdateScheduleByWorkOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventUpdateScheduleByWorkOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Old == other.Old ||
                    this.Old != null &&
                    this.Old.Equals(other.Old)
                ) && 
                (
                    this._New == other._New ||
                    this._New != null &&
                    this._New.Equals(other._New)
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
                if (this.Old != null)
                    hash = hash * 59 + this.Old.GetHashCode();
                if (this._New != null)
                    hash = hash * 59 + this._New.GetHashCode();
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
