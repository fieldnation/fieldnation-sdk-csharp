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
    /// ListEnvelope
    /// </summary>
    [DataContract]
    public partial class ListEnvelope :  IEquatable<ListEnvelope>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewEnum
        {
            
            /// <summary>
            /// Enum Map for "map"
            /// </summary>
            [EnumMember(Value = "map")]
            Map,
            
            /// <summary>
            /// Enum List for "list"
            /// </summary>
            [EnumMember(Value = "list")]
            List,
            
            /// <summary>
            /// Enum Schedule for "schedule"
            /// </summary>
            [EnumMember(Value = "schedule")]
            Schedule,
            
            /// <summary>
            /// Enum Model for "model"
            /// </summary>
            [EnumMember(Value = "model")]
            Model,
            
            /// <summary>
            /// Enum Card for "card"
            /// </summary>
            [EnumMember(Value = "card")]
            Card
        }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum Asc for "asc"
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "desc"
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc
        }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public ViewEnum? View { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvelope" /> class.
        /// </summary>
        /// <param name="Total">Total.</param>
        /// <param name="Page">Page.</param>
        /// <param name="Pages">Pages.</param>
        /// <param name="PerPage">PerPage.</param>
        /// <param name="Columns">Columns.</param>
        /// <param name="AvailableColumns">AvailableColumns.</param>
        /// <param name="List">List.</param>
        /// <param name="View">View.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Timings">Timings.</param>
        public ListEnvelope(int? Total = default(int?), int? Page = default(int?), int? Pages = default(int?), int? PerPage = default(int?), string Columns = default(string), List<AvailableColumn> AvailableColumns = default(List<AvailableColumn>), string List = default(string), ViewEnum? View = default(ViewEnum?), string Sort = default(string), OrderEnum? Order = default(OrderEnum?), List<ListEnvelopeTimings> Timings = default(List<ListEnvelopeTimings>))
        {
            this.Total = Total;
            this.Page = Page;
            this.Pages = Pages;
            this.PerPage = PerPage;
            this.Columns = Columns;
            this.AvailableColumns = AvailableColumns;
            this.List = List;
            this.View = View;
            this.Sort = Sort;
            this.Order = Order;
            this.Timings = Timings;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public int? Pages { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public string Columns { get; set; }

        /// <summary>
        /// Gets or Sets AvailableColumns
        /// </summary>
        [DataMember(Name="available_columns", EmitDefaultValue=false)]
        public List<AvailableColumn> AvailableColumns { get; set; }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public string List { get; set; }


        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }


        /// <summary>
        /// Gets or Sets Timings
        /// </summary>
        [DataMember(Name="timings", EmitDefaultValue=false)]
        public List<ListEnvelopeTimings> Timings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnvelope {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  AvailableColumns: ").Append(AvailableColumns).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Timings: ").Append(Timings).Append("\n");
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
            return this.Equals(obj as ListEnvelope);
        }

        /// <summary>
        /// Returns true if ListEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of ListEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.Equals(other.Pages)
                ) && 
                (
                    this.PerPage == other.PerPage ||
                    this.PerPage != null &&
                    this.PerPage.Equals(other.PerPage)
                ) && 
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.Equals(other.Columns)
                ) && 
                (
                    this.AvailableColumns == other.AvailableColumns ||
                    this.AvailableColumns != null &&
                    this.AvailableColumns.SequenceEqual(other.AvailableColumns)
                ) && 
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.Equals(other.List)
                ) && 
                (
                    this.View == other.View ||
                    this.View != null &&
                    this.View.Equals(other.View)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Timings == other.Timings ||
                    this.Timings != null &&
                    this.Timings.SequenceEqual(other.Timings)
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
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Pages != null)
                    hash = hash * 59 + this.Pages.GetHashCode();
                if (this.PerPage != null)
                    hash = hash * 59 + this.PerPage.GetHashCode();
                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();
                if (this.AvailableColumns != null)
                    hash = hash * 59 + this.AvailableColumns.GetHashCode();
                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();
                if (this.View != null)
                    hash = hash * 59 + this.View.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Timings != null)
                    hash = hash * 59 + this.Timings.GetHashCode();
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
