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
    /// Contains location information about the item, such as its x coordinate, y coordinate, and theorigin of the x and y coordinates.
    /// </summary>
    [DataContract]
        public partial class Position :  IEquatable<Position>, IValidatableObject
    {
        /// <summary>
        /// Area of the item that is referenced by its x and y coordinates. For example, an item with a center origin will have its x and y coordinates point to its center. The center point of the board has x: 0 and y: 0 coordinates. Currently, only one option is supported.
        /// </summary>
        /// <value>Area of the item that is referenced by its x and y coordinates. For example, an item with a center origin will have its x and y coordinates point to its center. The center point of the board has x: 0 and y: 0 coordinates. Currently, only one option is supported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OriginEnum
        {
            /// <summary>
            /// Enum Center for value: center
            /// </summary>
            [EnumMember(Value = "center")]
            Center = 1        }
        /// <summary>
        /// Area of the item that is referenced by its x and y coordinates. For example, an item with a center origin will have its x and y coordinates point to its center. The center point of the board has x: 0 and y: 0 coordinates. Currently, only one option is supported.
        /// </summary>
        /// <value>Area of the item that is referenced by its x and y coordinates. For example, an item with a center origin will have its x and y coordinates point to its center. The center point of the board has x: 0 and y: 0 coordinates. Currently, only one option is supported.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// Defines RelativeTo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RelativeToEnum
        {
            /// <summary>
            /// Enum Canvascenter for value: canvas_center
            /// </summary>
            [EnumMember(Value = "canvas_center")]
            Canvascenter = 1,
            /// <summary>
            /// Enum Parenttopleft for value: parent_top_left
            /// </summary>
            [EnumMember(Value = "parent_top_left")]
            Parenttopleft = 2        }
        /// <summary>
        /// Gets or Sets RelativeTo
        /// </summary>
        [DataMember(Name="relativeTo", EmitDefaultValue=false)]
        public RelativeToEnum? RelativeTo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Position" /> class.
        /// </summary>
        /// <param name="origin">Area of the item that is referenced by its x and y coordinates. For example, an item with a center origin will have its x and y coordinates point to its center. The center point of the board has x: 0 and y: 0 coordinates. Currently, only one option is supported. (default to OriginEnum.Center).</param>
        /// <param name="relativeTo">relativeTo.</param>
        /// <param name="x">X-axis coordinate of the location of the item on the board. By default, all items have absolute positioning to the board, not the current viewport. The center point of the board has &#x60;x: 0&#x60; and &#x60;y: 0&#x60; coordinates. (default to 0).</param>
        /// <param name="y">Y-axis coordinate of the location of the item on the board. By default, all items have absolute positioning to the board, not the current viewport. The center point of the board has &#x60;x: 0&#x60; and &#x60;y: 0&#x60; coordinates. (default to 0).</param>
        public Position(OriginEnum? origin = OriginEnum.Center, RelativeToEnum? relativeTo = default(RelativeToEnum?), double? x = 0, double? y = 0)
        {
            // use default value if no "origin" provided
            if (origin == null)
            {
                this.Origin = OriginEnum.Center;
            }
            else
            {
                this.Origin = origin;
            }
            this.RelativeTo = relativeTo;
            // use default value if no "x" provided
            if (x == null)
            {
                this.X = 0;
            }
            else
            {
                this.X = x;
            }
            // use default value if no "y" provided
            if (y == null)
            {
                this.Y = 0;
            }
            else
            {
                this.Y = y;
            }
        }
        


        /// <summary>
        /// X-axis coordinate of the location of the item on the board. By default, all items have absolute positioning to the board, not the current viewport. The center point of the board has &#x60;x: 0&#x60; and &#x60;y: 0&#x60; coordinates.
        /// </summary>
        /// <value>X-axis coordinate of the location of the item on the board. By default, all items have absolute positioning to the board, not the current viewport. The center point of the board has &#x60;x: 0&#x60; and &#x60;y: 0&#x60; coordinates.</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public double? X { get; set; }

        /// <summary>
        /// Y-axis coordinate of the location of the item on the board. By default, all items have absolute positioning to the board, not the current viewport. The center point of the board has &#x60;x: 0&#x60; and &#x60;y: 0&#x60; coordinates.
        /// </summary>
        /// <value>Y-axis coordinate of the location of the item on the board. By default, all items have absolute positioning to the board, not the current viewport. The center point of the board has &#x60;x: 0&#x60; and &#x60;y: 0&#x60; coordinates.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public double? Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Position {\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  RelativeTo: ").Append(RelativeTo).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as Position);
        }

        /// <summary>
        /// Returns true if Position instances are equal
        /// </summary>
        /// <param name="input">Instance of Position to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Position input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.RelativeTo == input.RelativeTo ||
                    (this.RelativeTo != null &&
                    this.RelativeTo.Equals(input.RelativeTo))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.RelativeTo != null)
                    hashCode = hashCode * 59 + this.RelativeTo.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
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
