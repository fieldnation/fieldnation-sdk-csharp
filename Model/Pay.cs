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
    /// Pay
    /// </summary>
    [DataContract]
    public partial class Pay :  IEquatable<Pay>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Empty for ""
            /// </summary>
            [EnumMember(Value = "")]
            Empty,
            
            /// <summary>
            /// Enum Hourly for "hourly"
            /// </summary>
            [EnumMember(Value = "hourly")]
            Hourly,
            
            /// <summary>
            /// Enum Fixed for "fixed"
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed,
            
            /// <summary>
            /// Enum Device for "device"
            /// </summary>
            [EnumMember(Value = "device")]
            Device,
            
            /// <summary>
            /// Enum Blended for "blended"
            /// </summary>
            [EnumMember(Value = "blended")]
            Blended
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
            /// Enum Print for "print"
            /// </summary>
            [EnumMember(Value = "print")]
            Print,
            
            /// <summary>
            /// Enum View for "view"
            /// </summary>
            [EnumMember(Value = "view")]
            View
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pay" /> class.
        /// </summary>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="Type">Type.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Role">Role.</param>
        /// <param name="MinimumPayment">MinimumPayment.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="_Base">_Base.</param>
        /// <param name="Additional">Additional.</param>
        /// <param name="Finance">Finance.</param>
        /// <param name="Range">Range.</param>
        /// <param name="PricingInsights">PricingInsights.</param>
        /// <param name="ReportedHours">ReportedHours.</param>
        /// <param name="NumberOfDevices">NumberOfDevices.</param>
        /// <param name="LaborSum">LaborSum.</param>
        /// <param name="Total">Total.</param>
        /// <param name="EstimatedPaymentDate">EstimatedPaymentDate.</param>
        /// <param name="Hold">Hold.</param>
        /// <param name="Payment">Payment.</param>
        /// <param name="Fees">Fees.</param>
        /// <param name="Bonuses">Bonuses.</param>
        /// <param name="Penalties">Penalties.</param>
        /// <param name="Discounts">Discounts.</param>
        /// <param name="Expenses">Expenses.</param>
        /// <param name="Increases">Increases.</param>
        /// <param name="MaxPay">MaxPay.</param>
        /// <param name="Term">Term.</param>
        public Pay(int? WorkOrderId = default(int?), TypeEnum? Type = default(TypeEnum?), string CorrelationId = default(string), string Role = default(string), decimal? MinimumPayment = default(decimal?), List<ActionsEnum> Actions = default(List<ActionsEnum>), PayBase _Base = default(PayBase), PayBase Additional = default(PayBase), PayFinance Finance = default(PayFinance), PayRange Range = default(PayRange), PricingInsights PricingInsights = default(PricingInsights), decimal? ReportedHours = default(decimal?), decimal? NumberOfDevices = default(decimal?), decimal? LaborSum = default(decimal?), decimal? Total = default(decimal?), DateTime? EstimatedPaymentDate = default(DateTime?), PayModifier Hold = default(PayModifier), PayModifier Payment = default(PayModifier), List<PayModifier> Fees = default(List<PayModifier>), PayModifiers Bonuses = default(PayModifiers), PayModifiers Penalties = default(PayModifiers), PayModifiers Discounts = default(PayModifiers), Expenses Expenses = default(Expenses), PayIncreases Increases = default(PayIncreases), decimal? MaxPay = default(decimal?), PayTerm Term = default(PayTerm))
        {
            this.WorkOrderId = WorkOrderId;
            this.Type = Type;
            this.CorrelationId = CorrelationId;
            this.Role = Role;
            this.MinimumPayment = MinimumPayment;
            this.Actions = Actions;
            this._Base = _Base;
            this.Additional = Additional;
            this.Finance = Finance;
            this.Range = Range;
            this.PricingInsights = PricingInsights;
            this.ReportedHours = ReportedHours;
            this.NumberOfDevices = NumberOfDevices;
            this.LaborSum = LaborSum;
            this.Total = Total;
            this.EstimatedPaymentDate = EstimatedPaymentDate;
            this.Hold = Hold;
            this.Payment = Payment;
            this.Fees = Fees;
            this.Bonuses = Bonuses;
            this.Penalties = Penalties;
            this.Discounts = Discounts;
            this.Expenses = Expenses;
            this.Increases = Increases;
            this.MaxPay = MaxPay;
            this.Term = Term;
        }
        
        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }


        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets MinimumPayment
        /// </summary>
        [DataMember(Name="minimum_payment", EmitDefaultValue=false)]
        public decimal? MinimumPayment { get; set; }


        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public PayBase _Base { get; set; }

        /// <summary>
        /// Gets or Sets Additional
        /// </summary>
        [DataMember(Name="additional", EmitDefaultValue=false)]
        public PayBase Additional { get; set; }

        /// <summary>
        /// Gets or Sets Finance
        /// </summary>
        [DataMember(Name="finance", EmitDefaultValue=false)]
        public PayFinance Finance { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public PayRange Range { get; set; }

        /// <summary>
        /// Gets or Sets PricingInsights
        /// </summary>
        [DataMember(Name="pricing_insights", EmitDefaultValue=false)]
        public PricingInsights PricingInsights { get; set; }

        /// <summary>
        /// Gets or Sets ReportedHours
        /// </summary>
        [DataMember(Name="reported_hours", EmitDefaultValue=false)]
        public decimal? ReportedHours { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDevices
        /// </summary>
        [DataMember(Name="number_of_devices", EmitDefaultValue=false)]
        public decimal? NumberOfDevices { get; set; }

        /// <summary>
        /// Gets or Sets LaborSum
        /// </summary>
        [DataMember(Name="labor_sum", EmitDefaultValue=false)]
        public decimal? LaborSum { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedPaymentDate
        /// </summary>
        [DataMember(Name="estimated_payment_date", EmitDefaultValue=false)]
        public DateTime? EstimatedPaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets Hold
        /// </summary>
        [DataMember(Name="hold", EmitDefaultValue=false)]
        public PayModifier Hold { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public PayModifier Payment { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public List<PayModifier> Fees { get; set; }

        /// <summary>
        /// Gets or Sets Bonuses
        /// </summary>
        [DataMember(Name="bonuses", EmitDefaultValue=false)]
        public PayModifiers Bonuses { get; set; }

        /// <summary>
        /// Gets or Sets Penalties
        /// </summary>
        [DataMember(Name="penalties", EmitDefaultValue=false)]
        public PayModifiers Penalties { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public PayModifiers Discounts { get; set; }

        /// <summary>
        /// Gets or Sets Expenses
        /// </summary>
        [DataMember(Name="expenses", EmitDefaultValue=false)]
        public Expenses Expenses { get; set; }

        /// <summary>
        /// Gets or Sets Increases
        /// </summary>
        [DataMember(Name="increases", EmitDefaultValue=false)]
        public PayIncreases Increases { get; set; }

        /// <summary>
        /// Gets or Sets MaxPay
        /// </summary>
        [DataMember(Name="max_pay", EmitDefaultValue=false)]
        public decimal? MaxPay { get; set; }

        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name="term", EmitDefaultValue=false)]
        public PayTerm Term { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pay {\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  MinimumPayment: ").Append(MinimumPayment).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  Additional: ").Append(Additional).Append("\n");
            sb.Append("  Finance: ").Append(Finance).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  PricingInsights: ").Append(PricingInsights).Append("\n");
            sb.Append("  ReportedHours: ").Append(ReportedHours).Append("\n");
            sb.Append("  NumberOfDevices: ").Append(NumberOfDevices).Append("\n");
            sb.Append("  LaborSum: ").Append(LaborSum).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  EstimatedPaymentDate: ").Append(EstimatedPaymentDate).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Bonuses: ").Append(Bonuses).Append("\n");
            sb.Append("  Penalties: ").Append(Penalties).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Expenses: ").Append(Expenses).Append("\n");
            sb.Append("  Increases: ").Append(Increases).Append("\n");
            sb.Append("  MaxPay: ").Append(MaxPay).Append("\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
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
            return this.Equals(obj as Pay);
        }

        /// <summary>
        /// Returns true if Pay instances are equal
        /// </summary>
        /// <param name="other">Instance of Pay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pay other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkOrderId == other.WorkOrderId ||
                    this.WorkOrderId != null &&
                    this.WorkOrderId.Equals(other.WorkOrderId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.MinimumPayment == other.MinimumPayment ||
                    this.MinimumPayment != null &&
                    this.MinimumPayment.Equals(other.MinimumPayment)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this._Base == other._Base ||
                    this._Base != null &&
                    this._Base.Equals(other._Base)
                ) && 
                (
                    this.Additional == other.Additional ||
                    this.Additional != null &&
                    this.Additional.Equals(other.Additional)
                ) && 
                (
                    this.Finance == other.Finance ||
                    this.Finance != null &&
                    this.Finance.Equals(other.Finance)
                ) && 
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
                ) && 
                (
                    this.PricingInsights == other.PricingInsights ||
                    this.PricingInsights != null &&
                    this.PricingInsights.Equals(other.PricingInsights)
                ) && 
                (
                    this.ReportedHours == other.ReportedHours ||
                    this.ReportedHours != null &&
                    this.ReportedHours.Equals(other.ReportedHours)
                ) && 
                (
                    this.NumberOfDevices == other.NumberOfDevices ||
                    this.NumberOfDevices != null &&
                    this.NumberOfDevices.Equals(other.NumberOfDevices)
                ) && 
                (
                    this.LaborSum == other.LaborSum ||
                    this.LaborSum != null &&
                    this.LaborSum.Equals(other.LaborSum)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.EstimatedPaymentDate == other.EstimatedPaymentDate ||
                    this.EstimatedPaymentDate != null &&
                    this.EstimatedPaymentDate.Equals(other.EstimatedPaymentDate)
                ) && 
                (
                    this.Hold == other.Hold ||
                    this.Hold != null &&
                    this.Hold.Equals(other.Hold)
                ) && 
                (
                    this.Payment == other.Payment ||
                    this.Payment != null &&
                    this.Payment.Equals(other.Payment)
                ) && 
                (
                    this.Fees == other.Fees ||
                    this.Fees != null &&
                    this.Fees.SequenceEqual(other.Fees)
                ) && 
                (
                    this.Bonuses == other.Bonuses ||
                    this.Bonuses != null &&
                    this.Bonuses.Equals(other.Bonuses)
                ) && 
                (
                    this.Penalties == other.Penalties ||
                    this.Penalties != null &&
                    this.Penalties.Equals(other.Penalties)
                ) && 
                (
                    this.Discounts == other.Discounts ||
                    this.Discounts != null &&
                    this.Discounts.Equals(other.Discounts)
                ) && 
                (
                    this.Expenses == other.Expenses ||
                    this.Expenses != null &&
                    this.Expenses.Equals(other.Expenses)
                ) && 
                (
                    this.Increases == other.Increases ||
                    this.Increases != null &&
                    this.Increases.Equals(other.Increases)
                ) && 
                (
                    this.MaxPay == other.MaxPay ||
                    this.MaxPay != null &&
                    this.MaxPay.Equals(other.MaxPay)
                ) && 
                (
                    this.Term == other.Term ||
                    this.Term != null &&
                    this.Term.Equals(other.Term)
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
                if (this.WorkOrderId != null)
                    hash = hash * 59 + this.WorkOrderId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.MinimumPayment != null)
                    hash = hash * 59 + this.MinimumPayment.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this._Base != null)
                    hash = hash * 59 + this._Base.GetHashCode();
                if (this.Additional != null)
                    hash = hash * 59 + this.Additional.GetHashCode();
                if (this.Finance != null)
                    hash = hash * 59 + this.Finance.GetHashCode();
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                if (this.PricingInsights != null)
                    hash = hash * 59 + this.PricingInsights.GetHashCode();
                if (this.ReportedHours != null)
                    hash = hash * 59 + this.ReportedHours.GetHashCode();
                if (this.NumberOfDevices != null)
                    hash = hash * 59 + this.NumberOfDevices.GetHashCode();
                if (this.LaborSum != null)
                    hash = hash * 59 + this.LaborSum.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.EstimatedPaymentDate != null)
                    hash = hash * 59 + this.EstimatedPaymentDate.GetHashCode();
                if (this.Hold != null)
                    hash = hash * 59 + this.Hold.GetHashCode();
                if (this.Payment != null)
                    hash = hash * 59 + this.Payment.GetHashCode();
                if (this.Fees != null)
                    hash = hash * 59 + this.Fees.GetHashCode();
                if (this.Bonuses != null)
                    hash = hash * 59 + this.Bonuses.GetHashCode();
                if (this.Penalties != null)
                    hash = hash * 59 + this.Penalties.GetHashCode();
                if (this.Discounts != null)
                    hash = hash * 59 + this.Discounts.GetHashCode();
                if (this.Expenses != null)
                    hash = hash * 59 + this.Expenses.GetHashCode();
                if (this.Increases != null)
                    hash = hash * 59 + this.Increases.GetHashCode();
                if (this.MaxPay != null)
                    hash = hash * 59 + this.MaxPay.GetHashCode();
                if (this.Term != null)
                    hash = hash * 59 + this.Term.GetHashCode();
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
