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
    /// Campaign Model for SMS
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class SmsCampaign :  IEquatable<SmsCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsCampaign" /> class.
        /// </summary>
        /// <param name="listId">Your list id. (required).</param>
        /// <param name="name">Your campaign name. (required).</param>
        /// <param name="body">Your campaign message. (required).</param>
        /// <param name="from">Your sender id - more info: http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number..</param>
        /// <param name="schedule">Your schedule timestamp. (default to 0).</param>
        /// <param name="urlToShorten">url to be shortened add http://smsg.io/xxxxx&#x60; to the body as a placeholder..</param>
        public SmsCampaign(int? listId = default(int?), string name = default(string), string body = default(string), string from = default(string), int? schedule = 0, string urlToShorten = default(string))
        {
            // to ensure "listId" is required (not null)
            if (listId == null)
            {
                throw new InvalidDataException("listId is a required property for SmsCampaign and cannot be null");
            }
            else
            {
                this.ListId = listId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SmsCampaign and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for SmsCampaign and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            this.From = from;
            // use default value if no "schedule" provided
            if (schedule == null)
            {
                this.Schedule = 0;
            }
            else
            {
                this.Schedule = schedule;
            }
            this.UrlToShorten = urlToShorten;
        }
        
        /// <summary>
        /// Your list id.
        /// </summary>
        /// <value>Your list id.</value>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int? ListId { get; set; }

        /// <summary>
        /// Your campaign name.
        /// </summary>
        /// <value>Your campaign name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Your campaign message.
        /// </summary>
        /// <value>Your campaign message.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Your sender id - more info: http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number.
        /// </summary>
        /// <value>Your sender id - more info: http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Your schedule timestamp.
        /// </summary>
        /// <value>Your schedule timestamp.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// url to be shortened add http://smsg.io/xxxxx&#x60; to the body as a placeholder.
        /// </summary>
        /// <value>url to be shortened add http://smsg.io/xxxxx&#x60; to the body as a placeholder.</value>
        [DataMember(Name="url_to_shorten", EmitDefaultValue=false)]
        public string UrlToShorten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsCampaign {\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  UrlToShorten: ").Append(UrlToShorten).Append("\n");
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
            return this.Equals(input as SmsCampaign);
        }

        /// <summary>
        /// Returns true if SmsCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.UrlToShorten == input.UrlToShorten ||
                    (this.UrlToShorten != null &&
                    this.UrlToShorten.Equals(input.UrlToShorten))
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
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.UrlToShorten != null)
                    hashCode = hashCode * 59 + this.UrlToShorten.GetHashCode();
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
