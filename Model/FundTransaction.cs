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
    /// FundTransaction
    /// </summary>
    [DataContract]
    public partial class FundTransaction :  IEquatable<FundTransaction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Payment for "payment"
            /// </summary>
            [EnumMember(Value = "payment")]
            Payment,
            
            /// <summary>
            /// Enum Withdrawal for "withdrawal"
            /// </summary>
            [EnumMember(Value = "withdrawal")]
            Withdrawal,
            
            /// <summary>
            /// Enum Deposit for "deposit"
            /// </summary>
            [EnumMember(Value = "deposit")]
            Deposit,
            
            /// <summary>
            /// Enum Loan for "loan"
            /// </summary>
            [EnumMember(Value = "loan")]
            Loan,
            
            /// <summary>
            /// Enum Servicefee for "service_fee"
            /// </summary>
            [EnumMember(Value = "service_fee")]
            Servicefee,
            
            /// <summary>
            /// Enum Insurancefee for "insurance_fee"
            /// </summary>
            [EnumMember(Value = "insurance_fee")]
            Insurancefee,
            
            /// <summary>
            /// Enum Ccauth for "ccauth"
            /// </summary>
            [EnumMember(Value = "ccauth")]
            Ccauth
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Completed for "completed"
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed,
            
            /// <summary>
            /// Enum Holding for "holding"
            /// </summary>
            [EnumMember(Value = "holding")]
            Holding,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FundTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundTransaction" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusReason">StatusReason.</param>
        /// <param name="Note">Note.</param>
        /// <param name="CreditCardId">CreditCardId.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Updated">Updated.</param>
        /// <param name="WorkOrder">WorkOrder.</param>
        /// <param name="CreditCard">CreditCard.</param>
        /// <param name="Bank">Bank.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        public FundTransaction(int? Id = default(int?), TypeEnum? Type = default(TypeEnum?), decimal? Amount = default(decimal?), string Description = default(string), StatusEnum? Status = default(StatusEnum?), string StatusReason = default(string), string Note = default(string), string CreditCardId = default(string), string ExternalId = default(string), DateTime? Created = default(DateTime?), DateTime? Updated = default(DateTime?), WorkOrder WorkOrder = default(WorkOrder), CreditCard CreditCard = default(CreditCard), Bank Bank = default(Bank), BillingAddress BillingAddress = default(BillingAddress))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for FundTransaction and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for FundTransaction and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            this.Id = Id;
            this.Description = Description;
            this.Status = Status;
            this.StatusReason = StatusReason;
            this.Note = Note;
            this.CreditCardId = CreditCardId;
            this.ExternalId = ExternalId;
            this.Created = Created;
            this.Updated = Updated;
            this.WorkOrder = WorkOrder;
            this.CreditCard = CreditCard;
            this.Bank = Bank;
            this.BillingAddress = BillingAddress;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Gets or Sets StatusReason
        /// </summary>
        [DataMember(Name="status_reason", EmitDefaultValue=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardId
        /// </summary>
        [DataMember(Name="credit_card_id", EmitDefaultValue=false)]
        public string CreditCardId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrder
        /// </summary>
        [DataMember(Name="work_order", EmitDefaultValue=false)]
        public WorkOrder WorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets CreditCard
        /// </summary>
        [DataMember(Name="credit_card", EmitDefaultValue=false)]
        public CreditCard CreditCard { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public Bank Bank { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CreditCardId: ").Append(CreditCardId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  WorkOrder: ").Append(WorkOrder).Append("\n");
            sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
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
            return this.Equals(obj as FundTransaction);
        }

        /// <summary>
        /// Returns true if FundTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of FundTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundTransaction other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusReason == other.StatusReason ||
                    this.StatusReason != null &&
                    this.StatusReason.Equals(other.StatusReason)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.CreditCardId == other.CreditCardId ||
                    this.CreditCardId != null &&
                    this.CreditCardId.Equals(other.CreditCardId)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.WorkOrder == other.WorkOrder ||
                    this.WorkOrder != null &&
                    this.WorkOrder.Equals(other.WorkOrder)
                ) && 
                (
                    this.CreditCard == other.CreditCard ||
                    this.CreditCard != null &&
                    this.CreditCard.Equals(other.CreditCard)
                ) && 
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusReason != null)
                    hash = hash * 59 + this.StatusReason.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.CreditCardId != null)
                    hash = hash * 59 + this.CreditCardId.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.WorkOrder != null)
                    hash = hash * 59 + this.WorkOrder.GetHashCode();
                if (this.CreditCard != null)
                    hash = hash * 59 + this.CreditCard.GetHashCode();
                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
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
