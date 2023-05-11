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
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Contains information about the embed URL.
    /// </summary>
    [DataContract]
        public partial class EmbedUrlData :  IEquatable<EmbedUrlData>, IValidatableObject
    {
        /// <summary>
        /// Defines how the content in the embed item is displayed on the board. &#x60;inline&#x60;: The embedded content is displayed directly on the board. &#x60;modal&#x60;: The embedded content is displayed inside a modal overlay on the board.
        /// </summary>
        /// <value>Defines how the content in the embed item is displayed on the board. &#x60;inline&#x60;: The embedded content is displayed directly on the board. &#x60;modal&#x60;: The embedded content is displayed inside a modal overlay on the board.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ModeEnum
        {
            /// <summary>
            /// Enum Inline for value: inline
            /// </summary>
            [EnumMember(Value = "inline")]
            Inline = 1,
            /// <summary>
            /// Enum Modal for value: modal
            /// </summary>
            [EnumMember(Value = "modal")]
            Modal = 2        }
        /// <summary>
        /// Defines how the content in the embed item is displayed on the board. &#x60;inline&#x60;: The embedded content is displayed directly on the board. &#x60;modal&#x60;: The embedded content is displayed inside a modal overlay on the board.
        /// </summary>
        /// <value>Defines how the content in the embed item is displayed on the board. &#x60;inline&#x60;: The embedded content is displayed directly on the board. &#x60;modal&#x60;: The embedded content is displayed inside a modal overlay on the board.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedUrlData" /> class.
        /// </summary>
        /// <param name="mode">Defines how the content in the embed item is displayed on the board. &#x60;inline&#x60;: The embedded content is displayed directly on the board. &#x60;modal&#x60;: The embedded content is displayed inside a modal overlay on the board..</param>
        /// <param name="previewUrl">URL of the image to be used as the preview image for the embedded item..</param>
        /// <param name="url">A [valid URL](https://developers.miro.com/reference/data#embeddata) pointing to the content resource that you want to embed in the board. Possible transport protocols: HTTP, HTTPS. (required) (default to &quot;https://www.youtube.com/watch?v&#x3D;HlVSNEiFCBk&quot;).</param>
        public EmbedUrlData(ModeEnum? mode = default(ModeEnum?), string previewUrl = default(string), string url = "https://www.youtube.com/watch?v=HlVSNEiFCBk")
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for EmbedUrlData and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            this.Mode = mode;
            this.PreviewUrl = previewUrl;
        }
        

        /// <summary>
        /// URL of the image to be used as the preview image for the embedded item.
        /// </summary>
        /// <value>URL of the image to be used as the preview image for the embedded item.</value>
        [DataMember(Name="previewUrl", EmitDefaultValue=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// A [valid URL](https://developers.miro.com/reference/data#embeddata) pointing to the content resource that you want to embed in the board. Possible transport protocols: HTTP, HTTPS.
        /// </summary>
        /// <value>A [valid URL](https://developers.miro.com/reference/data#embeddata) pointing to the content resource that you want to embed in the board. Possible transport protocols: HTTP, HTTPS.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbedUrlData {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  PreviewUrl: ").Append(PreviewUrl).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as EmbedUrlData);
        }

        /// <summary>
        /// Returns true if EmbedUrlData instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbedUrlData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbedUrlData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.PreviewUrl == input.PreviewUrl ||
                    (this.PreviewUrl != null &&
                    this.PreviewUrl.Equals(input.PreviewUrl))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.PreviewUrl != null)
                    hashCode = hashCode * 59 + this.PreviewUrl.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
