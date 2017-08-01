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
    /// WorkOrder
    /// </summary>
    [DataContract]
    public partial class WorkOrder :  IEquatable<WorkOrder>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Setnetwork for "set_network"
            /// </summary>
            [EnumMember(Value = "set_network")]
            Setnetwork,
            
            /// <summary>
            /// Enum Withdrawrequest for "withdraw_request"
            /// </summary>
            [EnumMember(Value = "withdraw_request")]
            Withdrawrequest,
            
            /// <summary>
            /// Enum Confirm for "confirm"
            /// </summary>
            [EnumMember(Value = "confirm")]
            Confirm,
            
            /// <summary>
            /// Enum Messaging for "messaging"
            /// </summary>
            [EnumMember(Value = "messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Managed for "managed"
            /// </summary>
            [EnumMember(Value = "managed")]
            Managed,
            
            /// <summary>
            /// Enum Setmanaged for "set_managed"
            /// </summary>
            [EnumMember(Value = "set_managed")]
            Setmanaged,
            
            /// <summary>
            /// Enum Reportaproblem for "report_a_problem"
            /// </summary>
            [EnumMember(Value = "report_a_problem")]
            Reportaproblem,
            
            /// <summary>
            /// Enum Viewproblem for "view_problem"
            /// </summary>
            [EnumMember(Value = "view_problem")]
            Viewproblem,
            
            /// <summary>
            /// Enum Map for "map"
            /// </summary>
            [EnumMember(Value = "map")]
            Map,
            
            /// <summary>
            /// Enum Closingnotes for "closing_notes"
            /// </summary>
            [EnumMember(Value = "closing_notes")]
            Closingnotes,
            
            /// <summary>
            /// Enum Searchprovider for "search-provider"
            /// </summary>
            [EnumMember(Value = "search-provider")]
            Searchprovider,
            
            /// <summary>
            /// Enum History for "history"
            /// </summary>
            [EnumMember(Value = "history")]
            History,
            
            /// <summary>
            /// Enum Copy for "copy"
            /// </summary>
            [EnumMember(Value = "copy")]
            Copy,
            
            /// <summary>
            /// Enum Print for "print"
            /// </summary>
            [EnumMember(Value = "print")]
            Print,
            
            /// <summary>
            /// Enum Overview for "overview"
            /// </summary>
            [EnumMember(Value = "overview")]
            Overview,
            
            /// <summary>
            /// Enum Tasks for "tasks"
            /// </summary>
            [EnumMember(Value = "tasks")]
            Tasks,
            
            /// <summary>
            /// Enum Counteroffer for "counter_offer"
            /// </summary>
            [EnumMember(Value = "counter_offer")]
            Counteroffer,
            
            /// <summary>
            /// Enum Applytags for "apply_tags"
            /// </summary>
            [EnumMember(Value = "apply_tags")]
            Applytags,
            
            /// <summary>
            /// Enum Publish for "publish"
            /// </summary>
            [EnumMember(Value = "publish")]
            Publish,
            
            /// <summary>
            /// Enum Route for "route"
            /// </summary>
            [EnumMember(Value = "route")]
            Route,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete,
            
            /// <summary>
            /// Enum Hold for "hold"
            /// </summary>
            [EnumMember(Value = "hold")]
            Hold,
            
            /// <summary>
            /// Enum Cancel for "cancel"
            /// </summary>
            [EnumMember(Value = "cancel")]
            Cancel,
            
            /// <summary>
            /// Enum Unpublish for "unpublish"
            /// </summary>
            [EnumMember(Value = "unpublish")]
            Unpublish,
            
            /// <summary>
            /// Enum Revert for "revert"
            /// </summary>
            [EnumMember(Value = "revert")]
            Revert,
            
            /// <summary>
            /// Enum Approve for "approve"
            /// </summary>
            [EnumMember(Value = "approve")]
            Approve,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Incomplete for "incomplete"
            /// </summary>
            [EnumMember(Value = "incomplete")]
            Incomplete,
            
            /// <summary>
            /// Enum Request for "request"
            /// </summary>
            [EnumMember(Value = "request")]
            Request,
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Unapprove for "unapprove"
            /// </summary>
            [EnumMember(Value = "unapprove")]
            Unapprove
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrder" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Networks">Networks.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Printable">Printable.</param>
        /// <param name="AllowCounterOffers">AllowCounterOffers.</param>
        /// <param name="ClosingNotes">ClosingNotes.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Assignee">Assignee.</param>
        /// <param name="TypeOfWork">TypeOfWork.</param>
        /// <param name="Manager">Manager.</param>
        /// <param name="Template">Template.</param>
        /// <param name="Bundle">Bundle.</param>
        /// <param name="Project">Project.</param>
        /// <param name="Role">Role.</param>
        /// <param name="_Client">_Client.</param>
        /// <param name="Company">Company.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="TimeLogs">TimeLogs.</param>
        /// <param name="W2">W2.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="Eta">Eta.</param>
        /// <param name="Qualifications">Qualifications.</param>
        /// <param name="Signatures">Signatures.</param>
        /// <param name="Pay">Pay.</param>
        /// <param name="Contacts">Contacts.</param>
        /// <param name="Shipments">Shipments.</param>
        /// <param name="Attachments">Attachments.</param>
        /// <param name="Tasks">Tasks.</param>
        /// <param name="Messages">Messages.</param>
        /// <param name="Requests">Requests.</param>
        /// <param name="Routes">Routes.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Holds">Holds.</param>
        /// <param name="Milestones">Milestones.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Confidential">Confidential.</param>
        /// <param name="PolicyAndProcedures">PolicyAndProcedures.</param>
        /// <param name="StandardInstructions">StandardInstructions.</param>
        /// <param name="SelectionRule">SelectionRule.</param>
        /// <param name="Ratings">Ratings.</param>
        /// <param name="WorkflowCompletion">WorkflowCompletion.</param>
        /// <param name="PublishStats">PublishStats.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="ServiceContract">ServiceContract.</param>
        /// <param name="Team">Team.</param>
        /// <param name="ClientRequest">ClientRequest.</param>
        /// <param name="Integration">Integration.</param>
        /// <param name="Invoice">Invoice.</param>
        public WorkOrder(int? Id = default(int?), List<Network> Networks = default(List<Network>), string CorrelationId = default(string), bool? Printable = default(bool?), bool? AllowCounterOffers = default(bool?), string ClosingNotes = default(string), string Title = default(string), Assignee Assignee = default(Assignee), TypeOfWork TypeOfWork = default(TypeOfWork), Manager Manager = default(Manager), Template Template = default(Template), Bundle Bundle = default(Bundle), Project Project = default(Project), WorkOrderRole Role = default(WorkOrderRole), Company _Client = default(Company), Company Company = default(Company), CustomFields CustomFields = default(CustomFields), TimeLogs TimeLogs = default(TimeLogs), bool? W2 = default(bool?), Location Location = default(Location), Schedule Schedule = default(Schedule), ETA Eta = default(ETA), Qualifications Qualifications = default(Qualifications), Signatures Signatures = default(Signatures), Pay Pay = default(Pay), Contacts Contacts = default(Contacts), Shipments Shipments = default(Shipments), AttachmentFolders Attachments = default(AttachmentFolders), Tasks Tasks = default(Tasks), Messages Messages = default(Messages), Requests Requests = default(Requests), Routes Routes = default(Routes), Status Status = default(Status), Holds Holds = default(Holds), Milestones Milestones = default(Milestones), RichText Description = default(RichText), RichText Confidential = default(RichText), RichText PolicyAndProcedures = default(RichText), RichText StandardInstructions = default(RichText), SelectionRule SelectionRule = default(SelectionRule), WorkOrderRatings Ratings = default(WorkOrderRatings), WorkflowCompletion WorkflowCompletion = default(WorkflowCompletion), PublishStats PublishStats = default(PublishStats), List<ActionsEnum> Actions = default(List<ActionsEnum>), ServiceContract ServiceContract = default(ServiceContract), Team Team = default(Team), ClientRequest ClientRequest = default(ClientRequest), Integration Integration = default(Integration), WorkOrderInvoice Invoice = default(WorkOrderInvoice))
        {
            this.Id = Id;
            this.Networks = Networks;
            this.CorrelationId = CorrelationId;
            this.Printable = Printable;
            this.AllowCounterOffers = AllowCounterOffers;
            this.ClosingNotes = ClosingNotes;
            this.Title = Title;
            this.Assignee = Assignee;
            this.TypeOfWork = TypeOfWork;
            this.Manager = Manager;
            this.Template = Template;
            this.Bundle = Bundle;
            this.Project = Project;
            this.Role = Role;
            this._Client = _Client;
            this.Company = Company;
            this.CustomFields = CustomFields;
            this.TimeLogs = TimeLogs;
            this.W2 = W2;
            this.Location = Location;
            this.Schedule = Schedule;
            this.Eta = Eta;
            this.Qualifications = Qualifications;
            this.Signatures = Signatures;
            this.Pay = Pay;
            this.Contacts = Contacts;
            this.Shipments = Shipments;
            this.Attachments = Attachments;
            this.Tasks = Tasks;
            this.Messages = Messages;
            this.Requests = Requests;
            this.Routes = Routes;
            this.Status = Status;
            this.Holds = Holds;
            this.Milestones = Milestones;
            this.Description = Description;
            this.Confidential = Confidential;
            this.PolicyAndProcedures = PolicyAndProcedures;
            this.StandardInstructions = StandardInstructions;
            this.SelectionRule = SelectionRule;
            this.Ratings = Ratings;
            this.WorkflowCompletion = WorkflowCompletion;
            this.PublishStats = PublishStats;
            this.Actions = Actions;
            this.ServiceContract = ServiceContract;
            this.Team = Team;
            this.ClientRequest = ClientRequest;
            this.Integration = Integration;
            this.Invoice = Invoice;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Networks
        /// </summary>
        [DataMember(Name="networks", EmitDefaultValue=false)]
        public List<Network> Networks { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Printable
        /// </summary>
        [DataMember(Name="printable", EmitDefaultValue=false)]
        public bool? Printable { get; set; }

        /// <summary>
        /// Gets or Sets AllowCounterOffers
        /// </summary>
        [DataMember(Name="allow_counter_offers", EmitDefaultValue=false)]
        public bool? AllowCounterOffers { get; set; }

        /// <summary>
        /// Gets or Sets ClosingNotes
        /// </summary>
        [DataMember(Name="closing_notes", EmitDefaultValue=false)]
        public string ClosingNotes { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public Assignee Assignee { get; set; }

        /// <summary>
        /// Gets or Sets TypeOfWork
        /// </summary>
        [DataMember(Name="type_of_work", EmitDefaultValue=false)]
        public TypeOfWork TypeOfWork { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public Manager Manager { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public Template Template { get; set; }

        /// <summary>
        /// Gets or Sets Bundle
        /// </summary>
        [DataMember(Name="bundle", EmitDefaultValue=false)]
        public Bundle Bundle { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public Project Project { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public WorkOrderRole Role { get; set; }

        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public Company _Client { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets TimeLogs
        /// </summary>
        [DataMember(Name="time_logs", EmitDefaultValue=false)]
        public TimeLogs TimeLogs { get; set; }

        /// <summary>
        /// Gets or Sets W2
        /// </summary>
        [DataMember(Name="w2", EmitDefaultValue=false)]
        public bool? W2 { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }

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
        /// Gets or Sets Qualifications
        /// </summary>
        [DataMember(Name="qualifications", EmitDefaultValue=false)]
        public Qualifications Qualifications { get; set; }

        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        [DataMember(Name="signatures", EmitDefaultValue=false)]
        public Signatures Signatures { get; set; }

        /// <summary>
        /// Gets or Sets Pay
        /// </summary>
        [DataMember(Name="pay", EmitDefaultValue=false)]
        public Pay Pay { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public Contacts Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Shipments
        /// </summary>
        [DataMember(Name="shipments", EmitDefaultValue=false)]
        public Shipments Shipments { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public AttachmentFolders Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        public Tasks Tasks { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public Messages Messages { get; set; }

        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name="requests", EmitDefaultValue=false)]
        public Requests Requests { get; set; }

        /// <summary>
        /// Gets or Sets Routes
        /// </summary>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public Routes Routes { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or Sets Holds
        /// </summary>
        [DataMember(Name="holds", EmitDefaultValue=false)]
        public Holds Holds { get; set; }

        /// <summary>
        /// Gets or Sets Milestones
        /// </summary>
        [DataMember(Name="milestones", EmitDefaultValue=false)]
        public Milestones Milestones { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public RichText Description { get; set; }

        /// <summary>
        /// Gets or Sets Confidential
        /// </summary>
        [DataMember(Name="confidential", EmitDefaultValue=false)]
        public RichText Confidential { get; set; }

        /// <summary>
        /// Gets or Sets PolicyAndProcedures
        /// </summary>
        [DataMember(Name="policy_and_procedures", EmitDefaultValue=false)]
        public RichText PolicyAndProcedures { get; set; }

        /// <summary>
        /// Gets or Sets StandardInstructions
        /// </summary>
        [DataMember(Name="standard_instructions", EmitDefaultValue=false)]
        public RichText StandardInstructions { get; set; }

        /// <summary>
        /// Gets or Sets SelectionRule
        /// </summary>
        [DataMember(Name="selection_rule", EmitDefaultValue=false)]
        public SelectionRule SelectionRule { get; set; }

        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name="ratings", EmitDefaultValue=false)]
        public WorkOrderRatings Ratings { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowCompletion
        /// </summary>
        [DataMember(Name="workflow_completion", EmitDefaultValue=false)]
        public WorkflowCompletion WorkflowCompletion { get; set; }

        /// <summary>
        /// Gets or Sets PublishStats
        /// </summary>
        [DataMember(Name="publish_stats", EmitDefaultValue=false)]
        public PublishStats PublishStats { get; set; }


        /// <summary>
        /// Gets or Sets ServiceContract
        /// </summary>
        [DataMember(Name="service_contract", EmitDefaultValue=false)]
        public ServiceContract ServiceContract { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }

        /// <summary>
        /// Gets or Sets ClientRequest
        /// </summary>
        [DataMember(Name="client_request", EmitDefaultValue=false)]
        public ClientRequest ClientRequest { get; set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public Integration Integration { get; set; }

        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public WorkOrderInvoice Invoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Printable: ").Append(Printable).Append("\n");
            sb.Append("  AllowCounterOffers: ").Append(AllowCounterOffers).Append("\n");
            sb.Append("  ClosingNotes: ").Append(ClosingNotes).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  TypeOfWork: ").Append(TypeOfWork).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Bundle: ").Append(Bundle).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  TimeLogs: ").Append(TimeLogs).Append("\n");
            sb.Append("  W2: ").Append(W2).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
            sb.Append("  Qualifications: ").Append(Qualifications).Append("\n");
            sb.Append("  Signatures: ").Append(Signatures).Append("\n");
            sb.Append("  Pay: ").Append(Pay).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Holds: ").Append(Holds).Append("\n");
            sb.Append("  Milestones: ").Append(Milestones).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Confidential: ").Append(Confidential).Append("\n");
            sb.Append("  PolicyAndProcedures: ").Append(PolicyAndProcedures).Append("\n");
            sb.Append("  StandardInstructions: ").Append(StandardInstructions).Append("\n");
            sb.Append("  SelectionRule: ").Append(SelectionRule).Append("\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  WorkflowCompletion: ").Append(WorkflowCompletion).Append("\n");
            sb.Append("  PublishStats: ").Append(PublishStats).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  ServiceContract: ").Append(ServiceContract).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  ClientRequest: ").Append(ClientRequest).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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
            return this.Equals(obj as WorkOrder);
        }

        /// <summary>
        /// Returns true if WorkOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrder other)
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
                    this.Networks == other.Networks ||
                    this.Networks != null &&
                    this.Networks.SequenceEqual(other.Networks)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Printable == other.Printable ||
                    this.Printable != null &&
                    this.Printable.Equals(other.Printable)
                ) && 
                (
                    this.AllowCounterOffers == other.AllowCounterOffers ||
                    this.AllowCounterOffers != null &&
                    this.AllowCounterOffers.Equals(other.AllowCounterOffers)
                ) && 
                (
                    this.ClosingNotes == other.ClosingNotes ||
                    this.ClosingNotes != null &&
                    this.ClosingNotes.Equals(other.ClosingNotes)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Assignee == other.Assignee ||
                    this.Assignee != null &&
                    this.Assignee.Equals(other.Assignee)
                ) && 
                (
                    this.TypeOfWork == other.TypeOfWork ||
                    this.TypeOfWork != null &&
                    this.TypeOfWork.Equals(other.TypeOfWork)
                ) && 
                (
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Bundle == other.Bundle ||
                    this.Bundle != null &&
                    this.Bundle.Equals(other.Bundle)
                ) && 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this._Client == other._Client ||
                    this._Client != null &&
                    this._Client.Equals(other._Client)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.Equals(other.CustomFields)
                ) && 
                (
                    this.TimeLogs == other.TimeLogs ||
                    this.TimeLogs != null &&
                    this.TimeLogs.Equals(other.TimeLogs)
                ) && 
                (
                    this.W2 == other.W2 ||
                    this.W2 != null &&
                    this.W2.Equals(other.W2)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                    this.Qualifications == other.Qualifications ||
                    this.Qualifications != null &&
                    this.Qualifications.Equals(other.Qualifications)
                ) && 
                (
                    this.Signatures == other.Signatures ||
                    this.Signatures != null &&
                    this.Signatures.Equals(other.Signatures)
                ) && 
                (
                    this.Pay == other.Pay ||
                    this.Pay != null &&
                    this.Pay.Equals(other.Pay)
                ) && 
                (
                    this.Contacts == other.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.Equals(other.Contacts)
                ) && 
                (
                    this.Shipments == other.Shipments ||
                    this.Shipments != null &&
                    this.Shipments.Equals(other.Shipments)
                ) && 
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.Equals(other.Attachments)
                ) && 
                (
                    this.Tasks == other.Tasks ||
                    this.Tasks != null &&
                    this.Tasks.Equals(other.Tasks)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.Equals(other.Messages)
                ) && 
                (
                    this.Requests == other.Requests ||
                    this.Requests != null &&
                    this.Requests.Equals(other.Requests)
                ) && 
                (
                    this.Routes == other.Routes ||
                    this.Routes != null &&
                    this.Routes.Equals(other.Routes)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Holds == other.Holds ||
                    this.Holds != null &&
                    this.Holds.Equals(other.Holds)
                ) && 
                (
                    this.Milestones == other.Milestones ||
                    this.Milestones != null &&
                    this.Milestones.Equals(other.Milestones)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Confidential == other.Confidential ||
                    this.Confidential != null &&
                    this.Confidential.Equals(other.Confidential)
                ) && 
                (
                    this.PolicyAndProcedures == other.PolicyAndProcedures ||
                    this.PolicyAndProcedures != null &&
                    this.PolicyAndProcedures.Equals(other.PolicyAndProcedures)
                ) && 
                (
                    this.StandardInstructions == other.StandardInstructions ||
                    this.StandardInstructions != null &&
                    this.StandardInstructions.Equals(other.StandardInstructions)
                ) && 
                (
                    this.SelectionRule == other.SelectionRule ||
                    this.SelectionRule != null &&
                    this.SelectionRule.Equals(other.SelectionRule)
                ) && 
                (
                    this.Ratings == other.Ratings ||
                    this.Ratings != null &&
                    this.Ratings.Equals(other.Ratings)
                ) && 
                (
                    this.WorkflowCompletion == other.WorkflowCompletion ||
                    this.WorkflowCompletion != null &&
                    this.WorkflowCompletion.Equals(other.WorkflowCompletion)
                ) && 
                (
                    this.PublishStats == other.PublishStats ||
                    this.PublishStats != null &&
                    this.PublishStats.Equals(other.PublishStats)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.ServiceContract == other.ServiceContract ||
                    this.ServiceContract != null &&
                    this.ServiceContract.Equals(other.ServiceContract)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.ClientRequest == other.ClientRequest ||
                    this.ClientRequest != null &&
                    this.ClientRequest.Equals(other.ClientRequest)
                ) && 
                (
                    this.Integration == other.Integration ||
                    this.Integration != null &&
                    this.Integration.Equals(other.Integration)
                ) && 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
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
                if (this.Networks != null)
                    hash = hash * 59 + this.Networks.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Printable != null)
                    hash = hash * 59 + this.Printable.GetHashCode();
                if (this.AllowCounterOffers != null)
                    hash = hash * 59 + this.AllowCounterOffers.GetHashCode();
                if (this.ClosingNotes != null)
                    hash = hash * 59 + this.ClosingNotes.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Assignee != null)
                    hash = hash * 59 + this.Assignee.GetHashCode();
                if (this.TypeOfWork != null)
                    hash = hash * 59 + this.TypeOfWork.GetHashCode();
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.Bundle != null)
                    hash = hash * 59 + this.Bundle.GetHashCode();
                if (this.Project != null)
                    hash = hash * 59 + this.Project.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this._Client != null)
                    hash = hash * 59 + this._Client.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                if (this.TimeLogs != null)
                    hash = hash * 59 + this.TimeLogs.GetHashCode();
                if (this.W2 != null)
                    hash = hash * 59 + this.W2.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this.Eta != null)
                    hash = hash * 59 + this.Eta.GetHashCode();
                if (this.Qualifications != null)
                    hash = hash * 59 + this.Qualifications.GetHashCode();
                if (this.Signatures != null)
                    hash = hash * 59 + this.Signatures.GetHashCode();
                if (this.Pay != null)
                    hash = hash * 59 + this.Pay.GetHashCode();
                if (this.Contacts != null)
                    hash = hash * 59 + this.Contacts.GetHashCode();
                if (this.Shipments != null)
                    hash = hash * 59 + this.Shipments.GetHashCode();
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                if (this.Tasks != null)
                    hash = hash * 59 + this.Tasks.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                if (this.Requests != null)
                    hash = hash * 59 + this.Requests.GetHashCode();
                if (this.Routes != null)
                    hash = hash * 59 + this.Routes.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Holds != null)
                    hash = hash * 59 + this.Holds.GetHashCode();
                if (this.Milestones != null)
                    hash = hash * 59 + this.Milestones.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Confidential != null)
                    hash = hash * 59 + this.Confidential.GetHashCode();
                if (this.PolicyAndProcedures != null)
                    hash = hash * 59 + this.PolicyAndProcedures.GetHashCode();
                if (this.StandardInstructions != null)
                    hash = hash * 59 + this.StandardInstructions.GetHashCode();
                if (this.SelectionRule != null)
                    hash = hash * 59 + this.SelectionRule.GetHashCode();
                if (this.Ratings != null)
                    hash = hash * 59 + this.Ratings.GetHashCode();
                if (this.WorkflowCompletion != null)
                    hash = hash * 59 + this.WorkflowCompletion.GetHashCode();
                if (this.PublishStats != null)
                    hash = hash * 59 + this.PublishStats.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.ServiceContract != null)
                    hash = hash * 59 + this.ServiceContract.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.ClientRequest != null)
                    hash = hash * 59 + this.ClientRequest.GetHashCode();
                if (this.Integration != null)
                    hash = hash * 59 + this.Integration.GetHashCode();
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
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
