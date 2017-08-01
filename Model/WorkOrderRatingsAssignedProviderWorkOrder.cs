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
    /// WorkOrderRatingsAssignedProviderWorkOrder
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsAssignedProviderWorkOrder :  IEquatable<WorkOrderRatingsAssignedProviderWorkOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsAssignedProviderWorkOrder" /> class.
        /// </summary>
        /// <param name="Created">Created.</param>
        /// <param name="Stars">Stars.</param>
        /// <param name="Categories">Categories.</param>
        /// <param name="Comment">Comment.</param>
        public WorkOrderRatingsAssignedProviderWorkOrder(DateTime? Created = default(DateTime?), int? Stars = default(int?), List<WorkOrderRatingsAssignedProviderWorkOrderCategories> Categories = default(List<WorkOrderRatingsAssignedProviderWorkOrderCategories>), WorkOrderRatingsAssignedProviderWorkOrderComment Comment = default(WorkOrderRatingsAssignedProviderWorkOrderComment))
        {
            this.Created = Created;
            this.Stars = Stars;
            this.Categories = Categories;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [DataMember(Name="stars", EmitDefaultValue=false)]
        public int? Stars { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<WorkOrderRatingsAssignedProviderWorkOrderCategories> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public WorkOrderRatingsAssignedProviderWorkOrderComment Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsAssignedProviderWorkOrder {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsAssignedProviderWorkOrder);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsAssignedProviderWorkOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsAssignedProviderWorkOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsAssignedProviderWorkOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Stars == other.Stars ||
                    this.Stars != null &&
                    this.Stars.Equals(other.Stars)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Stars != null)
                    hash = hash * 59 + this.Stars.GetHashCode();
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
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
