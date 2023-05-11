/* 
 * Platform
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The ending point of the connector. If startItem is also provided, endItem.id must be different from startItem.id
    /// </summary>
    [DataContract]
        public partial class ItemConnectionChangesData :  IEquatable<ItemConnectionChangesData>, IValidatableObject
    {
        /// <summary>
        /// The side of the item connector should be attached to, the connection point will be placed in the middle of that side. Option &#x60;auto&#x60; allows to pick a connection point automatically. Only either &#x60;position&#x60; or &#x60;snapTo&#x60; parameter is allowed to be set, if neither provided &#x60;snapTo: auto&#x60; will be used by default.
        /// </summary>
        /// <value>The side of the item connector should be attached to, the connection point will be placed in the middle of that side. Option &#x60;auto&#x60; allows to pick a connection point automatically. Only either &#x60;position&#x60; or &#x60;snapTo&#x60; parameter is allowed to be set, if neither provided &#x60;snapTo: auto&#x60; will be used by default.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SnapToEnum
        {
            /// <summary>
            /// Enum Auto for value: auto
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto = 1,
            /// <summary>
            /// Enum Top for value: top
            /// </summary>
            [EnumMember(Value = "top")]
            Top = 2,
            /// <summary>
            /// Enum Right for value: right
            /// </summary>
            [EnumMember(Value = "right")]
            Right = 3,
            /// <summary>
            /// Enum Bottom for value: bottom
            /// </summary>
            [EnumMember(Value = "bottom")]
            Bottom = 4,
            /// <summary>
            /// Enum Left for value: left
            /// </summary>
            [EnumMember(Value = "left")]
            Left = 5        }
        /// <summary>
        /// The side of the item connector should be attached to, the connection point will be placed in the middle of that side. Option &#x60;auto&#x60; allows to pick a connection point automatically. Only either &#x60;position&#x60; or &#x60;snapTo&#x60; parameter is allowed to be set, if neither provided &#x60;snapTo: auto&#x60; will be used by default.
        /// </summary>
        /// <value>The side of the item connector should be attached to, the connection point will be placed in the middle of that side. Option &#x60;auto&#x60; allows to pick a connection point automatically. Only either &#x60;position&#x60; or &#x60;snapTo&#x60; parameter is allowed to be set, if neither provided &#x60;snapTo: auto&#x60; will be used by default.</value>
        [DataMember(Name="snapTo", EmitDefaultValue=false)]
        public SnapToEnum? SnapTo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemConnectionChangesData" /> class.
        /// </summary>
        /// <param name="id">Unique identifier (ID) of the item to which you want to attach the connector. Note that Frames are not supported at the moment..</param>
        /// <param name="position">position.</param>
        /// <param name="snapTo">The side of the item connector should be attached to, the connection point will be placed in the middle of that side. Option &#x60;auto&#x60; allows to pick a connection point automatically. Only either &#x60;position&#x60; or &#x60;snapTo&#x60; parameter is allowed to be set, if neither provided &#x60;snapTo: auto&#x60; will be used by default..</param>
        public ItemConnectionChangesData(string id = default(string), RelativeOffset position = default(RelativeOffset), SnapToEnum? snapTo = default(SnapToEnum?))
        {
            this.Id = id;
            this.Position = position;
            this.SnapTo = snapTo;
        }
        
        /// <summary>
        /// Unique identifier (ID) of the item to which you want to attach the connector. Note that Frames are not supported at the moment.
        /// </summary>
        /// <value>Unique identifier (ID) of the item to which you want to attach the connector. Note that Frames are not supported at the moment.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public RelativeOffset Position { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemConnectionChangesData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SnapTo: ").Append(SnapTo).Append("\n");
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
            return this.Equals(input as ItemConnectionChangesData);
        }

        /// <summary>
        /// Returns true if ItemConnectionChangesData instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemConnectionChangesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemConnectionChangesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.SnapTo == input.SnapTo ||
                    (this.SnapTo != null &&
                    this.SnapTo.Equals(input.SnapTo))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.SnapTo != null)
                    hashCode = hashCode * 59 + this.SnapTo.GetHashCode();
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
