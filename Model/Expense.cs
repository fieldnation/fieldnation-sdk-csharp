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
    /// Expense
    /// </summary>
    [DataContract]
    public partial class Expense :  IEquatable<Expense>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum New for "new"
            /// </summary>
            [EnumMember(Value = "new")]
            New,
            
            /// <summary>
            /// Enum Approved for "approved"
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved,
            
            /// <summary>
            /// Enum Disapproved for "disapproved"
            /// </summary>
            [EnumMember(Value = "disapproved")]
            Disapproved
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete,
            
            /// <summary>
            /// Enum Approve for "approve"
            /// </summary>
            [EnumMember(Value = "approve")]
            Approve,
            
            /// <summary>
            /// Enum Deny for "deny"
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny,
            
            /// <summary>
            /// Enum Reopen for "reopen"
            /// </summary>
            [EnumMember(Value = "reopen")]
            Reopen
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Expense" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusDescription">StatusDescription.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Added">Added.</param>
        /// <param name="Author">Author.</param>
        /// <param name="CompanyExpense">CompanyExpense.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Actions">Actions.</param>
        public Expense(int? Id = default(int?), string Description = default(string), decimal? Quantity = default(decimal?), StatusEnum? Status = default(StatusEnum?), string StatusDescription = default(string), InlineResponse2002 Category = default(InlineResponse2002), DateTime? Added = default(DateTime?), User Author = default(User), ExpenseCompanyExpense CompanyExpense = default(ExpenseCompanyExpense), decimal? Amount = default(decimal?), string Reason = default(string), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.Id = Id;
            this.Description = Description;
            this.Quantity = Quantity;
            this.Status = Status;
            this.StatusDescription = StatusDescription;
            this.Category = Category;
            this.Added = Added;
            this.Author = Author;
            this.CompanyExpense = CompanyExpense;
            this.Amount = Amount;
            this.Reason = Reason;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }


        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="status_description", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public InlineResponse2002 Category { get; set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public DateTime? Added { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public User Author { get; set; }

        /// <summary>
        /// Gets or Sets CompanyExpense
        /// </summary>
        [DataMember(Name="company_expense", EmitDefaultValue=false)]
        public ExpenseCompanyExpense CompanyExpense { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Expense {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  CompanyExpense: ").Append(CompanyExpense).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as Expense);
        }

        /// <summary>
        /// Returns true if Expense instances are equal
        /// </summary>
        /// <param name="other">Instance of Expense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expense other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusDescription == other.StatusDescription ||
                    this.StatusDescription != null &&
                    this.StatusDescription.Equals(other.StatusDescription)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Added == other.Added ||
                    this.Added != null &&
                    this.Added.Equals(other.Added)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.CompanyExpense == other.CompanyExpense ||
                    this.CompanyExpense != null &&
                    this.CompanyExpense.Equals(other.CompanyExpense)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hash = hash * 59 + this.StatusDescription.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Added != null)
                    hash = hash * 59 + this.Added.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.CompanyExpense != null)
                    hash = hash * 59 + this.CompanyExpense.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
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
