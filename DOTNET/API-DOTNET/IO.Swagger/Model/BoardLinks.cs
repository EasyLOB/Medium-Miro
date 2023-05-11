/* 
 * Platform
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Contains applicable links for the board.
    /// </summary>
    [DataContract]
        public partial class BoardLinks :  IEquatable<BoardLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardLinks" /> class.
        /// </summary>
        /// <param name="related">Link to obtain information about the board members associated with the board..</param>
        /// <param name="self">Link to obtain information about the current board..</param>
        public BoardLinks(string related = default(string), string self = default(string))
        {
            this.Related = related;
            this.Self = self;
        }
        
        /// <summary>
        /// Link to obtain information about the board members associated with the board.
        /// </summary>
        /// <value>Link to obtain information about the board members associated with the board.</value>
        [DataMember(Name="related", EmitDefaultValue=false)]
        public string Related { get; set; }

        /// <summary>
        /// Link to obtain information about the current board.
        /// </summary>
        /// <value>Link to obtain information about the current board.</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoardLinks {\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BoardLinks);
        }

        /// <summary>
        /// Returns true if BoardLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Related == input.Related ||
                    (this.Related != null &&
                    this.Related.Equals(input.Related))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Related != null)
                    hashCode = hashCode * 59 + this.Related.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                return hashCode;
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
