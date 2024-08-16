/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// TransferNotificationCounterParty
    /// </summary>
    [DataContract(Name = "TransferNotificationCounterParty")]
    public partial class TransferNotificationCounterParty : IEquatable<TransferNotificationCounterParty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNotificationCounterParty" /> class.
        /// </summary>
        /// <param name="balanceAccountId">The unique identifier of the counterparty [balance account](https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id)..</param>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="card">card.</param>
        /// <param name="merchant">merchant.</param>
        /// <param name="transferInstrumentId">The unique identifier of the counterparty [transfer instrument](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id)..</param>
        public TransferNotificationCounterParty(string balanceAccountId = default(string), BankAccountV3 bankAccount = default(BankAccountV3), Card card = default(Card), TransferNotificationMerchantData merchant = default(TransferNotificationMerchantData), string transferInstrumentId = default(string))
        {
            this.BalanceAccountId = balanceAccountId;
            this.BankAccount = bankAccount;
            this.Card = card;
            this.Merchant = merchant;
            this.TransferInstrumentId = transferInstrumentId;
        }

        /// <summary>
        /// The unique identifier of the counterparty [balance account](https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id).
        /// </summary>
        /// <value>The unique identifier of the counterparty [balance account](https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id).</value>
        [DataMember(Name = "balanceAccountId", EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        public BankAccountV3 BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }

        /// <summary>
        /// Gets or Sets Merchant
        /// </summary>
        [DataMember(Name = "merchant", EmitDefaultValue = false)]
        public TransferNotificationMerchantData Merchant { get; set; }

        /// <summary>
        /// The unique identifier of the counterparty [transfer instrument](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id).
        /// </summary>
        /// <value>The unique identifier of the counterparty [transfer instrument](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id).</value>
        [DataMember(Name = "transferInstrumentId", EmitDefaultValue = false)]
        public string TransferInstrumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferNotificationCounterParty {\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
            sb.Append("  TransferInstrumentId: ").Append(TransferInstrumentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferNotificationCounterParty);
        }

        /// <summary>
        /// Returns true if TransferNotificationCounterParty instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferNotificationCounterParty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferNotificationCounterParty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalanceAccountId == input.BalanceAccountId ||
                    (this.BalanceAccountId != null &&
                    this.BalanceAccountId.Equals(input.BalanceAccountId))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.Merchant == input.Merchant ||
                    (this.Merchant != null &&
                    this.Merchant.Equals(input.Merchant))
                ) && 
                (
                    this.TransferInstrumentId == input.TransferInstrumentId ||
                    (this.TransferInstrumentId != null &&
                    this.TransferInstrumentId.Equals(input.TransferInstrumentId))
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
                if (this.BalanceAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAccountId.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.Card != null)
                {
                    hashCode = (hashCode * 59) + this.Card.GetHashCode();
                }
                if (this.Merchant != null)
                {
                    hashCode = (hashCode * 59) + this.Merchant.GetHashCode();
                }
                if (this.TransferInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferInstrumentId.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
