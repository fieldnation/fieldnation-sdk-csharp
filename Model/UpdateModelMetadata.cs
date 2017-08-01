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
    /// UpdateModelMetadata
    /// </summary>
    [DataContract]
    public partial class UpdateModelMetadata :  IEquatable<UpdateModelMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelMetadata" /> class.
        /// </summary>
        /// <param name="UniversalContext">UniversalContext.</param>
        /// <param name="Data">Data.</param>
        public UpdateModelMetadata(UpdateModelMetadataUniversalContext UniversalContext = default(UpdateModelMetadataUniversalContext), UpdateModelMetadataData Data = default(UpdateModelMetadataData))
        {
            this.UniversalContext = UniversalContext;
            this.Data = Data;
        }
        
        /// <summary>
        /// Gets or Sets UniversalContext
        /// </summary>
        [DataMember(Name="universal_context", EmitDefaultValue=false)]
        public UpdateModelMetadataUniversalContext UniversalContext { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public UpdateModelMetadataData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateModelMetadata {\n");
            sb.Append("  UniversalContext: ").Append(UniversalContext).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as UpdateModelMetadata);
        }

        /// <summary>
        /// Returns true if UpdateModelMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateModelMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateModelMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UniversalContext == other.UniversalContext ||
                    this.UniversalContext != null &&
                    this.UniversalContext.Equals(other.UniversalContext)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                if (this.UniversalContext != null)
                    hash = hash * 59 + this.UniversalContext.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
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
