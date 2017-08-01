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
    /// SelectionRuleCriteria
    /// </summary>
    [DataContract]
    public partial class SelectionRuleCriteria :  IEquatable<SelectionRuleCriteria>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum CERTIFICATION for "SC_CERTIFICATION"
            /// </summary>
            [EnumMember(Value = "SC_CERTIFICATION")]
            CERTIFICATION,
            
            /// <summary>
            /// Enum SERVICECATEGORY for "SC_SERVICE_CATEGORY"
            /// </summary>
            [EnumMember(Value = "SC_SERVICE_CATEGORY")]
            SERVICECATEGORY,
            
            /// <summary>
            /// Enum SERVICECATEGORYOFWORKORDER for "SC_SERVICE_CATEGORY_OF_WORKORDER"
            /// </summary>
            [EnumMember(Value = "SC_SERVICE_CATEGORY_OF_WORKORDER")]
            SERVICECATEGORYOFWORKORDER,
            
            /// <summary>
            /// Enum AMOUNTCURRENTLYASSIGNED for "SC_AMOUNT_CURRENTLY_ASSIGNED"
            /// </summary>
            [EnumMember(Value = "SC_AMOUNT_CURRENTLY_ASSIGNED")]
            AMOUNTCURRENTLYASSIGNED,
            
            /// <summary>
            /// Enum AMOUNTCOMPLETEDFORALLCOMPANIES for "SC_AMOUNT_COMPLETED_FOR_ALL_COMPANIES"
            /// </summary>
            [EnumMember(Value = "SC_AMOUNT_COMPLETED_FOR_ALL_COMPANIES")]
            AMOUNTCOMPLETEDFORALLCOMPANIES,
            
            /// <summary>
            /// Enum AMOUNTCOMPLETEDFORMYCOMPANY for "SC_AMOUNT_COMPLETED_FOR_MY_COMPANY"
            /// </summary>
            [EnumMember(Value = "SC_AMOUNT_COMPLETED_FOR_MY_COMPANY")]
            AMOUNTCOMPLETEDFORMYCOMPANY,
            
            /// <summary>
            /// Enum DISTANCEFROMWORKORDER for "SC_DISTANCE_FROM_WORK_ORDER"
            /// </summary>
            [EnumMember(Value = "SC_DISTANCE_FROM_WORK_ORDER")]
            DISTANCEFROMWORKORDER,
            
            /// <summary>
            /// Enum CUSTOMPROVIDERFIELDS for "SC_CUSTOM_PROVIDER_FIELDS"
            /// </summary>
            [EnumMember(Value = "SC_CUSTOM_PROVIDER_FIELDS")]
            CUSTOMPROVIDERFIELDS,
            
            /// <summary>
            /// Enum MYTECHNICIANGROUP for "SC_MY_TECHNICIAN_GROUP"
            /// </summary>
            [EnumMember(Value = "SC_MY_TECHNICIAN_GROUP")]
            MYTECHNICIANGROUP,
            
            /// <summary>
            /// Enum OVERALLRATING for "SC_OVERALL_RATING"
            /// </summary>
            [EnumMember(Value = "SC_OVERALL_RATING")]
            OVERALLRATING,
            
            /// <summary>
            /// Enum PROVIDERANDWORKORDER for "SC_PROVIDER_AND_WORK_ORDER"
            /// </summary>
            [EnumMember(Value = "SC_PROVIDER_AND_WORK_ORDER")]
            PROVIDERANDWORKORDER,
            
            /// <summary>
            /// Enum INSURANCE for "SC_INSURANCE"
            /// </summary>
            [EnumMember(Value = "SC_INSURANCE")]
            INSURANCE,
            
            /// <summary>
            /// Enum BACKGROUNDCHECK for "SC_BACKGROUND_CHECK"
            /// </summary>
            [EnumMember(Value = "SC_BACKGROUND_CHECK")]
            BACKGROUNDCHECK,
            
            /// <summary>
            /// Enum DRUGTEST for "SC_DRUG_TEST"
            /// </summary>
            [EnumMember(Value = "SC_DRUG_TEST")]
            DRUGTEST,
            
            /// <summary>
            /// Enum ASSIGNEDBEFORE for "SC_ASSIGNED_BEFORE"
            /// </summary>
            [EnumMember(Value = "SC_ASSIGNED_BEFORE")]
            ASSIGNEDBEFORE,
            
            /// <summary>
            /// Enum ASSIGNEDNEARBY for "SC_ASSIGNED_NEARBY"
            /// </summary>
            [EnumMember(Value = "SC_ASSIGNED_NEARBY")]
            ASSIGNEDNEARBY,
            
            /// <summary>
            /// Enum REQUESTED for "SC_REQUESTED"
            /// </summary>
            [EnumMember(Value = "SC_REQUESTED")]
            REQUESTED,
            
            /// <summary>
            /// Enum RECENTLYMATCHEDWO for "SC_RECENTLY_MATCHED_WO"
            /// </summary>
            [EnumMember(Value = "SC_RECENTLY_MATCHED_WO")]
            RECENTLYMATCHEDWO,
            
            /// <summary>
            /// Enum VERIFICATION for "SC_VERIFICATION"
            /// </summary>
            [EnumMember(Value = "SC_VERIFICATION")]
            VERIFICATION,
            
            /// <summary>
            /// Enum BLOCKRATIO for "SC_BLOCK_RATIO"
            /// </summary>
            [EnumMember(Value = "SC_BLOCK_RATIO")]
            BLOCKRATIO,
            
            /// <summary>
            /// Enum CANCELRATIO for "SC_CANCEL_RATIO"
            /// </summary>
            [EnumMember(Value = "SC_CANCEL_RATIO")]
            CANCELRATIO,
            
            /// <summary>
            /// Enum STARBASEDRATING for "SC_STAR_BASED_RATING"
            /// </summary>
            [EnumMember(Value = "SC_STAR_BASED_RATING")]
            STARBASEDRATING,
            
            /// <summary>
            /// Enum PROTECPROVIDER for "SC_PROTEC_PROVIDER"
            /// </summary>
            [EnumMember(Value = "SC_PROTEC_PROVIDER")]
            PROTECPROVIDER,
            
            /// <summary>
            /// Enum EQUIPMENT for "SC_EQUIPMENT"
            /// </summary>
            [EnumMember(Value = "SC_EQUIPMENT")]
            EQUIPMENT,
            
            /// <summary>
            /// Enum TYPEOFWORK for "SC_TYPE_OF_WORK"
            /// </summary>
            [EnumMember(Value = "SC_TYPE_OF_WORK")]
            TYPEOFWORK,
            
            /// <summary>
            /// Enum PHONEINTERVIEW for "SC_PHONE_INTERVIEW"
            /// </summary>
            [EnumMember(Value = "SC_PHONE_INTERVIEW")]
            PHONEINTERVIEW,
            
            /// <summary>
            /// Enum PHONECALLBUYER for "SC_PHONE_CALL_BUYER"
            /// </summary>
            [EnumMember(Value = "SC_PHONE_CALL_BUYER")]
            PHONECALLBUYER,
            
            /// <summary>
            /// Enum DISCLOSEADDRESS for "SC_DISCLOSE_ADDRESS"
            /// </summary>
            [EnumMember(Value = "SC_DISCLOSE_ADDRESS")]
            DISCLOSEADDRESS
        }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationEnum
        {
            
            /// <summary>
            /// Enum Equalto for "equal_to"
            /// </summary>
            [EnumMember(Value = "equal_to")]
            Equalto,
            
            /// <summary>
            /// Enum Greaterthan for "greater_than"
            /// </summary>
            [EnumMember(Value = "greater_than")]
            Greaterthan,
            
            /// <summary>
            /// Enum Lessthan for "less_than"
            /// </summary>
            [EnumMember(Value = "less_than")]
            Lessthan,
            
            /// <summary>
            /// Enum Notequalto for "not_equal_to"
            /// </summary>
            [EnumMember(Value = "not_equal_to")]
            Notequalto
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Nomatchoptional for "no_match_optional"
            /// </summary>
            [EnumMember(Value = "no_match_optional")]
            Nomatchoptional,
            
            /// <summary>
            /// Enum Nomatchrequired for "no_match_required"
            /// </summary>
            [EnumMember(Value = "no_match_required")]
            Nomatchrequired,
            
            /// <summary>
            /// Enum Match for "match"
            /// </summary>
            [EnumMember(Value = "match")]
            Match
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionRuleCriteria" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Service">Service.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Required">Required.</param>
        /// <param name="Weight">Weight.</param>
        /// <param name="Operation">Operation.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Order">Order.</param>
        /// <param name="CustomField">CustomField.</param>
        /// <param name="Extra">Extra.</param>
        public SelectionRuleCriteria(int? Id = default(int?), NameEnum? Name = default(NameEnum?), string Service = default(string), string Description = default(string), bool? Required = default(bool?), int? Weight = default(int?), OperationEnum? Operation = default(OperationEnum?), StatusEnum? Status = default(StatusEnum?), string Value = default(string), int? Order = default(int?), CustomField CustomField = default(CustomField), string Extra = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Service = Service;
            this.Description = Description;
            this.Required = Required;
            this.Weight = Weight;
            this.Operation = Operation;
            this.Status = Status;
            this.Value = Value;
            this.Order = Order;
            this.CustomField = CustomField;
            this.Extra = Extra;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }



        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets CustomField
        /// </summary>
        [DataMember(Name="custom_field", EmitDefaultValue=false)]
        public CustomField CustomField { get; set; }

        /// <summary>
        /// Gets or Sets Extra
        /// </summary>
        [DataMember(Name="extra", EmitDefaultValue=false)]
        public string Extra { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectionRuleCriteria {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
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
            return this.Equals(obj as SelectionRuleCriteria);
        }

        /// <summary>
        /// Returns true if SelectionRuleCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectionRuleCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectionRuleCriteria other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) && 
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.CustomField == other.CustomField ||
                    this.CustomField != null &&
                    this.CustomField.Equals(other.CustomField)
                ) && 
                (
                    this.Extra == other.Extra ||
                    this.Extra != null &&
                    this.Extra.Equals(other.Extra)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.CustomField != null)
                    hash = hash * 59 + this.CustomField.GetHashCode();
                if (this.Extra != null)
                    hash = hash * 59 + this.Extra.GetHashCode();
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
