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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BoardMembersInvite
    /// </summary>
    [DataContract]
        public partial class BoardMembersInvite :  IEquatable<BoardMembersInvite>, IValidatableObject
    {
        /// <summary>
        /// Role of the board member.
        /// </summary>
        /// <value>Role of the board member.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 1,
            /// <summary>
            /// Enum Commenter for value: commenter
            /// </summary>
            [EnumMember(Value = "commenter")]
            Commenter = 2,
            /// <summary>
            /// Enum Editor for value: editor
            /// </summary>
            [EnumMember(Value = "editor")]
            Editor = 3,
            /// <summary>
            /// Enum Coowner for value: coowner
            /// </summary>
            [EnumMember(Value = "coowner")]
            Coowner = 4,
            /// <summary>
            /// Enum Owner for value: owner
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner = 5,
            /// <summary>
            /// Enum Guest for value: guest
            /// </summary>
            [EnumMember(Value = "guest")]
            Guest = 6        }
        /// <summary>
        /// Role of the board member.
        /// </summary>
        /// <value>Role of the board member.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardMembersInvite" /> class.
        /// </summary>
        /// <param name="emails">Email IDs of the users you want to invite to the board. You can invite up to 20 members per call. (required).</param>
        /// <param name="role">Role of the board member. (default to RoleEnum.Commenter).</param>
        /// <param name="message">The message that will be sent in the invitation email..</param>
        public BoardMembersInvite(List<string> emails = default(List<string>), RoleEnum? role = RoleEnum.Commenter, string message = default(string))
        {
            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new InvalidDataException("emails is a required property for BoardMembersInvite and cannot be null");
            }
            else
            {
                this.Emails = emails;
            }
            // use default value if no "role" provided
            if (role == null)
            {
                this.Role = RoleEnum.Commenter;
            }
            else
            {
                this.Role = role;
            }
            this.Message = message;
        }
        
        /// <summary>
        /// Email IDs of the users you want to invite to the board. You can invite up to 20 members per call.
        /// </summary>
        /// <value>Email IDs of the users you want to invite to the board. You can invite up to 20 members per call.</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }


        /// <summary>
        /// The message that will be sent in the invitation email.
        /// </summary>
        /// <value>The message that will be sent in the invitation email.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoardMembersInvite {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as BoardMembersInvite);
        }

        /// <summary>
        /// Returns true if BoardMembersInvite instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardMembersInvite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardMembersInvite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
