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
    /// Single MMS message model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class MmsMessage :  IEquatable<MmsMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MmsMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MmsMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MmsMessage" /> class.
        /// </summary>
        /// <param name="to">Recipient phone number in E.164 format.</param>
        /// <param name="body">Your message (required).</param>
        /// <param name="subject">Subject line (max 20 characters) (required).</param>
        /// <param name="from">Your sender ID.</param>
        /// <param name="country">Recipient country.</param>
        /// <param name="source">Your method of sending (default to &quot;sdk&quot;).</param>
        /// <param name="listId">Your list ID if sending to a whole list (can be used instead of &#39;to&#39;).</param>
        /// <param name="schedule">Schedule time in unix format (leave blank for immediate delivery) (default to 0).</param>
        /// <param name="customString">Custom string for your reference.</param>
        /// <param name="fromEmail">Email to send replies to.</param>
        public MmsMessage(string to = default(string), string body = default(string), string subject = default(string), string from = default(string), string country = default(string), string source = "sdk", int? listId = default(int?), int? schedule = 0, string customString = default(string), string fromEmail = default(string))
        {
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for MmsMessage and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for MmsMessage and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            this.To = to;
            this.From = from;
            this.Country = country;
            // use default value if no "source" provided
            if (source == null)
            {
                this.Source = "sdk";
            }
            else
            {
                this.Source = source;
            }
            this.ListId = listId;
            // use default value if no "schedule" provided
            if (schedule == null)
            {
                this.Schedule = 0;
            }
            else
            {
                this.Schedule = schedule;
            }
            this.CustomString = customString;
            this.FromEmail = fromEmail;
        }
        
        /// <summary>
        /// Recipient phone number in E.164 format
        /// </summary>
        /// <value>Recipient phone number in E.164 format</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Your message
        /// </summary>
        /// <value>Your message</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Subject line (max 20 characters)
        /// </summary>
        /// <value>Subject line (max 20 characters)</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Your sender ID
        /// </summary>
        /// <value>Your sender ID</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Recipient country
        /// </summary>
        /// <value>Recipient country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Your method of sending
        /// </summary>
        /// <value>Your method of sending</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Your list ID if sending to a whole list (can be used instead of &#39;to&#39;)
        /// </summary>
        /// <value>Your list ID if sending to a whole list (can be used instead of &#39;to&#39;)</value>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int? ListId { get; set; }

        /// <summary>
        /// Schedule time in unix format (leave blank for immediate delivery)
        /// </summary>
        /// <value>Schedule time in unix format (leave blank for immediate delivery)</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Custom string for your reference
        /// </summary>
        /// <value>Custom string for your reference</value>
        [DataMember(Name="custom_string", EmitDefaultValue=false)]
        public string CustomString { get; set; }

        /// <summary>
        /// Email to send replies to
        /// </summary>
        /// <value>Email to send replies to</value>
        [DataMember(Name="from_email", EmitDefaultValue=false)]
        public string FromEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MmsMessage {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  CustomString: ").Append(CustomString).Append("\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
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
            return this.Equals(input as MmsMessage);
        }

        /// <summary>
        /// Returns true if MmsMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of MmsMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MmsMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.CustomString == input.CustomString ||
                    (this.CustomString != null &&
                    this.CustomString.Equals(input.CustomString))
                ) && 
                (
                    this.FromEmail == input.FromEmail ||
                    (this.FromEmail != null &&
                    this.FromEmail.Equals(input.FromEmail))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.CustomString != null)
                    hashCode = hashCode * 59 + this.CustomString.GetHashCode();
                if (this.FromEmail != null)
                    hashCode = hashCode * 59 + this.FromEmail.GetHashCode();
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
