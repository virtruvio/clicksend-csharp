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
    /// String to be stripped.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class StrippedString :  IEquatable<StrippedString>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrippedString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StrippedString() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrippedString" /> class.
        /// </summary>
        /// <param name="stripString">String to be. (required).</param>
        public StrippedString(string stripString = default(string))
        {
            // to ensure "stripString" is required (not null)
            if (stripString == null)
            {
                throw new InvalidDataException("stripString is a required property for StrippedString and cannot be null");
            }
            else
            {
                this.StripString = stripString;
            }
        }
        
        /// <summary>
        /// String to be.
        /// </summary>
        /// <value>String to be.</value>
        [DataMember(Name="strip_string", EmitDefaultValue=false)]
        public string StripString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrippedString {\n");
            sb.Append("  StripString: ").Append(StripString).Append("\n");
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
            return this.Equals(input as StrippedString);
        }

        /// <summary>
        /// Returns true if StrippedString instances are equal
        /// </summary>
        /// <param name="input">Instance of StrippedString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrippedString input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StripString == input.StripString ||
                    (this.StripString != null &&
                    this.StripString.Equals(input.StripString))
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
                if (this.StripString != null)
                    hashCode = hashCode * 59 + this.StripString.GetHashCode();
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
