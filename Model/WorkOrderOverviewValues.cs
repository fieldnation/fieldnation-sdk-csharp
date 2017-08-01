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
    /// WorkOrderOverviewValues
    /// </summary>
    [DataContract]
    public partial class WorkOrderOverviewValues :  IEquatable<WorkOrderOverviewValues>, IValidatableObject
    {

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
            /// Enum Servicecontracts for "service_contracts"
            /// </summary>
            [EnumMember(Value = "service_contracts")]
            Servicecontracts,
            
            /// <summary>
            /// Enum Networks for "networks"
            /// </summary>
            [EnumMember(Value = "networks")]
            Networks,
            
            /// <summary>
            /// Enum Teams for "teams"
            /// </summary>
            [EnumMember(Value = "teams")]
            Teams
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderOverviewValues" /> class.
        /// </summary>
        /// <param name="Actions">Actions.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="ProjectId">ProjectId.</param>
        /// <param name="ServiceContractId">ServiceContractId.</param>
        /// <param name="TypeOfWorkId">TypeOfWorkId.</param>
        /// <param name="NetworkId">NetworkId.</param>
        /// <param name="Clients">Clients.</param>
        /// <param name="Projects">Projects.</param>
        /// <param name="Networks">Networks.</param>
        /// <param name="ServiceContracts">ServiceContracts.</param>
        /// <param name="TypesOfWork">TypesOfWork.</param>
        /// <param name="Teams">Teams.</param>
        public WorkOrderOverviewValues(List<ActionsEnum> Actions = default(List<ActionsEnum>), int? TeamId = default(int?), int? ClientId = default(int?), int? ProjectId = default(int?), int? ServiceContractId = default(int?), int? TypeOfWorkId = default(int?), List<int?> NetworkId = default(List<int?>), List<WorkOrderOverviewValuesClients> Clients = default(List<WorkOrderOverviewValuesClients>), List<WorkOrderOverviewValuesClients> Projects = default(List<WorkOrderOverviewValuesClients>), List<WorkOrderOverviewValuesClients> Networks = default(List<WorkOrderOverviewValuesClients>), List<WorkOrderOverviewValuesClients> ServiceContracts = default(List<WorkOrderOverviewValuesClients>), List<WorkOrderOverviewValuesClients> TypesOfWork = default(List<WorkOrderOverviewValuesClients>), List<WorkOrderOverviewValuesClients> Teams = default(List<WorkOrderOverviewValuesClients>))
        {
            this.Actions = Actions;
            this.TeamId = TeamId;
            this.ClientId = ClientId;
            this.ProjectId = ProjectId;
            this.ServiceContractId = ServiceContractId;
            this.TypeOfWorkId = TypeOfWorkId;
            this.NetworkId = NetworkId;
            this.Clients = Clients;
            this.Projects = Projects;
            this.Networks = Networks;
            this.ServiceContracts = ServiceContracts;
            this.TypesOfWork = TypesOfWork;
            this.Teams = Teams;
        }
        

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="team_id", EmitDefaultValue=false)]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceContractId
        /// </summary>
        [DataMember(Name="service_contract_id", EmitDefaultValue=false)]
        public int? ServiceContractId { get; set; }

        /// <summary>
        /// Gets or Sets TypeOfWorkId
        /// </summary>
        [DataMember(Name="type_of_work_id", EmitDefaultValue=false)]
        public int? TypeOfWorkId { get; set; }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name="network_id", EmitDefaultValue=false)]
        public List<int?> NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets Clients
        /// </summary>
        [DataMember(Name="clients", EmitDefaultValue=false)]
        public List<WorkOrderOverviewValuesClients> Clients { get; set; }

        /// <summary>
        /// Gets or Sets Projects
        /// </summary>
        [DataMember(Name="projects", EmitDefaultValue=false)]
        public List<WorkOrderOverviewValuesClients> Projects { get; set; }

        /// <summary>
        /// Gets or Sets Networks
        /// </summary>
        [DataMember(Name="networks", EmitDefaultValue=false)]
        public List<WorkOrderOverviewValuesClients> Networks { get; set; }

        /// <summary>
        /// Gets or Sets ServiceContracts
        /// </summary>
        [DataMember(Name="service_contracts", EmitDefaultValue=false)]
        public List<WorkOrderOverviewValuesClients> ServiceContracts { get; set; }

        /// <summary>
        /// Gets or Sets TypesOfWork
        /// </summary>
        [DataMember(Name="types_of_work", EmitDefaultValue=false)]
        public List<WorkOrderOverviewValuesClients> TypesOfWork { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<WorkOrderOverviewValuesClients> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkOrderOverviewValues {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ServiceContractId: ").Append(ServiceContractId).Append("\n");
            sb.Append("  TypeOfWorkId: ").Append(TypeOfWorkId).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
            sb.Append("  Projects: ").Append(Projects).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
            sb.Append("  ServiceContracts: ").Append(ServiceContracts).Append("\n");
            sb.Append("  TypesOfWork: ").Append(TypesOfWork).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(obj as WorkOrderOverviewValues);
        }

        /// <summary>
        /// Returns true if WorkOrderOverviewValues instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkOrderOverviewValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkOrderOverviewValues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ProjectId == other.ProjectId ||
                    this.ProjectId != null &&
                    this.ProjectId.Equals(other.ProjectId)
                ) && 
                (
                    this.ServiceContractId == other.ServiceContractId ||
                    this.ServiceContractId != null &&
                    this.ServiceContractId.Equals(other.ServiceContractId)
                ) && 
                (
                    this.TypeOfWorkId == other.TypeOfWorkId ||
                    this.TypeOfWorkId != null &&
                    this.TypeOfWorkId.Equals(other.TypeOfWorkId)
                ) && 
                (
                    this.NetworkId == other.NetworkId ||
                    this.NetworkId != null &&
                    this.NetworkId.SequenceEqual(other.NetworkId)
                ) && 
                (
                    this.Clients == other.Clients ||
                    this.Clients != null &&
                    this.Clients.SequenceEqual(other.Clients)
                ) && 
                (
                    this.Projects == other.Projects ||
                    this.Projects != null &&
                    this.Projects.SequenceEqual(other.Projects)
                ) && 
                (
                    this.Networks == other.Networks ||
                    this.Networks != null &&
                    this.Networks.SequenceEqual(other.Networks)
                ) && 
                (
                    this.ServiceContracts == other.ServiceContracts ||
                    this.ServiceContracts != null &&
                    this.ServiceContracts.SequenceEqual(other.ServiceContracts)
                ) && 
                (
                    this.TypesOfWork == other.TypesOfWork ||
                    this.TypesOfWork != null &&
                    this.TypesOfWork.SequenceEqual(other.TypesOfWork)
                ) && 
                (
                    this.Teams == other.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(other.Teams)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.ProjectId != null)
                    hash = hash * 59 + this.ProjectId.GetHashCode();
                if (this.ServiceContractId != null)
                    hash = hash * 59 + this.ServiceContractId.GetHashCode();
                if (this.TypeOfWorkId != null)
                    hash = hash * 59 + this.TypeOfWorkId.GetHashCode();
                if (this.NetworkId != null)
                    hash = hash * 59 + this.NetworkId.GetHashCode();
                if (this.Clients != null)
                    hash = hash * 59 + this.Clients.GetHashCode();
                if (this.Projects != null)
                    hash = hash * 59 + this.Projects.GetHashCode();
                if (this.Networks != null)
                    hash = hash * 59 + this.Networks.GetHashCode();
                if (this.ServiceContracts != null)
                    hash = hash * 59 + this.ServiceContracts.GetHashCode();
                if (this.TypesOfWork != null)
                    hash = hash * 59 + this.TypesOfWork.GetHashCode();
                if (this.Teams != null)
                    hash = hash * 59 + this.Teams.GetHashCode();
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
