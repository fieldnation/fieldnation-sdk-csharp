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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Address">Address.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Created">Created.</param>
        /// <param name="WorkerCompensation">WorkerCompensation.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="Request">Request.</param>
        /// <param name="Route">Route.</param>
        /// <param name="Website">Website.</param>
        /// <param name="Coords">Coords.</param>
        /// <param name="Protec">Protec.</param>
        /// <param name="Marketplace">Marketplace.</param>
        /// <param name="Routable">Routable.</param>
        /// <param name="Assigned">Assigned.</param>
        /// <param name="Unassignable">Unassignable.</param>
        /// <param name="WorkOrder">WorkOrder.</param>
        /// <param name="PreviousRequest">PreviousRequest.</param>
        /// <param name="PreviousAssignment">PreviousAssignment.</param>
        /// <param name="BackgroundChecks">BackgroundChecks.</param>
        /// <param name="DrugTests">DrugTests.</param>
        /// <param name="UpcomingSchedule">UpcomingSchedule.</param>
        /// <param name="WorkedWith">WorkedWith.</param>
        /// <param name="Jobs">Jobs.</param>
        /// <param name="Managed">Managed.</param>
        /// <param name="Rating">Rating.</param>
        /// <param name="Company">Company.</param>
        /// <param name="_Client">_Client.</param>
        /// <param name="Role">Role.</param>
        /// <param name="LastActive">LastActive.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="PreferredGroups">PreferredGroups.</param>
        /// <param name="About">About.</param>
        /// <param name="Tagline">Tagline.</param>
        /// <param name="Block">Block.</param>
        /// <param name="TypesOfWork">TypesOfWork.</param>
        /// <param name="Experience">Experience.</param>
        /// <param name="Certifications">Certifications.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Licenses">Licenses.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Education">Education.</param>
        public User(int? Id = default(int?), string FirstName = default(string), string LastName = default(string), string Address = default(string), string City = default(string), string State = default(string), string Zip = default(string), string Country = default(string), string Thumbnail = default(string), DateTime? Created = default(DateTime?), bool? WorkerCompensation = default(bool?), TimeZone TimeZone = default(TimeZone), Request Request = default(Request), Route Route = default(Route), string Website = default(string), Coords Coords = default(Coords), bool? Protec = default(bool?), bool? Marketplace = default(bool?), bool? Routable = default(bool?), bool? Assigned = default(bool?), bool? Unassignable = default(bool?), WorkOrder WorkOrder = default(WorkOrder), UserPreviousRequest PreviousRequest = default(UserPreviousRequest), UserPreviousAssignment PreviousAssignment = default(UserPreviousAssignment), List<BackgroundCheck> BackgroundChecks = default(List<BackgroundCheck>), List<DrugTest> DrugTests = default(List<DrugTest>), List<UserUpcomingSchedule> UpcomingSchedule = default(List<UserUpcomingSchedule>), bool? WorkedWith = default(bool?), UserJobs Jobs = default(UserJobs), bool? Managed = default(bool?), UserRating Rating = default(UserRating), UserCompany Company = default(UserCompany), Company _Client = default(Company), string Role = default(string), DateTime? LastActive = default(DateTime?), string Email = default(string), string Phone = default(string), UserPreferredGroups PreferredGroups = default(UserPreferredGroups), string About = default(string), string Tagline = default(string), Block Block = default(Block), TypesOfWork TypesOfWork = default(TypesOfWork), Experiences Experience = default(Experiences), Certifications Certifications = default(Certifications), UserNotes Notes = default(UserNotes), Licenses Licenses = default(Licenses), string CorrelationId = default(string), Educations Education = default(Educations))
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
            this.Thumbnail = Thumbnail;
            this.Created = Created;
            this.WorkerCompensation = WorkerCompensation;
            this.TimeZone = TimeZone;
            this.Request = Request;
            this.Route = Route;
            this.Website = Website;
            this.Coords = Coords;
            this.Protec = Protec;
            this.Marketplace = Marketplace;
            this.Routable = Routable;
            this.Assigned = Assigned;
            this.Unassignable = Unassignable;
            this.WorkOrder = WorkOrder;
            this.PreviousRequest = PreviousRequest;
            this.PreviousAssignment = PreviousAssignment;
            this.BackgroundChecks = BackgroundChecks;
            this.DrugTests = DrugTests;
            this.UpcomingSchedule = UpcomingSchedule;
            this.WorkedWith = WorkedWith;
            this.Jobs = Jobs;
            this.Managed = Managed;
            this.Rating = Rating;
            this.Company = Company;
            this._Client = _Client;
            this.Role = Role;
            this.LastActive = LastActive;
            this.Email = Email;
            this.Phone = Phone;
            this.PreferredGroups = PreferredGroups;
            this.About = About;
            this.Tagline = Tagline;
            this.Block = Block;
            this.TypesOfWork = TypesOfWork;
            this.Experience = Experience;
            this.Certifications = Certifications;
            this.Notes = Notes;
            this.Licenses = Licenses;
            this.CorrelationId = CorrelationId;
            this.Education = Education;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

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
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

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
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets WorkerCompensation
        /// </summary>
        [DataMember(Name="worker_compensation", EmitDefaultValue=false)]
        public bool? WorkerCompensation { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public Request Request { get; set; }

        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public Route Route { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets Coords
        /// </summary>
        [DataMember(Name="coords", EmitDefaultValue=false)]
        public Coords Coords { get; set; }

        /// <summary>
        /// Gets or Sets Protec
        /// </summary>
        [DataMember(Name="protec", EmitDefaultValue=false)]
        public bool? Protec { get; set; }

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name="marketplace", EmitDefaultValue=false)]
        public bool? Marketplace { get; set; }

        /// <summary>
        /// Gets or Sets Routable
        /// </summary>
        [DataMember(Name="routable", EmitDefaultValue=false)]
        public bool? Routable { get; set; }

        /// <summary>
        /// Gets or Sets Assigned
        /// </summary>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public bool? Assigned { get; set; }

        /// <summary>
        /// Gets or Sets Unassignable
        /// </summary>
        [DataMember(Name="unassignable", EmitDefaultValue=false)]
        public bool? Unassignable { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrder
        /// </summary>
        [DataMember(Name="work_order", EmitDefaultValue=false)]
        public WorkOrder WorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets PreviousRequest
        /// </summary>
        [DataMember(Name="previous_request", EmitDefaultValue=false)]
        public UserPreviousRequest PreviousRequest { get; set; }

        /// <summary>
        /// Gets or Sets PreviousAssignment
        /// </summary>
        [DataMember(Name="previous_assignment", EmitDefaultValue=false)]
        public UserPreviousAssignment PreviousAssignment { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundChecks
        /// </summary>
        [DataMember(Name="background_checks", EmitDefaultValue=false)]
        public List<BackgroundCheck> BackgroundChecks { get; set; }

        /// <summary>
        /// Gets or Sets DrugTests
        /// </summary>
        [DataMember(Name="drug_tests", EmitDefaultValue=false)]
        public List<DrugTest> DrugTests { get; set; }

        /// <summary>
        /// Gets or Sets UpcomingSchedule
        /// </summary>
        [DataMember(Name="upcoming_schedule", EmitDefaultValue=false)]
        public List<UserUpcomingSchedule> UpcomingSchedule { get; set; }

        /// <summary>
        /// Gets or Sets WorkedWith
        /// </summary>
        [DataMember(Name="worked_with", EmitDefaultValue=false)]
        public bool? WorkedWith { get; set; }

        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public UserJobs Jobs { get; set; }

        /// <summary>
        /// Gets or Sets Managed
        /// </summary>
        [DataMember(Name="managed", EmitDefaultValue=false)]
        public bool? Managed { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public UserRating Rating { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public UserCompany Company { get; set; }

        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public Company _Client { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets LastActive
        /// </summary>
        [DataMember(Name="last_active", EmitDefaultValue=false)]
        public DateTime? LastActive { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PreferredGroups
        /// </summary>
        [DataMember(Name="preferred_groups", EmitDefaultValue=false)]
        public UserPreferredGroups PreferredGroups { get; set; }

        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name="about", EmitDefaultValue=false)]
        public string About { get; set; }

        /// <summary>
        /// Gets or Sets Tagline
        /// </summary>
        [DataMember(Name="tagline", EmitDefaultValue=false)]
        public string Tagline { get; set; }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public Block Block { get; set; }

        /// <summary>
        /// Gets or Sets TypesOfWork
        /// </summary>
        [DataMember(Name="types_of_work", EmitDefaultValue=false)]
        public TypesOfWork TypesOfWork { get; set; }

        /// <summary>
        /// Gets or Sets Experience
        /// </summary>
        [DataMember(Name="experience", EmitDefaultValue=false)]
        public Experiences Experience { get; set; }

        /// <summary>
        /// Gets or Sets Certifications
        /// </summary>
        [DataMember(Name="certifications", EmitDefaultValue=false)]
        public Certifications Certifications { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public UserNotes Notes { get; set; }

        /// <summary>
        /// Gets or Sets Licenses
        /// </summary>
        [DataMember(Name="licenses", EmitDefaultValue=false)]
        public Licenses Licenses { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Education
        /// </summary>
        [DataMember(Name="education", EmitDefaultValue=false)]
        public Educations Education { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  WorkerCompensation: ").Append(WorkerCompensation).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Coords: ").Append(Coords).Append("\n");
            sb.Append("  Protec: ").Append(Protec).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Routable: ").Append(Routable).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  Unassignable: ").Append(Unassignable).Append("\n");
            sb.Append("  WorkOrder: ").Append(WorkOrder).Append("\n");
            sb.Append("  PreviousRequest: ").Append(PreviousRequest).Append("\n");
            sb.Append("  PreviousAssignment: ").Append(PreviousAssignment).Append("\n");
            sb.Append("  BackgroundChecks: ").Append(BackgroundChecks).Append("\n");
            sb.Append("  DrugTests: ").Append(DrugTests).Append("\n");
            sb.Append("  UpcomingSchedule: ").Append(UpcomingSchedule).Append("\n");
            sb.Append("  WorkedWith: ").Append(WorkedWith).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  LastActive: ").Append(LastActive).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PreferredGroups: ").Append(PreferredGroups).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Tagline: ").Append(Tagline).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  TypesOfWork: ").Append(TypesOfWork).Append("\n");
            sb.Append("  Experience: ").Append(Experience).Append("\n");
            sb.Append("  Certifications: ").Append(Certifications).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Licenses: ").Append(Licenses).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
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
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.WorkerCompensation == other.WorkerCompensation ||
                    this.WorkerCompensation != null &&
                    this.WorkerCompensation.Equals(other.WorkerCompensation)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Request == other.Request ||
                    this.Request != null &&
                    this.Request.Equals(other.Request)
                ) && 
                (
                    this.Route == other.Route ||
                    this.Route != null &&
                    this.Route.Equals(other.Route)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Coords == other.Coords ||
                    this.Coords != null &&
                    this.Coords.Equals(other.Coords)
                ) && 
                (
                    this.Protec == other.Protec ||
                    this.Protec != null &&
                    this.Protec.Equals(other.Protec)
                ) && 
                (
                    this.Marketplace == other.Marketplace ||
                    this.Marketplace != null &&
                    this.Marketplace.Equals(other.Marketplace)
                ) && 
                (
                    this.Routable == other.Routable ||
                    this.Routable != null &&
                    this.Routable.Equals(other.Routable)
                ) && 
                (
                    this.Assigned == other.Assigned ||
                    this.Assigned != null &&
                    this.Assigned.Equals(other.Assigned)
                ) && 
                (
                    this.Unassignable == other.Unassignable ||
                    this.Unassignable != null &&
                    this.Unassignable.Equals(other.Unassignable)
                ) && 
                (
                    this.WorkOrder == other.WorkOrder ||
                    this.WorkOrder != null &&
                    this.WorkOrder.Equals(other.WorkOrder)
                ) && 
                (
                    this.PreviousRequest == other.PreviousRequest ||
                    this.PreviousRequest != null &&
                    this.PreviousRequest.Equals(other.PreviousRequest)
                ) && 
                (
                    this.PreviousAssignment == other.PreviousAssignment ||
                    this.PreviousAssignment != null &&
                    this.PreviousAssignment.Equals(other.PreviousAssignment)
                ) && 
                (
                    this.BackgroundChecks == other.BackgroundChecks ||
                    this.BackgroundChecks != null &&
                    this.BackgroundChecks.SequenceEqual(other.BackgroundChecks)
                ) && 
                (
                    this.DrugTests == other.DrugTests ||
                    this.DrugTests != null &&
                    this.DrugTests.SequenceEqual(other.DrugTests)
                ) && 
                (
                    this.UpcomingSchedule == other.UpcomingSchedule ||
                    this.UpcomingSchedule != null &&
                    this.UpcomingSchedule.SequenceEqual(other.UpcomingSchedule)
                ) && 
                (
                    this.WorkedWith == other.WorkedWith ||
                    this.WorkedWith != null &&
                    this.WorkedWith.Equals(other.WorkedWith)
                ) && 
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.Equals(other.Jobs)
                ) && 
                (
                    this.Managed == other.Managed ||
                    this.Managed != null &&
                    this.Managed.Equals(other.Managed)
                ) && 
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this._Client == other._Client ||
                    this._Client != null &&
                    this._Client.Equals(other._Client)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.LastActive == other.LastActive ||
                    this.LastActive != null &&
                    this.LastActive.Equals(other.LastActive)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.PreferredGroups == other.PreferredGroups ||
                    this.PreferredGroups != null &&
                    this.PreferredGroups.Equals(other.PreferredGroups)
                ) && 
                (
                    this.About == other.About ||
                    this.About != null &&
                    this.About.Equals(other.About)
                ) && 
                (
                    this.Tagline == other.Tagline ||
                    this.Tagline != null &&
                    this.Tagline.Equals(other.Tagline)
                ) && 
                (
                    this.Block == other.Block ||
                    this.Block != null &&
                    this.Block.Equals(other.Block)
                ) && 
                (
                    this.TypesOfWork == other.TypesOfWork ||
                    this.TypesOfWork != null &&
                    this.TypesOfWork.Equals(other.TypesOfWork)
                ) && 
                (
                    this.Experience == other.Experience ||
                    this.Experience != null &&
                    this.Experience.Equals(other.Experience)
                ) && 
                (
                    this.Certifications == other.Certifications ||
                    this.Certifications != null &&
                    this.Certifications.Equals(other.Certifications)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Licenses == other.Licenses ||
                    this.Licenses != null &&
                    this.Licenses.Equals(other.Licenses)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Education == other.Education ||
                    this.Education != null &&
                    this.Education.Equals(other.Education)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.WorkerCompensation != null)
                    hash = hash * 59 + this.WorkerCompensation.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Request != null)
                    hash = hash * 59 + this.Request.GetHashCode();
                if (this.Route != null)
                    hash = hash * 59 + this.Route.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Coords != null)
                    hash = hash * 59 + this.Coords.GetHashCode();
                if (this.Protec != null)
                    hash = hash * 59 + this.Protec.GetHashCode();
                if (this.Marketplace != null)
                    hash = hash * 59 + this.Marketplace.GetHashCode();
                if (this.Routable != null)
                    hash = hash * 59 + this.Routable.GetHashCode();
                if (this.Assigned != null)
                    hash = hash * 59 + this.Assigned.GetHashCode();
                if (this.Unassignable != null)
                    hash = hash * 59 + this.Unassignable.GetHashCode();
                if (this.WorkOrder != null)
                    hash = hash * 59 + this.WorkOrder.GetHashCode();
                if (this.PreviousRequest != null)
                    hash = hash * 59 + this.PreviousRequest.GetHashCode();
                if (this.PreviousAssignment != null)
                    hash = hash * 59 + this.PreviousAssignment.GetHashCode();
                if (this.BackgroundChecks != null)
                    hash = hash * 59 + this.BackgroundChecks.GetHashCode();
                if (this.DrugTests != null)
                    hash = hash * 59 + this.DrugTests.GetHashCode();
                if (this.UpcomingSchedule != null)
                    hash = hash * 59 + this.UpcomingSchedule.GetHashCode();
                if (this.WorkedWith != null)
                    hash = hash * 59 + this.WorkedWith.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.Managed != null)
                    hash = hash * 59 + this.Managed.GetHashCode();
                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this._Client != null)
                    hash = hash * 59 + this._Client.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.LastActive != null)
                    hash = hash * 59 + this.LastActive.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.PreferredGroups != null)
                    hash = hash * 59 + this.PreferredGroups.GetHashCode();
                if (this.About != null)
                    hash = hash * 59 + this.About.GetHashCode();
                if (this.Tagline != null)
                    hash = hash * 59 + this.Tagline.GetHashCode();
                if (this.Block != null)
                    hash = hash * 59 + this.Block.GetHashCode();
                if (this.TypesOfWork != null)
                    hash = hash * 59 + this.TypesOfWork.GetHashCode();
                if (this.Experience != null)
                    hash = hash * 59 + this.Experience.GetHashCode();
                if (this.Certifications != null)
                    hash = hash * 59 + this.Certifications.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Licenses != null)
                    hash = hash * 59 + this.Licenses.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Education != null)
                    hash = hash * 59 + this.Education.GetHashCode();
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
