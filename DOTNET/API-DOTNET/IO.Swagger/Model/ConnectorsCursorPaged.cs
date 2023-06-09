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
    /// ConnectorsCursorPaged
    /// </summary>
    [DataContract]
        public partial class ConnectorsCursorPaged :  IEquatable<ConnectorsCursorPaged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsCursorPaged" /> class.
        /// </summary>
        /// <param name="cursor">A cursor-paginated method returns a portion of the total set of results based on the &#x60;limit&#x60; specified and a &#x60;cursor&#x60; that points to the next portion of the results. To retrieve the next set of results of the collection, set the &#x60;cursor&#x60; parameter in your next request to the value returned in this parameter..</param>
        /// <param name="data">Contains the result data..</param>
        /// <param name="limit">Maximum number of results returned based on the &#x60;limit&#x60; specified in the request. For example, if there are &#x60;20&#x60; results, the request has no &#x60;cursor&#x60; value, and the &#x60;limit&#x60; is set to &#x60;20&#x60;,the &#x60;size&#x60; of the results will be &#x60;20&#x60;. The rest of the results will not be returned. To retrieve the rest of the results, you must make another request and set the appropriate value for the &#x60;cursor&#x60; parameter value that you obtained from the response..</param>
        /// <param name="links">links.</param>
        /// <param name="size">Number of results returned in the response considering the &#x60;cursor&#x60; and the &#x60;limit&#x60; values sent in the request. For example, if there are &#x60;20&#x60; results, the request does not have a &#x60;cursor&#x60; value, and the &#x60;limit&#x60; set to &#x60;10&#x60;, the &#x60;size&#x60; of the results will be &#x60;10&#x60;.&lt;br&gt;In this example, the response will also return a cursor value that can be used to retrieve the next set of 10 remaining results in the collection..</param>
        /// <param name="total">total.</param>
        public ConnectorsCursorPaged(string cursor = default(string), List<ConnectorWithLinks> data = default(List<ConnectorWithLinks>), int? limit = default(int?), PageLinks links = default(PageLinks), int? size = default(int?), long? total = default(long?))
        {
            this.Cursor = cursor;
            this.Data = data;
            this.Limit = limit;
            this.Links = links;
            this.Size = size;
            this.Total = total;
        }
        
        /// <summary>
        /// A cursor-paginated method returns a portion of the total set of results based on the &#x60;limit&#x60; specified and a &#x60;cursor&#x60; that points to the next portion of the results. To retrieve the next set of results of the collection, set the &#x60;cursor&#x60; parameter in your next request to the value returned in this parameter.
        /// </summary>
        /// <value>A cursor-paginated method returns a portion of the total set of results based on the &#x60;limit&#x60; specified and a &#x60;cursor&#x60; that points to the next portion of the results. To retrieve the next set of results of the collection, set the &#x60;cursor&#x60; parameter in your next request to the value returned in this parameter.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Contains the result data.
        /// </summary>
        /// <value>Contains the result data.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<ConnectorWithLinks> Data { get; set; }

        /// <summary>
        /// Maximum number of results returned based on the &#x60;limit&#x60; specified in the request. For example, if there are &#x60;20&#x60; results, the request has no &#x60;cursor&#x60; value, and the &#x60;limit&#x60; is set to &#x60;20&#x60;,the &#x60;size&#x60; of the results will be &#x60;20&#x60;. The rest of the results will not be returned. To retrieve the rest of the results, you must make another request and set the appropriate value for the &#x60;cursor&#x60; parameter value that you obtained from the response.
        /// </summary>
        /// <value>Maximum number of results returned based on the &#x60;limit&#x60; specified in the request. For example, if there are &#x60;20&#x60; results, the request has no &#x60;cursor&#x60; value, and the &#x60;limit&#x60; is set to &#x60;20&#x60;,the &#x60;size&#x60; of the results will be &#x60;20&#x60;. The rest of the results will not be returned. To retrieve the rest of the results, you must make another request and set the appropriate value for the &#x60;cursor&#x60; parameter value that you obtained from the response.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public PageLinks Links { get; set; }

        /// <summary>
        /// Number of results returned in the response considering the &#x60;cursor&#x60; and the &#x60;limit&#x60; values sent in the request. For example, if there are &#x60;20&#x60; results, the request does not have a &#x60;cursor&#x60; value, and the &#x60;limit&#x60; set to &#x60;10&#x60;, the &#x60;size&#x60; of the results will be &#x60;10&#x60;.&lt;br&gt;In this example, the response will also return a cursor value that can be used to retrieve the next set of 10 remaining results in the collection.
        /// </summary>
        /// <value>Number of results returned in the response considering the &#x60;cursor&#x60; and the &#x60;limit&#x60; values sent in the request. For example, if there are &#x60;20&#x60; results, the request does not have a &#x60;cursor&#x60; value, and the &#x60;limit&#x60; set to &#x60;10&#x60;, the &#x60;size&#x60; of the results will be &#x60;10&#x60;.&lt;br&gt;In this example, the response will also return a cursor value that can be used to retrieve the next set of 10 remaining results in the collection.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorsCursorPaged {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as ConnectorsCursorPaged);
        }

        /// <summary>
        /// Returns true if ConnectorsCursorPaged instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorsCursorPaged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorsCursorPaged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Cursor != null)
                    hashCode = hashCode * 59 + this.Cursor.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
