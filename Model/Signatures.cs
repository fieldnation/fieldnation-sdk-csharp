﻿/* 
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
    /// Signatures
    /// </summary>
    [DataContract]
    public partial class Signatures :  IEquatable<Signatures>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionsEnum
        {
            
            /// <summary>
            /// Enum Add for "add"
            /// </summary>
            [EnumMember(Value = "add")]
            Add
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signatures" /> class.
        /// </summary>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="Results">Results.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        public Signatures(ListEnvelope Metadata = default(ListEnvelope), List<ActionsEnum> Actions = default(List<ActionsEnum>), List<Signature> Results = default(List<Signature>), string CorrelationId = default(string))
        {
            this.Metadata = Metadata;
            this.Actions = Actions;
            this.Results = Results;
            this.CorrelationId = CorrelationId;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ListEnvelope Metadata { get; set; }


        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<Signature> Results { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlation_id", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signatures {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
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
            return this.Equals(obj as Signatures);
        }

        /// <summary>
        /// Returns true if Signatures instances are equal
        /// </summary>
        /// <param name="other">Instance of Signatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
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
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
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
