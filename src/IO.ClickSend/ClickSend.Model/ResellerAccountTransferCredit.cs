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
    /// ResellerAccountTransferCredit model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class ResellerAccountTransferCredit :  IEquatable<ResellerAccountTransferCredit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerAccountTransferCredit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResellerAccountTransferCredit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerAccountTransferCredit" /> class.
        /// </summary>
        /// <param name="clientUserId">User ID of client (required).</param>
        /// <param name="balance">Balance to transfer (required).</param>
        /// <param name="currency">Currency of balance to transfer (required).</param>
        public ResellerAccountTransferCredit(int? clientUserId = default(int?), int? balance = default(int?), string currency = default(string))
        {
            // to ensure "clientUserId" is required (not null)
            if (clientUserId == null)
            {
                throw new InvalidDataException("clientUserId is a required property for ResellerAccountTransferCredit and cannot be null");
            }
            else
            {
                this.ClientUserId = clientUserId;
            }
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new InvalidDataException("balance is a required property for ResellerAccountTransferCredit and cannot be null");
            }
            else
            {
                this.Balance = balance;
            }
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for ResellerAccountTransferCredit and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
        }
        
        /// <summary>
        /// User ID of client
        /// </summary>
        /// <value>User ID of client</value>
        [DataMember(Name="client_user_id", EmitDefaultValue=false)]
        public int? ClientUserId { get; set; }

        /// <summary>
        /// Balance to transfer
        /// </summary>
        /// <value>Balance to transfer</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public int? Balance { get; set; }

        /// <summary>
        /// Currency of balance to transfer
        /// </summary>
        /// <value>Currency of balance to transfer</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResellerAccountTransferCredit {\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as ResellerAccountTransferCredit);
        }

        /// <summary>
        /// Returns true if ResellerAccountTransferCredit instances are equal
        /// </summary>
        /// <param name="input">Instance of ResellerAccountTransferCredit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResellerAccountTransferCredit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientUserId == input.ClientUserId ||
                    (this.ClientUserId != null &&
                    this.ClientUserId.Equals(input.ClientUserId))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.ClientUserId != null)
                    hashCode = hashCode * 59 + this.ClientUserId.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
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
