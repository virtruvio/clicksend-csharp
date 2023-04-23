/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
 * Contact: support@clicksend.com
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using ClickSendDateConverter = IO.ClickSend.Client.ClickSendDateConverter;

namespace IO.ClickSend.ClickSend.Model 
{
    /// <summary>
    /// PostLetter model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class PostLetter :  IEquatable<PostLetter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostLetter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostLetter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostLetter" /> class.
        /// </summary>
        /// <param name="fileUrl">URL of file to send (required).</param>
        /// <param name="priorityPost">Whether letter is priority (default to 0).</param>
        /// <param name="recipients">Array of PostRecipient models (required).</param>
        /// <param name="templateUsed">Whether using our template (default to 0).</param>
        /// <param name="duplex">Whether letter is duplex (default to 0).</param>
        /// <param name="colour">Whether letter is in colour (default to 0).</param>
        /// <param name="source">Source being sent from (default to &quot;sdk&quot;).</param>
        public PostLetter(string fileUrl = default(string), int? priorityPost = 0, List<PostRecipient> recipients = default(List<PostRecipient>), int? templateUsed = 0, int? duplex = 0, int? colour = 0, string source = "sdk")
        {
            // to ensure "fileUrl" is required (not null)
            if (fileUrl == null)
            {
                throw new InvalidDataException("fileUrl is a required property for PostLetter and cannot be null");
            }
            else
            {
                this.FileUrl = fileUrl;
            }
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for PostLetter and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
            // use default value if no "priorityPost" provided
            if (priorityPost == null)
            {
                this.PriorityPost = 0;
            }
            else
            {
                this.PriorityPost = priorityPost;
            }
            // use default value if no "templateUsed" provided
            if (templateUsed == null)
            {
                this.TemplateUsed = 0;
            }
            else
            {
                this.TemplateUsed = templateUsed;
            }
            // use default value if no "duplex" provided
            if (duplex == null)
            {
                this.Duplex = 0;
            }
            else
            {
                this.Duplex = duplex;
            }
            // use default value if no "colour" provided
            if (colour == null)
            {
                this.Colour = 0;
            }
            else
            {
                this.Colour = colour;
            }
            // use default value if no "source" provided
            if (source == null)
            {
                this.Source = "sdk";
            }
            else
            {
                this.Source = source;
            }
        }
        
        /// <summary>
        /// URL of file to send
        /// </summary>
        /// <value>URL of file to send</value>
        [DataMember(Name="file_url", EmitDefaultValue=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Whether letter is priority
        /// </summary>
        /// <value>Whether letter is priority</value>
        [DataMember(Name="priority_post", EmitDefaultValue=false)]
        public int? PriorityPost { get; set; }

        /// <summary>
        /// Array of PostRecipient models
        /// </summary>
        /// <value>Array of PostRecipient models</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<PostRecipient> Recipients { get; set; }

        /// <summary>
        /// Whether using our template
        /// </summary>
        /// <value>Whether using our template</value>
        [DataMember(Name="template_used", EmitDefaultValue=false)]
        public int? TemplateUsed { get; set; }

        /// <summary>
        /// Whether letter is duplex
        /// </summary>
        /// <value>Whether letter is duplex</value>
        [DataMember(Name="duplex", EmitDefaultValue=false)]
        public int? Duplex { get; set; }

        /// <summary>
        /// Whether letter is in colour
        /// </summary>
        /// <value>Whether letter is in colour</value>
        [DataMember(Name="colour", EmitDefaultValue=false)]
        public int? Colour { get; set; }

        /// <summary>
        /// Source being sent from
        /// </summary>
        /// <value>Source being sent from</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostLetter {\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  PriorityPost: ").Append(PriorityPost).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  TemplateUsed: ").Append(TemplateUsed).Append("\n");
            sb.Append("  Duplex: ").Append(Duplex).Append("\n");
            sb.Append("  Colour: ").Append(Colour).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as PostLetter);
        }

        /// <summary>
        /// Returns true if PostLetter instances are equal
        /// </summary>
        /// <param name="input">Instance of PostLetter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostLetter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
                ) && 
                (
                    this.PriorityPost == input.PriorityPost ||
                    (this.PriorityPost != null &&
                    this.PriorityPost.Equals(input.PriorityPost))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.TemplateUsed == input.TemplateUsed ||
                    (this.TemplateUsed != null &&
                    this.TemplateUsed.Equals(input.TemplateUsed))
                ) && 
                (
                    this.Duplex == input.Duplex ||
                    (this.Duplex != null &&
                    this.Duplex.Equals(input.Duplex))
                ) && 
                (
                    this.Colour == input.Colour ||
                    (this.Colour != null &&
                    this.Colour.Equals(input.Colour))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.FileUrl != null)
                    hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                if (this.PriorityPost != null)
                    hashCode = hashCode * 59 + this.PriorityPost.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.TemplateUsed != null)
                    hashCode = hashCode * 59 + this.TemplateUsed.GetHashCode();
                if (this.Duplex != null)
                    hashCode = hashCode * 59 + this.Duplex.GetHashCode();
                if (this.Colour != null)
                    hashCode = hashCode * 59 + this.Colour.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
