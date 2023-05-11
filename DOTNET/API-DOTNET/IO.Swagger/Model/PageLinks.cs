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
    /// Contains pagination links for the collection.
    /// </summary>
    [DataContract]
        public partial class PageLinks :  IEquatable<PageLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageLinks" /> class.
        /// </summary>
        /// <param name="first">Link to retrieve information in the first page of the collection..</param>
        /// <param name="last">Link to the retrieve information in the last page of the collection..</param>
        /// <param name="next">Link to retrieve information in the next page of the collection..</param>
        /// <param name="prev">Link to retrieve information in the previous page of the collection..</param>
        /// <param name="self">Link to retrieve information in the current page of the collection..</param>
        public PageLinks(string first = default(string), string last = default(string), string next = default(string), string prev = default(string), string self = default(string))
        {
            this.First = first;
            this.Last = last;
            this.Next = next;
            this.Prev = prev;
            this.Self = self;
        }
        
        /// <summary>
        /// Link to retrieve information in the first page of the collection.
        /// </summary>
        /// <value>Link to retrieve information in the first page of the collection.</value>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }

        /// <summary>
        /// Link to the retrieve information in the last page of the collection.
        /// </summary>
        /// <value>Link to the retrieve information in the last page of the collection.</value>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }

        /// <summary>
        /// Link to retrieve information in the next page of the collection.
        /// </summary>
        /// <value>Link to retrieve information in the next page of the collection.</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// Link to retrieve information in the previous page of the collection.
        /// </summary>
        /// <value>Link to retrieve information in the previous page of the collection.</value>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public string Prev { get; set; }

        /// <summary>
        /// Link to retrieve information in the current page of the collection.
        /// </summary>
        /// <value>Link to retrieve information in the current page of the collection.</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageLinks {\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
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
            return this.Equals(input as PageLinks);
        }

        /// <summary>
        /// Returns true if PageLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of PageLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
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
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.Prev != null)
                    hashCode = hashCode * 59 + this.Prev.GetHashCode();
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