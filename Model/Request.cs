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
    /// Request
    /// </summary>
    [DataContract]
    public partial class Request :  IEquatable<Request>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Counter">Counter.</param>
        /// <param name="CounterNotes">CounterNotes.</param>
        /// <param name="Active">Active.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Expires">Expires.</param>
        /// <param name="Expired">Expired.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="Eta">Eta.</param>
        /// <param name="HourEstimate">HourEstimate.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="User">User.</param>
        /// <param name="WorkOrder">WorkOrder.</param>
        /// <param name="Pay">Pay.</param>
        /// <param name="Expenses">Expenses.</param>
        /// <param name="Actions">Actions.</param>
        public Request(int? Id = default(int?), bool? Counter = default(bool?), string CounterNotes = default(string), bool? Active = default(bool?), DateTime? Created = default(DateTime?), DateTime? Expires = default(DateTime?), bool? Expired = default(bool?), Schedule Schedule = default(Schedule), ETA Eta = default(ETA), decimal? HourEstimate = default(decimal?), string Notes = default(string), User User = default(User), WorkOrder WorkOrder = default(WorkOrder), Pay Pay = default(Pay), List<Expense> Expenses = default(List<Expense>), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.Id = Id;
            this.Counter = Counter;
            this.CounterNotes = CounterNotes;
            this.Active = Active;
            this.Created = Created;
            this.Expires = Expires;
            this.Expired = Expired;
            this.Schedule = Schedule;
            this.Eta = Eta;
            this.HourEstimate = HourEstimate;
            this.Notes = Notes;
            this.User = User;
            this.WorkOrder = WorkOrder;
            this.Pay = Pay;
            this.Expenses = Expenses;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Counter
        /// </summary>
        [DataMember(Name="counter", EmitDefaultValue=false)]
        public bool? Counter { get; set; }

        /// <summary>
        /// Gets or Sets CounterNotes
        /// </summary>
        [DataMember(Name="counter_notes", EmitDefaultValue=false)]
        public string CounterNotes { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Eta
        /// </summary>
        [DataMember(Name="eta", EmitDefaultValue=false)]
        public ETA Eta { get; set; }

        /// <summary>
        /// Gets or Sets HourEstimate
        /// </summary>
        [DataMember(Name="hour_estimate", EmitDefaultValue=false)]
        public decimal? HourEstimate { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrder
        /// </summary>
        [DataMember(Name="work_order", EmitDefaultValue=false)]
        public WorkOrder WorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets Pay
        /// </summary>
        [DataMember(Name="pay", EmitDefaultValue=false)]
        public Pay Pay { get; set; }

        /// <summary>
        /// Gets or Sets Expenses
        /// </summary>
        [DataMember(Name="expenses", EmitDefaultValue=false)]
        public List<Expense> Expenses { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Request {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
            sb.Append("  CounterNotes: ").Append(CounterNotes).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
            sb.Append("  HourEstimate: ").Append(HourEstimate).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  WorkOrder: ").Append(WorkOrder).Append("\n");
            sb.Append("  Pay: ").Append(Pay).Append("\n");
            sb.Append("  Expenses: ").Append(Expenses).Append("\n");
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
            return this.Equals(obj as Request);
        }

        /// <summary>
        /// Returns true if Request instances are equal
        /// </summary>
        /// <param name="other">Instance of Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request other)
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
                    this.Counter == other.Counter ||
                    this.Counter != null &&
                    this.Counter.Equals(other.Counter)
                ) && 
                (
                    this.CounterNotes == other.CounterNotes ||
                    this.CounterNotes != null &&
                    this.CounterNotes.Equals(other.CounterNotes)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) && 
                (
                    this.Expired == other.Expired ||
                    this.Expired != null &&
                    this.Expired.Equals(other.Expired)
                ) && 
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) && 
                (
                    this.Eta == other.Eta ||
                    this.Eta != null &&
                    this.Eta.Equals(other.Eta)
                ) && 
                (
                    this.HourEstimate == other.HourEstimate ||
                    this.HourEstimate != null &&
                    this.HourEstimate.Equals(other.HourEstimate)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.WorkOrder == other.WorkOrder ||
                    this.WorkOrder != null &&
                    this.WorkOrder.Equals(other.WorkOrder)
                ) && 
                (
                    this.Pay == other.Pay ||
                    this.Pay != null &&
                    this.Pay.Equals(other.Pay)
                ) && 
                (
                    this.Expenses == other.Expenses ||
                    this.Expenses != null &&
                    this.Expenses.SequenceEqual(other.Expenses)
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
                if (this.Counter != null)
                    hash = hash * 59 + this.Counter.GetHashCode();
                if (this.CounterNotes != null)
                    hash = hash * 59 + this.CounterNotes.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Expires != null)
                    hash = hash * 59 + this.Expires.GetHashCode();
                if (this.Expired != null)
                    hash = hash * 59 + this.Expired.GetHashCode();
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this.Eta != null)
                    hash = hash * 59 + this.Eta.GetHashCode();
                if (this.HourEstimate != null)
                    hash = hash * 59 + this.HourEstimate.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.WorkOrder != null)
                    hash = hash * 59 + this.WorkOrder.GetHashCode();
                if (this.Pay != null)
                    hash = hash * 59 + this.Pay.GetHashCode();
                if (this.Expenses != null)
                    hash = hash * 59 + this.Expenses.GetHashCode();
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
