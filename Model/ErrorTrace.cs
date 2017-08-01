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
    /// ErrorTrace
    /// </summary>
    [DataContract]
    public partial class ErrorTrace :  IEquatable<ErrorTrace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorTrace" /> class.
        /// </summary>
        /// <param name="File">File.</param>
        /// <param name="Line">Line.</param>
        /// <param name="Function">Function.</param>
        /// <param name="_Class">_Class.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Args">Args.</param>
        public ErrorTrace(string File = default(string), int? Line = default(int?), string Function = default(string), string _Class = default(string), Object _Object = default(Object), string Type = default(string), List<ErrorTraceArgs> Args = default(List<ErrorTraceArgs>))
        {
            this.File = File;
            this.Line = Line;
            this.Function = Function;
            this._Class = _Class;
            this._Object = _Object;
            this.Type = Type;
            this.Args = Args;
        }
        
        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public int? Line { get; set; }

        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public string Function { get; set; }

        /// <summary>
        /// Gets or Sets _Class
        /// </summary>
        [DataMember(Name="class", EmitDefaultValue=false)]
        public string _Class { get; set; }

        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public Object _Object { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<ErrorTraceArgs> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorTrace {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  _Class: ").Append(_Class).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(obj as ErrorTrace);
        }

        /// <summary>
        /// Returns true if ErrorTrace instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorTrace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorTrace other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.File == other.File ||
                    this.File != null &&
                    this.File.Equals(other.File)
                ) && 
                (
                    this.Line == other.Line ||
                    this.Line != null &&
                    this.Line.Equals(other.Line)
                ) && 
                (
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
                ) && 
                (
                    this._Class == other._Class ||
                    this._Class != null &&
                    this._Class.Equals(other._Class)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Args == other.Args ||
                    this.Args != null &&
                    this.Args.SequenceEqual(other.Args)
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
                if (this.File != null)
                    hash = hash * 59 + this.File.GetHashCode();
                if (this.Line != null)
                    hash = hash * 59 + this.Line.GetHashCode();
                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();
                if (this._Class != null)
                    hash = hash * 59 + this._Class.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Args != null)
                    hash = hash * 59 + this.Args.GetHashCode();
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
