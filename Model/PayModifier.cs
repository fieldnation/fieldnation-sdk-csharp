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
    /// PayModifier
    /// </summary>
    [DataContract]
    public partial class PayModifier :  IEquatable<PayModifier>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Calculation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CalculationEnum
        {
            
            /// <summary>
            /// Enum Fixed for "fixed"
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed,
            
            /// <summary>
            /// Enum Percent for "percent"
            /// </summary>
            [EnumMember(Value = "percent")]
            Percent
        }


        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Charge for "charge"
            /// </summary>
            [EnumMember(Value = "charge")]
            Charge,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete
        }

        /// <summary>
        /// Gets or Sets Calculation
        /// </summary>
        [DataMember(Name="calculation", EmitDefaultValue=false)]
        public CalculationEnum? Calculation { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayModifier" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Charged">Charged.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Modifier">Modifier.</param>
        /// <param name="Calculation">Calculation.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Hours24Applicable">Hours24Applicable.</param>
        /// <param name="Actions">Actions.</param>
        public PayModifier(int? Id = default(int?), bool? Charged = default(bool?), decimal? Amount = default(decimal?), decimal? Modifier = default(decimal?), CalculationEnum? Calculation = default(CalculationEnum?), string Name = default(string), string Description = default(string), bool? Hours24Applicable = default(bool?), List<ActionsEnum> Actions = default(List<ActionsEnum>))
        {
            this.Id = Id;
            this.Charged = Charged;
            this.Amount = Amount;
            this.Modifier = Modifier;
            this.Calculation = Calculation;
            this.Name = Name;
            this.Description = Description;
            this.Hours24Applicable = Hours24Applicable;
            this.Actions = Actions;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Charged
        /// </summary>
        [DataMember(Name="charged", EmitDefaultValue=false)]
        public bool? Charged { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Modifier
        /// </summary>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        public decimal? Modifier { get; set; }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Hours24Applicable
        /// </summary>
        [DataMember(Name="hours24_applicable", EmitDefaultValue=false)]
        public bool? Hours24Applicable { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayModifier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Charged: ").Append(Charged).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  Calculation: ").Append(Calculation).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Hours24Applicable: ").Append(Hours24Applicable).Append("\n");
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
            return this.Equals(obj as PayModifier);
        }

        /// <summary>
        /// Returns true if PayModifier instances are equal
        /// </summary>
        /// <param name="other">Instance of PayModifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayModifier other)
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
                    this.Charged == other.Charged ||
                    this.Charged != null &&
                    this.Charged.Equals(other.Charged)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Modifier == other.Modifier ||
                    this.Modifier != null &&
                    this.Modifier.Equals(other.Modifier)
                ) && 
                (
                    this.Calculation == other.Calculation ||
                    this.Calculation != null &&
                    this.Calculation.Equals(other.Calculation)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Hours24Applicable == other.Hours24Applicable ||
                    this.Hours24Applicable != null &&
                    this.Hours24Applicable.Equals(other.Hours24Applicable)
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
                if (this.Charged != null)
                    hash = hash * 59 + this.Charged.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Modifier != null)
                    hash = hash * 59 + this.Modifier.GetHashCode();
                if (this.Calculation != null)
                    hash = hash * 59 + this.Calculation.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Hours24Applicable != null)
                    hash = hash * 59 + this.Hours24Applicable.GetHashCode();
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
