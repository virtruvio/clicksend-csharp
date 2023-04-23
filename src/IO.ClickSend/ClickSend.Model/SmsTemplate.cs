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
    /// SmsTemplate model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class SmsTemplate :  IEquatable<SmsTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsTemplate" /> class.
        /// </summary>
        /// <param name="templateName">Name of template (required).</param>
        /// <param name="body">Body of template (required).</param>
        public SmsTemplate(string templateName = default(string), string body = default(string))
        {
            // to ensure "templateName" is required (not null)
            if (templateName == null)
            {
                throw new InvalidDataException("templateName is a required property for SmsTemplate and cannot be null");
            }
            else
            {
                this.TemplateName = templateName;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for SmsTemplate and cannot be null");
            }
            else
            {
                this.Body = body;
            }
        }
        
        /// <summary>
        /// Name of template
        /// </summary>
        /// <value>Name of template</value>
        [DataMember(Name="template_name", EmitDefaultValue=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Body of template
        /// </summary>
        /// <value>Body of template</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsTemplate {\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as SmsTemplate);
        }

        /// <summary>
        /// Returns true if SmsTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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
