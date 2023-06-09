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
    /// Contains information about the style of a text item, such as the fill color or font family.
    /// </summary>
    [DataContract]
        public partial class TextStyle :  IEquatable<TextStyle>, IValidatableObject
    {
        /// <summary>
        /// Font type for the text in the text item. Default: &#x60;arial&#x60;.
        /// </summary>
        /// <value>Font type for the text in the text item. Default: &#x60;arial&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FontFamilyEnum
        {
            /// <summary>
            /// Enum Arial for value: arial
            /// </summary>
            [EnumMember(Value = "arial")]
            Arial = 1,
            /// <summary>
            /// Enum Abrilfatface for value: abril_fatface
            /// </summary>
            [EnumMember(Value = "abril_fatface")]
            Abrilfatface = 2,
            /// <summary>
            /// Enum Bangers for value: bangers
            /// </summary>
            [EnumMember(Value = "bangers")]
            Bangers = 3,
            /// <summary>
            /// Enum Ebgaramond for value: eb_garamond
            /// </summary>
            [EnumMember(Value = "eb_garamond")]
            Ebgaramond = 4,
            /// <summary>
            /// Enum Georgia for value: georgia
            /// </summary>
            [EnumMember(Value = "georgia")]
            Georgia = 5,
            /// <summary>
            /// Enum Graduate for value: graduate
            /// </summary>
            [EnumMember(Value = "graduate")]
            Graduate = 6,
            /// <summary>
            /// Enum Gravitasone for value: gravitas_one
            /// </summary>
            [EnumMember(Value = "gravitas_one")]
            Gravitasone = 7,
            /// <summary>
            /// Enum Fredokaone for value: fredoka_one
            /// </summary>
            [EnumMember(Value = "fredoka_one")]
            Fredokaone = 8,
            /// <summary>
            /// Enum Nixieone for value: nixie_one
            /// </summary>
            [EnumMember(Value = "nixie_one")]
            Nixieone = 9,
            /// <summary>
            /// Enum Opensans for value: open_sans
            /// </summary>
            [EnumMember(Value = "open_sans")]
            Opensans = 10,
            /// <summary>
            /// Enum Permanentmarker for value: permanent_marker
            /// </summary>
            [EnumMember(Value = "permanent_marker")]
            Permanentmarker = 11,
            /// <summary>
            /// Enum Ptsans for value: pt_sans
            /// </summary>
            [EnumMember(Value = "pt_sans")]
            Ptsans = 12,
            /// <summary>
            /// Enum Ptsansnarrow for value: pt_sans_narrow
            /// </summary>
            [EnumMember(Value = "pt_sans_narrow")]
            Ptsansnarrow = 13,
            /// <summary>
            /// Enum Ptserif for value: pt_serif
            /// </summary>
            [EnumMember(Value = "pt_serif")]
            Ptserif = 14,
            /// <summary>
            /// Enum Rammettoone for value: rammetto_one
            /// </summary>
            [EnumMember(Value = "rammetto_one")]
            Rammettoone = 15,
            /// <summary>
            /// Enum Roboto for value: roboto
            /// </summary>
            [EnumMember(Value = "roboto")]
            Roboto = 16,
            /// <summary>
            /// Enum Robotocondensed for value: roboto_condensed
            /// </summary>
            [EnumMember(Value = "roboto_condensed")]
            Robotocondensed = 17,
            /// <summary>
            /// Enum Robotoslab for value: roboto_slab
            /// </summary>
            [EnumMember(Value = "roboto_slab")]
            Robotoslab = 18,
            /// <summary>
            /// Enum Caveat for value: caveat
            /// </summary>
            [EnumMember(Value = "caveat")]
            Caveat = 19,
            /// <summary>
            /// Enum Timesnewroman for value: times_new_roman
            /// </summary>
            [EnumMember(Value = "times_new_roman")]
            Timesnewroman = 20,
            /// <summary>
            /// Enum Titanone for value: titan_one
            /// </summary>
            [EnumMember(Value = "titan_one")]
            Titanone = 21,
            /// <summary>
            /// Enum Lemontuesday for value: lemon_tuesday
            /// </summary>
            [EnumMember(Value = "lemon_tuesday")]
            Lemontuesday = 22,
            /// <summary>
            /// Enum Robotomono for value: roboto_mono
            /// </summary>
            [EnumMember(Value = "roboto_mono")]
            Robotomono = 23,
            /// <summary>
            /// Enum Notosans for value: noto_sans
            /// </summary>
            [EnumMember(Value = "noto_sans")]
            Notosans = 24,
            /// <summary>
            /// Enum Plexsans for value: plex_sans
            /// </summary>
            [EnumMember(Value = "plex_sans")]
            Plexsans = 25,
            /// <summary>
            /// Enum Plexserif for value: plex_serif
            /// </summary>
            [EnumMember(Value = "plex_serif")]
            Plexserif = 26,
            /// <summary>
            /// Enum Plexmono for value: plex_mono
            /// </summary>
            [EnumMember(Value = "plex_mono")]
            Plexmono = 27,
            /// <summary>
            /// Enum Spoof for value: spoof
            /// </summary>
            [EnumMember(Value = "spoof")]
            Spoof = 28,
            /// <summary>
            /// Enum Tiempostext for value: tiempos_text
            /// </summary>
            [EnumMember(Value = "tiempos_text")]
            Tiempostext = 29,
            /// <summary>
            /// Enum Formular for value: formular
            /// </summary>
            [EnumMember(Value = "formular")]
            Formular = 30        }
        /// <summary>
        /// Font type for the text in the text item. Default: &#x60;arial&#x60;.
        /// </summary>
        /// <value>Font type for the text in the text item. Default: &#x60;arial&#x60;.</value>
        [DataMember(Name="fontFamily", EmitDefaultValue=false)]
        public FontFamilyEnum? FontFamily { get; set; }
        /// <summary>
        /// Horizontal alignment for the item&#x27;s content. Default: &#x60;center.&#x60;
        /// </summary>
        /// <value>Horizontal alignment for the item&#x27;s content. Default: &#x60;center.&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TextAlignEnum
        {
            /// <summary>
            /// Enum Left for value: left
            /// </summary>
            [EnumMember(Value = "left")]
            Left = 1,
            /// <summary>
            /// Enum Right for value: right
            /// </summary>
            [EnumMember(Value = "right")]
            Right = 2,
            /// <summary>
            /// Enum Center for value: center
            /// </summary>
            [EnumMember(Value = "center")]
            Center = 3        }
        /// <summary>
        /// Horizontal alignment for the item&#x27;s content. Default: &#x60;center.&#x60;
        /// </summary>
        /// <value>Horizontal alignment for the item&#x27;s content. Default: &#x60;center.&#x60;</value>
        [DataMember(Name="textAlign", EmitDefaultValue=false)]
        public TextAlignEnum? TextAlign { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextStyle" /> class.
        /// </summary>
        /// <param name="color">Hex value representing the color for the text within the text item. Default: &#x60;#1a1a1a&#x60;..</param>
        /// <param name="fillColor">Background color of the text item. Default: &#x60;#ffffff&#x60;..</param>
        /// <param name="fillOpacity">Opacity level of the background color. Possible values: any number between &#x60;0.0&#x60; and &#x60;1.0&#x60;, where:  &#x60;0.0&#x60;: the background color is completely transparent or invisible  &#x60;1.0&#x60;: the background color is completely opaque or solid Default: &#x60;1.0&#x60; if &#x60;fillColor&#x60; provided, &#x60;0.0&#x60; if &#x60;fillColor&#x60; is not provided..</param>
        /// <param name="fontFamily">Font type for the text in the text item. Default: &#x60;arial&#x60;..</param>
        /// <param name="fontSize">Font size, in dp. Default: &#x60;14&#x60;..</param>
        /// <param name="textAlign">Horizontal alignment for the item&#x27;s content. Default: &#x60;center.&#x60;.</param>
        public TextStyle(string color = default(string), string fillColor = default(string), string fillOpacity = default(string), FontFamilyEnum? fontFamily = default(FontFamilyEnum?), string fontSize = default(string), TextAlignEnum? textAlign = default(TextAlignEnum?))
        {
            this.Color = color;
            this.FillColor = fillColor;
            this.FillOpacity = fillOpacity;
            this.FontFamily = fontFamily;
            this.FontSize = fontSize;
            this.TextAlign = textAlign;
        }
        
        /// <summary>
        /// Hex value representing the color for the text within the text item. Default: &#x60;#1a1a1a&#x60;.
        /// </summary>
        /// <value>Hex value representing the color for the text within the text item. Default: &#x60;#1a1a1a&#x60;.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Background color of the text item. Default: &#x60;#ffffff&#x60;.
        /// </summary>
        /// <value>Background color of the text item. Default: &#x60;#ffffff&#x60;.</value>
        [DataMember(Name="fillColor", EmitDefaultValue=false)]
        public string FillColor { get; set; }

        /// <summary>
        /// Opacity level of the background color. Possible values: any number between &#x60;0.0&#x60; and &#x60;1.0&#x60;, where:  &#x60;0.0&#x60;: the background color is completely transparent or invisible  &#x60;1.0&#x60;: the background color is completely opaque or solid Default: &#x60;1.0&#x60; if &#x60;fillColor&#x60; provided, &#x60;0.0&#x60; if &#x60;fillColor&#x60; is not provided.
        /// </summary>
        /// <value>Opacity level of the background color. Possible values: any number between &#x60;0.0&#x60; and &#x60;1.0&#x60;, where:  &#x60;0.0&#x60;: the background color is completely transparent or invisible  &#x60;1.0&#x60;: the background color is completely opaque or solid Default: &#x60;1.0&#x60; if &#x60;fillColor&#x60; provided, &#x60;0.0&#x60; if &#x60;fillColor&#x60; is not provided.</value>
        [DataMember(Name="fillOpacity", EmitDefaultValue=false)]
        public string FillOpacity { get; set; }


        /// <summary>
        /// Font size, in dp. Default: &#x60;14&#x60;.
        /// </summary>
        /// <value>Font size, in dp. Default: &#x60;14&#x60;.</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextStyle {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
            sb.Append("  FillOpacity: ").Append(FillOpacity).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  TextAlign: ").Append(TextAlign).Append("\n");
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
            return this.Equals(input as TextStyle);
        }

        /// <summary>
        /// Returns true if TextStyle instances are equal
        /// </summary>
        /// <param name="input">Instance of TextStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextStyle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.FillColor == input.FillColor ||
                    (this.FillColor != null &&
                    this.FillColor.Equals(input.FillColor))
                ) && 
                (
                    this.FillOpacity == input.FillOpacity ||
                    (this.FillOpacity != null &&
                    this.FillOpacity.Equals(input.FillOpacity))
                ) && 
                (
                    this.FontFamily == input.FontFamily ||
                    (this.FontFamily != null &&
                    this.FontFamily.Equals(input.FontFamily))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.TextAlign == input.TextAlign ||
                    (this.TextAlign != null &&
                    this.TextAlign.Equals(input.TextAlign))
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.FillColor != null)
                    hashCode = hashCode * 59 + this.FillColor.GetHashCode();
                if (this.FillOpacity != null)
                    hashCode = hashCode * 59 + this.FillOpacity.GetHashCode();
                if (this.FontFamily != null)
                    hashCode = hashCode * 59 + this.FontFamily.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.TextAlign != null)
                    hashCode = hashCode * 59 + this.TextAlign.GetHashCode();
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
