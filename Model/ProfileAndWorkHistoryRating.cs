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
    /// ProfileAndWorkHistoryRating
    /// </summary>
    [DataContract]
    public partial class ProfileAndWorkHistoryRating :  IEquatable<ProfileAndWorkHistoryRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAndWorkHistoryRating" /> class.
        /// </summary>
        /// <param name="Profile">Profile.</param>
        /// <param name="WorkHistory">WorkHistory.</param>
        /// <param name="MoreResults">MoreResults.</param>
        public ProfileAndWorkHistoryRating(User Profile = default(User), WorkHistory WorkHistory = default(WorkHistory), bool? MoreResults = default(bool?))
        {
            this.Profile = Profile;
            this.WorkHistory = WorkHistory;
            this.MoreResults = MoreResults;
        }
        
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public User Profile { get; set; }

        /// <summary>
        /// Gets or Sets WorkHistory
        /// </summary>
        [DataMember(Name="work_history", EmitDefaultValue=false)]
        public WorkHistory WorkHistory { get; set; }

        /// <summary>
        /// Gets or Sets MoreResults
        /// </summary>
        [DataMember(Name="more_results", EmitDefaultValue=false)]
        public bool? MoreResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileAndWorkHistoryRating {\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  WorkHistory: ").Append(WorkHistory).Append("\n");
            sb.Append("  MoreResults: ").Append(MoreResults).Append("\n");
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
            return this.Equals(obj as ProfileAndWorkHistoryRating);
        }

        /// <summary>
        /// Returns true if ProfileAndWorkHistoryRating instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileAndWorkHistoryRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileAndWorkHistoryRating other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) && 
                (
                    this.WorkHistory == other.WorkHistory ||
                    this.WorkHistory != null &&
                    this.WorkHistory.Equals(other.WorkHistory)
                ) && 
                (
                    this.MoreResults == other.MoreResults ||
                    this.MoreResults != null &&
                    this.MoreResults.Equals(other.MoreResults)
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
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                if (this.WorkHistory != null)
                    hash = hash * 59 + this.WorkHistory.GetHashCode();
                if (this.MoreResults != null)
                    hash = hash * 59 + this.MoreResults.GetHashCode();
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
