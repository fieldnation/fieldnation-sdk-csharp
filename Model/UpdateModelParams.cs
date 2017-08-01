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
    /// UpdateModelParams
    /// </summary>
    [DataContract]
    public partial class UpdateModelParams :  IEquatable<UpdateModelParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelParams" /> class.
        /// </summary>
        /// <param name="Model">Model.</param>
        /// <param name="UpdateScheduleByWorkOrder">UpdateScheduleByWorkOrder.</param>
        public UpdateModelParams(Object Model = default(Object), EventUpdateScheduleByWorkOrder UpdateScheduleByWorkOrder = default(EventUpdateScheduleByWorkOrder))
        {
            this.Model = Model;
            this.UpdateScheduleByWorkOrder = UpdateScheduleByWorkOrder;
        }
        
        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public Object Model { get; set; }

        /// <summary>
        /// Gets or Sets UpdateScheduleByWorkOrder
        /// </summary>
        [DataMember(Name="updateScheduleByWorkOrder", EmitDefaultValue=false)]
        public EventUpdateScheduleByWorkOrder UpdateScheduleByWorkOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateModelParams {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  UpdateScheduleByWorkOrder: ").Append(UpdateScheduleByWorkOrder).Append("\n");
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
            return this.Equals(obj as UpdateModelParams);
        }

        /// <summary>
        /// Returns true if UpdateModelParams instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateModelParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateModelParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.UpdateScheduleByWorkOrder == other.UpdateScheduleByWorkOrder ||
                    this.UpdateScheduleByWorkOrder != null &&
                    this.UpdateScheduleByWorkOrder.Equals(other.UpdateScheduleByWorkOrder)
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
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.UpdateScheduleByWorkOrder != null)
                    hash = hash * 59 + this.UpdateScheduleByWorkOrder.GetHashCode();
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
