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
    /// Contains app card item data, such as the title, description, or fields.
    /// </summary>
    [DataContract]
        public partial class AppCardData :  IEquatable<AppCardData>, IValidatableObject
    {
        /// <summary>
        /// Status indicating whether an app card is connected and in sync with the source. When the source for the app card is deleted, the status returns &#x60;disabled&#x60;.
        /// </summary>
        /// <value>Status indicating whether an app card is connected and in sync with the source. When the source for the app card is deleted, the status returns &#x60;disabled&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Disconnected for value: disconnected
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected = 1,
            /// <summary>
            /// Enum Connected for value: connected
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected = 2,
            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 3        }
        /// <summary>
        /// Status indicating whether an app card is connected and in sync with the source. When the source for the app card is deleted, the status returns &#x60;disabled&#x60;.
        /// </summary>
        /// <value>Status indicating whether an app card is connected and in sync with the source. When the source for the app card is deleted, the status returns &#x60;disabled&#x60;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCardData" /> class.
        /// </summary>
        /// <param name="description">A short text description to add context about the app card..</param>
        /// <param name="fields">Array where each object represents a custom preview field. Preview fields are displayed on the bottom half of the app card in the compact view..</param>
        /// <param name="owned">Defines whether the card is owned by the application making the call..</param>
        /// <param name="status">Status indicating whether an app card is connected and in sync with the source. When the source for the app card is deleted, the status returns &#x60;disabled&#x60;..</param>
        /// <param name="title">A short text header to identify the app card..</param>
        public AppCardData(string description = default(string), List<CustomField> fields = default(List<CustomField>), bool? owned = default(bool?), StatusEnum? status = default(StatusEnum?), string title = default(string))
        {
            this.Description = description;
            this.Fields = fields;
            this.Owned = owned;
            this.Status = status;
            this.Title = title;
        }
        
        /// <summary>
        /// A short text description to add context about the app card.
        /// </summary>
        /// <value>A short text description to add context about the app card.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Array where each object represents a custom preview field. Preview fields are displayed on the bottom half of the app card in the compact view.
        /// </summary>
        /// <value>Array where each object represents a custom preview field. Preview fields are displayed on the bottom half of the app card in the compact view.</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<CustomField> Fields { get; set; }

        /// <summary>
        /// Defines whether the card is owned by the application making the call.
        /// </summary>
        /// <value>Defines whether the card is owned by the application making the call.</value>
        [DataMember(Name="owned", EmitDefaultValue=false)]
        public bool? Owned { get; set; }


        /// <summary>
        /// A short text header to identify the app card.
        /// </summary>
        /// <value>A short text header to identify the app card.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCardData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Owned: ").Append(Owned).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AppCardData);
        }

        /// <summary>
        /// Returns true if AppCardData instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCardData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCardData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Owned == input.Owned ||
                    (this.Owned != null &&
                    this.Owned.Equals(input.Owned))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Owned != null)
                    hashCode = hashCode * 59 + this.Owned.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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