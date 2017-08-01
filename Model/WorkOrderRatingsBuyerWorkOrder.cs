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
    /// WorkOrderRatingsBuyerWorkOrder
    /// </summary>
    [DataContract]
    public partial class WorkOrderRatingsBuyerWorkOrder :  IEquatable<WorkOrderRatingsBuyerWorkOrder>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormEnum
        {
            
            /// <summary>
            /// Enum Old for "old"
            /// </summary>
            [EnumMember(Value = "old")]
            Old,
            
            /// <summary>
            /// Enum New for "new"
            /// </summary>
            [EnumMember(Value = "new")]
            New
        }

        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public FormEnum? Form { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRatingsBuyerWorkOrder" /> class.
        /// </summary>
        /// <param name="Created">Created.</param>
        /// <param name="Stars">Stars.</param>
        /// <param name="Recommend">Recommend.</param>
        /// <param name="Comment">Comment.</param>
        /// <param name="Hidden">Hidden.</param>
        /// <param name="Flagged">Flagged.</param>
        /// <param name="Form">Form.</param>
        /// <param name="Categories">Categories.</param>
        public WorkOrderRatingsBuyerWorkOrder(DateTime? Created = default(DateTime?), int? Stars = default(int?), bool? Recommend = default(bool?), string Comment = default(string), bool? Hidden = default(bool?), bool? Flagged = default(bool?), FormEnum? Form = default(FormEnum?), List<WorkOrderRatingsBuyerWorkOrderCategories> Categories = default(List<WorkOrderRatingsBuyerWorkOrderCategories>))
        {
            this.Created = Created;
            this.Stars = Stars;
            this.Recommend = Recommend;
            this.Comment = Comment;
            this.Hidden = Hidden;
            this.Flagged = Flagged;
            this.Form = Form;
            this.Categories = Categories;
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
        /// Gets or Sets Recommend
        /// </summary>
        [DataMember(Name="recommend", EmitDefaultValue=false)]
        public bool? Recommend { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Flagged
        /// </summary>
        [DataMember(Name="flagged", EmitDefaultValue=false)]
        public bool? Flagged { get; set; }


        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<WorkOrderRatingsBuyerWorkOrderCategories> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderRatingsBuyerWorkOrder {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Recommend: ").Append(Recommend).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Flagged: ").Append(Flagged).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(obj as WorkOrderRatingsBuyerWorkOrder);
        }

        /// <summary>
        /// Returns true if WorkOrderRatingsBuyerWorkOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderRatingsBuyerWorkOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderRatingsBuyerWorkOrder other)
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
                    this.Recommend == other.Recommend ||
                    this.Recommend != null &&
                    this.Recommend.Equals(other.Recommend)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Hidden == other.Hidden ||
                    this.Hidden != null &&
                    this.Hidden.Equals(other.Hidden)
                ) && 
                (
                    this.Flagged == other.Flagged ||
                    this.Flagged != null &&
                    this.Flagged.Equals(other.Flagged)
                ) && 
                (
                    this.Form == other.Form ||
                    this.Form != null &&
                    this.Form.Equals(other.Form)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
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
                if (this.Recommend != null)
                    hash = hash * 59 + this.Recommend.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Hidden != null)
                    hash = hash * 59 + this.Hidden.GetHashCode();
                if (this.Flagged != null)
                    hash = hash * 59 + this.Flagged.GetHashCode();
                if (this.Form != null)
                    hash = hash * 59 + this.Form.GetHashCode();
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
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
