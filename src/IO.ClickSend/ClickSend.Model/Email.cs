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
    /// Send Email
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class Email :  IEquatable<Email>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Email() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="to">Array of To Recipient items. (required).</param>
        /// <param name="cc">Array of Cc Recipient items..</param>
        /// <param name="bcc">Array of Bcc Recipient items..</param>
        /// <param name="from">from (required).</param>
        /// <param name="subject">Subject of the email..</param>
        /// <param name="body">Body of the email. (required).</param>
        /// <param name="attachments">Array of Attachment items..</param>
        /// <param name="schedule">Schedule..</param>
        public Email(List<EmailRecipient> to = default(List<EmailRecipient>), List<EmailRecipient> cc = default(List<EmailRecipient>), List<EmailRecipient> bcc = default(List<EmailRecipient>), EmailFrom from = default(EmailFrom), string subject = default(string), string body = default(string), List<Attachment> attachments = default(List<Attachment>), decimal? schedule = default(decimal?))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for Email and cannot be null");
            }
            else
            {
                this.To = to;
            }
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for Email and cannot be null");
            }
            else
            {
                this.From = from;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for Email and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            this.Cc = cc;
            this.Bcc = bcc;
            this.Subject = subject;
            this.Attachments = attachments;
            this.Schedule = schedule;
        }
        
        /// <summary>
        /// Array of To Recipient items.
        /// </summary>
        /// <value>Array of To Recipient items.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<EmailRecipient> To { get; set; }

        /// <summary>
        /// Array of Cc Recipient items.
        /// </summary>
        /// <value>Array of Cc Recipient items.</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<EmailRecipient> Cc { get; set; }

        /// <summary>
        /// Array of Bcc Recipient items.
        /// </summary>
        /// <value>Array of Bcc Recipient items.</value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<EmailRecipient> Bcc { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public EmailFrom From { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        /// <value>Subject of the email.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Body of the email.
        /// </summary>
        /// <value>Body of the email.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Array of Attachment items.
        /// </summary>
        /// <value>Array of Attachment items.</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Schedule.
        /// </summary>
        /// <value>Schedule.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public decimal? Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="input">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    this.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
