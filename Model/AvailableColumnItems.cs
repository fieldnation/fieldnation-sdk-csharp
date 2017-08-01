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
    /// AvailableColumnItems
    /// </summary>
    [DataContract]
    public partial class AvailableColumnItems :  IEquatable<AvailableColumnItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableColumnItems" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Label">Label.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Icon">Icon.</param>
        /// <param name="Selected">Selected.</param>
        /// <param name="CanSort">CanSort.</param>
        /// <param name="SortDir">SortDir.</param>
        public AvailableColumnItems(string Id = default(string), string Label = default(string), string Group = default(string), int? Order = default(int?), string Icon = default(string), bool? Selected = default(bool?), bool? CanSort = default(bool?), string SortDir = default(string))
        {
            this.Id = Id;
            this.Label = Label;
            this.Group = Group;
            this.Order = Order;
            this.Icon = Icon;
            this.Selected = Selected;
            this.CanSort = CanSort;
            this.SortDir = SortDir;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Gets or Sets CanSort
        /// </summary>
        [DataMember(Name="can_sort", EmitDefaultValue=false)]
        public bool? CanSort { get; set; }

        /// <summary>
        /// Gets or Sets SortDir
        /// </summary>
        [DataMember(Name="sort_dir", EmitDefaultValue=false)]
        public string SortDir { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableColumnItems {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  CanSort: ").Append(CanSort).Append("\n");
            sb.Append("  SortDir: ").Append(SortDir).Append("\n");
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
            return this.Equals(obj as AvailableColumnItems);
        }

        /// <summary>
        /// Returns true if AvailableColumnItems instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableColumnItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableColumnItems other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
                ) && 
                (
                    this.CanSort == other.CanSort ||
                    this.CanSort != null &&
                    this.CanSort.Equals(other.CanSort)
                ) && 
                (
                    this.SortDir == other.SortDir ||
                    this.SortDir != null &&
                    this.SortDir.Equals(other.SortDir)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                if (this.Selected != null)
                    hash = hash * 59 + this.Selected.GetHashCode();
                if (this.CanSort != null)
                    hash = hash * 59 + this.CanSort.GetHashCode();
                if (this.SortDir != null)
                    hash = hash * 59 + this.SortDir.GetHashCode();
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
