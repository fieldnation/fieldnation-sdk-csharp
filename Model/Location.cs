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
    /// Location
    /// </summary>
    [DataContract]
    public partial class Location :  IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            
            /// <summary>
            /// Enum Custom for "custom"
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom,
            
            /// <summary>
            /// Enum Remote for "remote"
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote,
            
            /// <summary>
            /// Enum Location for "location"
            /// </summary>
            [EnumMember(Value = "location")]
            Location
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
            /// Enum Map for "map"
            /// </summary>
            [EnumMember(Value = "map")]
            Map
        }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="WorkOrderId">WorkOrderId.</param>
        /// <param name="Mode">Mode.</param>
        /// <param name="Role">Role.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="StatusId">StatusId.</param>
        /// <param name="Address1">Address1.</param>
        /// <param name="Address2">Address2.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Coordinates">Coordinates.</param>
        /// <param name="Type">Type.</param>
        /// <param name="SaveLocation">SaveLocation.</param>
        /// <param name="SaveLocationGroup">SaveLocationGroup.</param>
        /// <param name="SavedLocation">SavedLocation.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="Contacts">Contacts.</param>
        /// <param name="Map">Map.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Validation">Validation.</param>
        public Location(int? WorkOrderId = default(int?), ModeEnum? Mode = default(ModeEnum?), string Role = default(string), List<ActionsEnum> Actions = default(List<ActionsEnum>), string CorrelationId = default(string), int? StatusId = default(int?), string Address1 = default(string), string Address2 = default(string), string City = default(string), string State = default(string), string Zip = default(string), string Country = default(string), Coords Coordinates = default(Coords), InlineResponse2002 Type = default(InlineResponse2002), string SaveLocation = default(string), int? SaveLocationGroup = default(int?), StoredLocation SavedLocation = default(StoredLocation), TimeZone TimeZone = default(TimeZone), List<Contact> Contacts = default(List<Contact>),
                        Dictionary<string, string> Map = null, LocationNotes Notes = default(LocationNotes), LocationValidation Validation = default(LocationValidation))
        {
            this.WorkOrderId = WorkOrderId;
            this.Mode = Mode;
            this.Role = Role;
            this.Actions = Actions;
            this.CorrelationId = CorrelationId;
            this.StatusId = StatusId;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
            this.Coordinates = Coordinates;
            this.Type = Type;
            this.SaveLocation = SaveLocation;
            this.SaveLocationGroup = SaveLocationGroup;
            this.SavedLocation = SavedLocation;
            this.TimeZone = TimeZone;
            this.Contacts = Contacts;
            this.Map = Map;
            this.Notes = Notes;
            this.Validation = Validation;
        }
        
        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name="work_order_id", EmitDefaultValue=false)]
        public int? WorkOrderId { get; set; }


        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }


        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name="status_id", EmitDefaultValue=false)]
        public int? StatusId { get; set; }

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
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="coordinates", EmitDefaultValue=false)]
        public Coords Coordinates { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public InlineResponse2002 Type { get; set; }

        /// <summary>
        /// Gets or Sets SaveLocation
        /// </summary>
        [DataMember(Name="save_location", EmitDefaultValue=false)]
        public string SaveLocation { get; set; }

        /// <summary>
        /// Gets or Sets SaveLocationGroup
        /// </summary>
        [DataMember(Name="save_location_group", EmitDefaultValue=false)]
        public int? SaveLocationGroup { get; set; }

        /// <summary>
        /// Gets or Sets SavedLocation
        /// </summary>
        [DataMember(Name="saved_location", EmitDefaultValue=false)]
        public StoredLocation SavedLocation { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [DataMember(Name="map", EmitDefaultValue=false)]
        public Dictionary<string, string> Map { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public LocationNotes Notes { get; set; }

        /// <summary>
        /// Gets or Sets Validation
        /// </summary>
        [DataMember(Name="validation", EmitDefaultValue=false)]
        public LocationValidation Validation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SaveLocation: ").Append(SaveLocation).Append("\n");
            sb.Append("  SaveLocationGroup: ").Append(SaveLocationGroup).Append("\n");
            sb.Append("  SavedLocation: ").Append(SavedLocation).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
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
            return this.Equals(obj as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="other">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location other)
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
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
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
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Coordinates == other.Coordinates ||
                    this.Coordinates != null &&
                    this.Coordinates.Equals(other.Coordinates)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SaveLocation == other.SaveLocation ||
                    this.SaveLocation != null &&
                    this.SaveLocation.Equals(other.SaveLocation)
                ) && 
                (
                    this.SaveLocationGroup == other.SaveLocationGroup ||
                    this.SaveLocationGroup != null &&
                    this.SaveLocationGroup.Equals(other.SaveLocationGroup)
                ) && 
                (
                    this.SavedLocation == other.SavedLocation ||
                    this.SavedLocation != null &&
                    this.SavedLocation.Equals(other.SavedLocation)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Contacts == other.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(other.Contacts)
                ) && 
                (
                    this.Map == other.Map ||
                    this.Map != null &&
                    this.Map.Equals(other.Map)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Validation == other.Validation ||
                    this.Validation != null &&
                    this.Validation.Equals(other.Validation)
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
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Coordinates != null)
                    hash = hash * 59 + this.Coordinates.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.SaveLocation != null)
                    hash = hash * 59 + this.SaveLocation.GetHashCode();
                if (this.SaveLocationGroup != null)
                    hash = hash * 59 + this.SaveLocationGroup.GetHashCode();
                if (this.SavedLocation != null)
                    hash = hash * 59 + this.SavedLocation.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Contacts != null)
                    hash = hash * 59 + this.Contacts.GetHashCode();
                if (this.Map != null)
                    hash = hash * 59 + this.Map.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Validation != null)
                    hash = hash * 59 + this.Validation.GetHashCode();
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
