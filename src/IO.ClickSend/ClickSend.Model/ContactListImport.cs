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
    /// Contact list import model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class ContactListImport :  IEquatable<ContactListImport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListImport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactListImport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListImport" /> class.
        /// </summary>
        /// <param name="fileUrl">URL of file to process (required).</param>
        /// <param name="fieldOrder">Order of fields in file (required).</param>
        public ContactListImport(string fileUrl = default(string), List<string> fieldOrder = default(List<string>))
        {
            // to ensure "fileUrl" is required (not null)
            if (fileUrl == null)
            {
                throw new InvalidDataException("fileUrl is a required property for ContactListImport and cannot be null");
            }
            else
            {
                this.FileUrl = fileUrl;
            }
            // to ensure "fieldOrder" is required (not null)
            if (fieldOrder == null)
            {
                throw new InvalidDataException("fieldOrder is a required property for ContactListImport and cannot be null");
            }
            else
            {
                this.FieldOrder = fieldOrder;
            }
        }
        
        /// <summary>
        /// URL of file to process
        /// </summary>
        /// <value>URL of file to process</value>
        [DataMember(Name="file_url", EmitDefaultValue=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Order of fields in file
        /// </summary>
        /// <value>Order of fields in file</value>
        [DataMember(Name="field_order", EmitDefaultValue=false)]
        public List<string> FieldOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListImport {\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  FieldOrder: ").Append(FieldOrder).Append("\n");
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
            return this.Equals(input as ContactListImport);
        }

        /// <summary>
        /// Returns true if ContactListImport instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactListImport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListImport input)
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
                    this.FieldOrder == input.FieldOrder ||
                    this.FieldOrder != null &&
                    this.FieldOrder.SequenceEqual(input.FieldOrder)
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
                if (this.FieldOrder != null)
                    hashCode = hashCode * 59 + this.FieldOrder.GetHashCode();
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
