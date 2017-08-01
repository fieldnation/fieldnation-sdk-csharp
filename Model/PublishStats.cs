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
    /// PublishStats
    /// </summary>
    [DataContract]
    public partial class PublishStats :  IEquatable<PublishStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishStats" /> class.
        /// </summary>
        /// <param name="Requests">Requests.</param>
        /// <param name="AllRequests">AllRequests.</param>
        /// <param name="CounterOffers">CounterOffers.</param>
        /// <param name="Routes">Routes.</param>
        /// <param name="Declines">Declines.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        public PublishStats(int? Requests = default(int?), int? AllRequests = default(int?), int? CounterOffers = default(int?), int? Routes = default(int?), int? Declines = default(int?), string CorrelationId = default(string))
        {
            this.Requests = Requests;
            this.AllRequests = AllRequests;
            this.CounterOffers = CounterOffers;
            this.Routes = Routes;
            this.Declines = Declines;
            this.CorrelationId = CorrelationId;
        }
        
        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name="requests", EmitDefaultValue=false)]
        public int? Requests { get; set; }

        /// <summary>
        /// Gets or Sets AllRequests
        /// </summary>
        [DataMember(Name="all_requests", EmitDefaultValue=false)]
        public int? AllRequests { get; set; }

        /// <summary>
        /// Gets or Sets CounterOffers
        /// </summary>
        [DataMember(Name="counter_offers", EmitDefaultValue=false)]
        public int? CounterOffers { get; set; }

        /// <summary>
        /// Gets or Sets Routes
        /// </summary>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public int? Routes { get; set; }

        /// <summary>
        /// Gets or Sets Declines
        /// </summary>
        [DataMember(Name="declines", EmitDefaultValue=false)]
        public int? Declines { get; set; }

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
            sb.Append("class PublishStats {\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  AllRequests: ").Append(AllRequests).Append("\n");
            sb.Append("  CounterOffers: ").Append(CounterOffers).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Declines: ").Append(Declines).Append("\n");
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
            return this.Equals(obj as PublishStats);
        }

        /// <summary>
        /// Returns true if PublishStats instances are equal
        /// </summary>
        /// <param name="other">Instance of PublishStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Requests == other.Requests ||
                    this.Requests != null &&
                    this.Requests.Equals(other.Requests)
                ) && 
                (
                    this.AllRequests == other.AllRequests ||
                    this.AllRequests != null &&
                    this.AllRequests.Equals(other.AllRequests)
                ) && 
                (
                    this.CounterOffers == other.CounterOffers ||
                    this.CounterOffers != null &&
                    this.CounterOffers.Equals(other.CounterOffers)
                ) && 
                (
                    this.Routes == other.Routes ||
                    this.Routes != null &&
                    this.Routes.Equals(other.Routes)
                ) && 
                (
                    this.Declines == other.Declines ||
                    this.Declines != null &&
                    this.Declines.Equals(other.Declines)
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
                if (this.Requests != null)
                    hash = hash * 59 + this.Requests.GetHashCode();
                if (this.AllRequests != null)
                    hash = hash * 59 + this.AllRequests.GetHashCode();
                if (this.CounterOffers != null)
                    hash = hash * 59 + this.CounterOffers.GetHashCode();
                if (this.Routes != null)
                    hash = hash * 59 + this.Routes.GetHashCode();
                if (this.Declines != null)
                    hash = hash * 59 + this.Declines.GetHashCode();
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
