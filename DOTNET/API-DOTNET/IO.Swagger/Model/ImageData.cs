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
    /// ImageData
    /// </summary>
    [DataContract]
        public partial class ImageData :  IEquatable<ImageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        /// <param name="imageUrl">The URL to download the resource. You must use your access token to access the URL.  The URL contains the &#x60;redirect&#x60; parameter and the &#x60;format&#x60; parameter to control the request execution as described in the following parameters: &#x60;format&#x60; parameter: By default, the image format is set to the preview image. If you want to download the original image, set the &#x60;format&#x60; parameter in the URL to &#x60;original&#x60;. &#x60;redirect&#x60;: By default, the &#x60;redirect&#x60; parameter is set to &#x60;false&#x60; and the resource object containing the URL and the resource type is returned with a 200 OK HTTP code. This URL is valid for 60 seconds. You can use this URL to retrieve the resource file. If the &#x60;redirect&#x60; parameter is set to &#x60;true&#x60;, a 307 TEMPORARY_REDIRECT HTTP response is returned. If you follow HTTP 3xx responses as redirects, you will automatically be redirected to the resource file and the content type returned can be &#x60;image/png&#x60;, &#x27;image/svg&#x27;, or &#x27;image/jpg&#x27;, depending on the original image type..</param>
        /// <param name="title">A short text header to identify the image..</param>
        public ImageData(string imageUrl = default(string), string title = default(string))
        {
            this.ImageUrl = imageUrl;
            this.Title = title;
        }
        
        /// <summary>
        /// The URL to download the resource. You must use your access token to access the URL.  The URL contains the &#x60;redirect&#x60; parameter and the &#x60;format&#x60; parameter to control the request execution as described in the following parameters: &#x60;format&#x60; parameter: By default, the image format is set to the preview image. If you want to download the original image, set the &#x60;format&#x60; parameter in the URL to &#x60;original&#x60;. &#x60;redirect&#x60;: By default, the &#x60;redirect&#x60; parameter is set to &#x60;false&#x60; and the resource object containing the URL and the resource type is returned with a 200 OK HTTP code. This URL is valid for 60 seconds. You can use this URL to retrieve the resource file. If the &#x60;redirect&#x60; parameter is set to &#x60;true&#x60;, a 307 TEMPORARY_REDIRECT HTTP response is returned. If you follow HTTP 3xx responses as redirects, you will automatically be redirected to the resource file and the content type returned can be &#x60;image/png&#x60;, &#x27;image/svg&#x27;, or &#x27;image/jpg&#x27;, depending on the original image type.
        /// </summary>
        /// <value>The URL to download the resource. You must use your access token to access the URL.  The URL contains the &#x60;redirect&#x60; parameter and the &#x60;format&#x60; parameter to control the request execution as described in the following parameters: &#x60;format&#x60; parameter: By default, the image format is set to the preview image. If you want to download the original image, set the &#x60;format&#x60; parameter in the URL to &#x60;original&#x60;. &#x60;redirect&#x60;: By default, the &#x60;redirect&#x60; parameter is set to &#x60;false&#x60; and the resource object containing the URL and the resource type is returned with a 200 OK HTTP code. This URL is valid for 60 seconds. You can use this URL to retrieve the resource file. If the &#x60;redirect&#x60; parameter is set to &#x60;true&#x60;, a 307 TEMPORARY_REDIRECT HTTP response is returned. If you follow HTTP 3xx responses as redirects, you will automatically be redirected to the resource file and the content type returned can be &#x60;image/png&#x60;, &#x27;image/svg&#x27;, or &#x27;image/jpg&#x27;, depending on the original image type.</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// A short text header to identify the image.
        /// </summary>
        /// <value>A short text header to identify the image.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageData {\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as ImageData);
        }

        /// <summary>
        /// Returns true if ImageData instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
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
