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
    /// AutoDispatch
    /// </summary>
    [DataContract]
    public partial class AutoDispatch :  IEquatable<AutoDispatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoDispatch" /> class.
        /// </summary>
        /// <param name="WorkOrderIds">WorkOrderIds.</param>
        /// <param name="SelectionRuleId">SelectionRuleId.</param>
        /// <param name="Delay">Delay.</param>
        /// <param name="W2Skippub">W2Skippub.</param>
        /// <param name="W2Failswitch">W2Failswitch.</param>
        /// <param name="ShouldRoute">ShouldRoute.</param>
        public AutoDispatch(List<int?> WorkOrderIds = default(List<int?>), int? SelectionRuleId = default(int?), int? Delay = default(int?), bool? W2Skippub = default(bool?), bool? W2Failswitch = default(bool?), bool? ShouldRoute = default(bool?))
        {
            this.WorkOrderIds = WorkOrderIds;
            this.SelectionRuleId = SelectionRuleId;
            this.Delay = Delay;
            this.W2Skippub = W2Skippub;
            this.W2Failswitch = W2Failswitch;
            this.ShouldRoute = ShouldRoute;
        }
        
        /// <summary>
        /// Gets or Sets WorkOrderIds
        /// </summary>
        [DataMember(Name="work_order_ids", EmitDefaultValue=false)]
        public List<int?> WorkOrderIds { get; set; }

        /// <summary>
        /// Gets or Sets SelectionRuleId
        /// </summary>
        [DataMember(Name="selection_rule_id", EmitDefaultValue=false)]
        public int? SelectionRuleId { get; set; }

        /// <summary>
        /// Gets or Sets Delay
        /// </summary>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// Gets or Sets W2Skippub
        /// </summary>
        [DataMember(Name="w2_skippub", EmitDefaultValue=false)]
        public bool? W2Skippub { get; set; }

        /// <summary>
        /// Gets or Sets W2Failswitch
        /// </summary>
        [DataMember(Name="w2_failswitch", EmitDefaultValue=false)]
        public bool? W2Failswitch { get; set; }

        /// <summary>
        /// Gets or Sets ShouldRoute
        /// </summary>
        [DataMember(Name="should_route", EmitDefaultValue=false)]
        public bool? ShouldRoute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoDispatch {\n");
            sb.Append("  WorkOrderIds: ").Append(WorkOrderIds).Append("\n");
            sb.Append("  SelectionRuleId: ").Append(SelectionRuleId).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  W2Skippub: ").Append(W2Skippub).Append("\n");
            sb.Append("  W2Failswitch: ").Append(W2Failswitch).Append("\n");
            sb.Append("  ShouldRoute: ").Append(ShouldRoute).Append("\n");
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
            return this.Equals(obj as AutoDispatch);
        }

        /// <summary>
        /// Returns true if AutoDispatch instances are equal
        /// </summary>
        /// <param name="other">Instance of AutoDispatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoDispatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WorkOrderIds == other.WorkOrderIds ||
                    this.WorkOrderIds != null &&
                    this.WorkOrderIds.SequenceEqual(other.WorkOrderIds)
                ) && 
                (
                    this.SelectionRuleId == other.SelectionRuleId ||
                    this.SelectionRuleId != null &&
                    this.SelectionRuleId.Equals(other.SelectionRuleId)
                ) && 
                (
                    this.Delay == other.Delay ||
                    this.Delay != null &&
                    this.Delay.Equals(other.Delay)
                ) && 
                (
                    this.W2Skippub == other.W2Skippub ||
                    this.W2Skippub != null &&
                    this.W2Skippub.Equals(other.W2Skippub)
                ) && 
                (
                    this.W2Failswitch == other.W2Failswitch ||
                    this.W2Failswitch != null &&
                    this.W2Failswitch.Equals(other.W2Failswitch)
                ) && 
                (
                    this.ShouldRoute == other.ShouldRoute ||
                    this.ShouldRoute != null &&
                    this.ShouldRoute.Equals(other.ShouldRoute)
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
                if (this.WorkOrderIds != null)
                    hash = hash * 59 + this.WorkOrderIds.GetHashCode();
                if (this.SelectionRuleId != null)
                    hash = hash * 59 + this.SelectionRuleId.GetHashCode();
                if (this.Delay != null)
                    hash = hash * 59 + this.Delay.GetHashCode();
                if (this.W2Skippub != null)
                    hash = hash * 59 + this.W2Skippub.GetHashCode();
                if (this.W2Failswitch != null)
                    hash = hash * 59 + this.W2Failswitch.GetHashCode();
                if (this.ShouldRoute != null)
                    hash = hash * 59 + this.ShouldRoute.GetHashCode();
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
