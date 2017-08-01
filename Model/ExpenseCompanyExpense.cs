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
    /// ExpenseCompanyExpense
    /// </summary>
    [DataContract]
    public partial class ExpenseCompanyExpense :  IEquatable<ExpenseCompanyExpense>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseCompanyExpense" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ExpenseAmount">ExpenseAmount.</param>
        /// <param name="HiddenTags">HiddenTags.</param>
        /// <param name="ApiCode">ApiCode.</param>
        /// <param name="Description">Description.</param>
        public ExpenseCompanyExpense(int? Id = default(int?), decimal? ExpenseAmount = default(decimal?), string HiddenTags = default(string), string ApiCode = default(string), string Description = default(string))
        {
            this.Id = Id;
            this.ExpenseAmount = ExpenseAmount;
            this.HiddenTags = HiddenTags;
            this.ApiCode = ApiCode;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAmount
        /// </summary>
        [DataMember(Name="expense_amount", EmitDefaultValue=false)]
        public decimal? ExpenseAmount { get; set; }

        /// <summary>
        /// Gets or Sets HiddenTags
        /// </summary>
        [DataMember(Name="hidden_tags", EmitDefaultValue=false)]
        public string HiddenTags { get; set; }

        /// <summary>
        /// Gets or Sets ApiCode
        /// </summary>
        [DataMember(Name="api_code", EmitDefaultValue=false)]
        public string ApiCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseCompanyExpense {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExpenseAmount: ").Append(ExpenseAmount).Append("\n");
            sb.Append("  HiddenTags: ").Append(HiddenTags).Append("\n");
            sb.Append("  ApiCode: ").Append(ApiCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as ExpenseCompanyExpense);
        }

        /// <summary>
        /// Returns true if ExpenseCompanyExpense instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpenseCompanyExpense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseCompanyExpense other)
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
                    this.ExpenseAmount == other.ExpenseAmount ||
                    this.ExpenseAmount != null &&
                    this.ExpenseAmount.Equals(other.ExpenseAmount)
                ) && 
                (
                    this.HiddenTags == other.HiddenTags ||
                    this.HiddenTags != null &&
                    this.HiddenTags.Equals(other.HiddenTags)
                ) && 
                (
                    this.ApiCode == other.ApiCode ||
                    this.ApiCode != null &&
                    this.ApiCode.Equals(other.ApiCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.ExpenseAmount != null)
                    hash = hash * 59 + this.ExpenseAmount.GetHashCode();
                if (this.HiddenTags != null)
                    hash = hash * 59 + this.HiddenTags.GetHashCode();
                if (this.ApiCode != null)
                    hash = hash * 59 + this.ApiCode.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
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
