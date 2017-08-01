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
    /// Expenses
    /// </summary>
    [DataContract]
    public partial class Expenses :  IEquatable<Expenses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expenses" /> class.
        /// </summary>
        /// <param name="_Expenses">_Expenses.</param>
        public Expenses(WorkordersworkOrderIdexpensesExpenses _Expenses = default(WorkordersworkOrderIdexpensesExpenses))
        {
            this._Expenses = _Expenses;
        }
        
        /// <summary>
        /// Gets or Sets _Expenses
        /// </summary>
        [DataMember(Name="expenses", EmitDefaultValue=false)]
        public WorkordersworkOrderIdexpensesExpenses _Expenses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Expenses {\n");
            sb.Append("  _Expenses: ").Append(_Expenses).Append("\n");
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
            return this.Equals(obj as Expenses);
        }

        /// <summary>
        /// Returns true if Expenses instances are equal
        /// </summary>
        /// <param name="other">Instance of Expenses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expenses other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Expenses == other._Expenses ||
                    this._Expenses != null &&
                    this._Expenses.Equals(other._Expenses)
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
                if (this._Expenses != null)
                    hash = hash * 59 + this._Expenses.GetHashCode();
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
