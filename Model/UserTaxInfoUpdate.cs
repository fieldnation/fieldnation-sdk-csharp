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
    /// UserTaxInfoUpdate
    /// </summary>
    [DataContract]
    public partial class UserTaxInfoUpdate :  IEquatable<UserTaxInfoUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTaxInfoUpdate" /> class.
        /// </summary>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Name">Name.</param>
        /// <param name="BusinessName">BusinessName.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="Other">Other.</param>
        /// <param name="Address1">Address1.</param>
        /// <param name="Address2">Address2.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip.</param>
        /// <param name="HasEin">HasEin.</param>
        /// <param name="Tin">Tin.</param>
        /// <param name="ElectronicConsent">ElectronicConsent.</param>
        /// <param name="HasSeparateTax">HasSeparateTax.</param>
        /// <param name="TechnicianW9StatusId">TechnicianW9StatusId.</param>
        /// <param name="CompanyId">CompanyId.</param>
        /// <param name="FromVendorBuyerInvite">FromVendorBuyerInvite.</param>
        /// <param name="BuyerCompanyId">BuyerCompanyId.</param>
        /// <param name="VendorCompanyId">VendorCompanyId.</param>
        public UserTaxInfoUpdate(string FirstName = default(string), string LastName = default(string), string Phone = default(string), string Name = default(string), string BusinessName = default(string), string EntityType = default(string), string Other = default(string), string Address1 = default(string), string Address2 = default(string), string City = default(string), string State = default(string), int? Zip = default(int?), int? HasEin = default(int?), string Tin = default(string), int? ElectronicConsent = default(int?), int? HasSeparateTax = default(int?), int? TechnicianW9StatusId = default(int?), int? CompanyId = default(int?), int? FromVendorBuyerInvite = default(int?), int? BuyerCompanyId = default(int?), int? VendorCompanyId = default(int?))
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Name = Name;
            this.BusinessName = BusinessName;
            this.EntityType = EntityType;
            this.Other = Other;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.HasEin = HasEin;
            this.Tin = Tin;
            this.ElectronicConsent = ElectronicConsent;
            this.HasSeparateTax = HasSeparateTax;
            this.TechnicianW9StatusId = TechnicianW9StatusId;
            this.CompanyId = CompanyId;
            this.FromVendorBuyerInvite = FromVendorBuyerInvite;
            this.BuyerCompanyId = BuyerCompanyId;
            this.VendorCompanyId = VendorCompanyId;
        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="business_name", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entity_type", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public int? Zip { get; set; }

        /// <summary>
        /// Gets or Sets HasEin
        /// </summary>
        [DataMember(Name="has_ein", EmitDefaultValue=false)]
        public int? HasEin { get; set; }

        /// <summary>
        /// Gets or Sets Tin
        /// </summary>
        [DataMember(Name="tin", EmitDefaultValue=false)]
        public string Tin { get; set; }

        /// <summary>
        /// Gets or Sets ElectronicConsent
        /// </summary>
        [DataMember(Name="electronic_consent", EmitDefaultValue=false)]
        public int? ElectronicConsent { get; set; }

        /// <summary>
        /// Gets or Sets HasSeparateTax
        /// </summary>
        [DataMember(Name="has_separate_tax", EmitDefaultValue=false)]
        public int? HasSeparateTax { get; set; }

        /// <summary>
        /// Gets or Sets TechnicianW9StatusId
        /// </summary>
        [DataMember(Name="technician_w9_status_id", EmitDefaultValue=false)]
        public int? TechnicianW9StatusId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets FromVendorBuyerInvite
        /// </summary>
        [DataMember(Name="from_vendor_buyer_invite", EmitDefaultValue=false)]
        public int? FromVendorBuyerInvite { get; set; }

        /// <summary>
        /// Gets or Sets BuyerCompanyId
        /// </summary>
        [DataMember(Name="buyer_company_id", EmitDefaultValue=false)]
        public int? BuyerCompanyId { get; set; }

        /// <summary>
        /// Gets or Sets VendorCompanyId
        /// </summary>
        [DataMember(Name="vendor_company_id", EmitDefaultValue=false)]
        public int? VendorCompanyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserTaxInfoUpdate {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  HasEin: ").Append(HasEin).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ElectronicConsent: ").Append(ElectronicConsent).Append("\n");
            sb.Append("  HasSeparateTax: ").Append(HasSeparateTax).Append("\n");
            sb.Append("  TechnicianW9StatusId: ").Append(TechnicianW9StatusId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  FromVendorBuyerInvite: ").Append(FromVendorBuyerInvite).Append("\n");
            sb.Append("  BuyerCompanyId: ").Append(BuyerCompanyId).Append("\n");
            sb.Append("  VendorCompanyId: ").Append(VendorCompanyId).Append("\n");
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
            return this.Equals(obj as UserTaxInfoUpdate);
        }

        /// <summary>
        /// Returns true if UserTaxInfoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of UserTaxInfoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTaxInfoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) && 
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) && 
                (
                    this.Other == other.Other ||
                    this.Other != null &&
                    this.Other.Equals(other.Other)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.HasEin == other.HasEin ||
                    this.HasEin != null &&
                    this.HasEin.Equals(other.HasEin)
                ) && 
                (
                    this.Tin == other.Tin ||
                    this.Tin != null &&
                    this.Tin.Equals(other.Tin)
                ) && 
                (
                    this.ElectronicConsent == other.ElectronicConsent ||
                    this.ElectronicConsent != null &&
                    this.ElectronicConsent.Equals(other.ElectronicConsent)
                ) && 
                (
                    this.HasSeparateTax == other.HasSeparateTax ||
                    this.HasSeparateTax != null &&
                    this.HasSeparateTax.Equals(other.HasSeparateTax)
                ) && 
                (
                    this.TechnicianW9StatusId == other.TechnicianW9StatusId ||
                    this.TechnicianW9StatusId != null &&
                    this.TechnicianW9StatusId.Equals(other.TechnicianW9StatusId)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.FromVendorBuyerInvite == other.FromVendorBuyerInvite ||
                    this.FromVendorBuyerInvite != null &&
                    this.FromVendorBuyerInvite.Equals(other.FromVendorBuyerInvite)
                ) && 
                (
                    this.BuyerCompanyId == other.BuyerCompanyId ||
                    this.BuyerCompanyId != null &&
                    this.BuyerCompanyId.Equals(other.BuyerCompanyId)
                ) && 
                (
                    this.VendorCompanyId == other.VendorCompanyId ||
                    this.VendorCompanyId != null &&
                    this.VendorCompanyId.Equals(other.VendorCompanyId)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();
                if (this.Other != null)
                    hash = hash * 59 + this.Other.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                if (this.HasEin != null)
                    hash = hash * 59 + this.HasEin.GetHashCode();
                if (this.Tin != null)
                    hash = hash * 59 + this.Tin.GetHashCode();
                if (this.ElectronicConsent != null)
                    hash = hash * 59 + this.ElectronicConsent.GetHashCode();
                if (this.HasSeparateTax != null)
                    hash = hash * 59 + this.HasSeparateTax.GetHashCode();
                if (this.TechnicianW9StatusId != null)
                    hash = hash * 59 + this.TechnicianW9StatusId.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.FromVendorBuyerInvite != null)
                    hash = hash * 59 + this.FromVendorBuyerInvite.GetHashCode();
                if (this.BuyerCompanyId != null)
                    hash = hash * 59 + this.BuyerCompanyId.GetHashCode();
                if (this.VendorCompanyId != null)
                    hash = hash * 59 + this.VendorCompanyId.GetHashCode();
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
