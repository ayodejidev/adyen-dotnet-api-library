/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// TransferRouteRequest
    /// </summary>
    [DataContract(Name = "TransferRouteRequest")]
    public partial class TransferRouteRequest : IEquatable<TransferRouteRequest>, IValidatableObject
    {
        /// <summary>
        ///  The type of transfer. Possible values:    - **bank**: Transfer to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id) or a bank account. 
        /// </summary>
        /// <value> The type of transfer. Possible values:    - **bank**: Transfer to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id) or a bank account. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Bank for value: bank
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank = 1

        }


        /// <summary>
        ///  The type of transfer. Possible values:    - **bank**: Transfer to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id) or a bank account. 
        /// </summary>
        /// <value> The type of transfer. Possible values:    - **bank**: Transfer to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id) or a bank account. </value>
        [DataMember(Name = "category", IsRequired = false, EmitDefaultValue = false)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// Defines Priorities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrioritiesEnum
        {
            /// <summary>
            /// Enum CrossBorder for value: crossBorder
            /// </summary>
            [EnumMember(Value = "crossBorder")]
            CrossBorder = 1,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 2,

            /// <summary>
            /// Enum Instant for value: instant
            /// </summary>
            [EnumMember(Value = "instant")]
            Instant = 3,

            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 4,

            /// <summary>
            /// Enum Regular for value: regular
            /// </summary>
            [EnumMember(Value = "regular")]
            Regular = 5,

            /// <summary>
            /// Enum Wire for value: wire
            /// </summary>
            [EnumMember(Value = "wire")]
            Wire = 6

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferRouteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteRequest" /> class.
        /// </summary>
        /// <param name="balanceAccountId">The unique identifier of the source [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id). Required if &#x60;counterparty&#x60; is **transferInstrumentId**..</param>
        /// <param name="balancePlatform">The unique identifier assigned to the balance platform associated with the account holder. (required).</param>
        /// <param name="category"> The type of transfer. Possible values:    - **bank**: Transfer to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id) or a bank account.  (required).</param>
        /// <param name="counterparty">counterparty.</param>
        /// <param name="country">The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, **US** or **NL**.  &gt; Either &#x60;counterparty&#x60; or &#x60;country&#x60; field must be provided in a transfer route request..</param>
        /// <param name="currency">The three-character ISO currency code of transfer. For example, **USD** or **EUR**. (required).</param>
        /// <param name="priorities">The list of priorities for the bank transfer. Priorities set the speed at which the transfer is sent and the fees that you have to pay. Multiple values can be provided. Possible values:  * **regular**: For normal, low-value transactions.  * **fast**: Faster way to transfer funds but has higher fees. Recommended for high-priority, low-value transactions.  * **wire**: Fastest way to transfer funds but has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: Instant way to transfer funds in [SEPA countries](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: High-value transfer to a recipient in a different country.  * **internal**: Transfer to an Adyen-issued business bank account (by bank account number/IBAN)..</param>
        public TransferRouteRequest(string balanceAccountId = default(string), string balancePlatform = default(string), CategoryEnum category = default(CategoryEnum), Counterparty counterparty = default(Counterparty), string country = default(string), string currency = default(string), List<PrioritiesEnum> priorities = default(List<PrioritiesEnum>))
        {
            this.BalancePlatform = balancePlatform;
            this.Category = category;
            this.Currency = currency;
            this.BalanceAccountId = balanceAccountId;
            this.Counterparty = counterparty;
            this.Country = country;
            this.Priorities = priorities;
        }

        /// <summary>
        /// The unique identifier of the source [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id). Required if &#x60;counterparty&#x60; is **transferInstrumentId**.
        /// </summary>
        /// <value>The unique identifier of the source [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id). Required if &#x60;counterparty&#x60; is **transferInstrumentId**.</value>
        [DataMember(Name = "balanceAccountId", EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// The unique identifier assigned to the balance platform associated with the account holder.
        /// </summary>
        /// <value>The unique identifier assigned to the balance platform associated with the account holder.</value>
        [DataMember(Name = "balancePlatform", IsRequired = false, EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", EmitDefaultValue = false)]
        public Counterparty Counterparty { get; set; }

        /// <summary>
        /// The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, **US** or **NL**.  &gt; Either &#x60;counterparty&#x60; or &#x60;country&#x60; field must be provided in a transfer route request.
        /// </summary>
        /// <value>The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, **US** or **NL**.  &gt; Either &#x60;counterparty&#x60; or &#x60;country&#x60; field must be provided in a transfer route request.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The three-character ISO currency code of transfer. For example, **USD** or **EUR**.
        /// </summary>
        /// <value>The three-character ISO currency code of transfer. For example, **USD** or **EUR**.</value>
        [DataMember(Name = "currency", IsRequired = false, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The list of priorities for the bank transfer. Priorities set the speed at which the transfer is sent and the fees that you have to pay. Multiple values can be provided. Possible values:  * **regular**: For normal, low-value transactions.  * **fast**: Faster way to transfer funds but has higher fees. Recommended for high-priority, low-value transactions.  * **wire**: Fastest way to transfer funds but has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: Instant way to transfer funds in [SEPA countries](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: High-value transfer to a recipient in a different country.  * **internal**: Transfer to an Adyen-issued business bank account (by bank account number/IBAN).
        /// </summary>
        /// <value>The list of priorities for the bank transfer. Priorities set the speed at which the transfer is sent and the fees that you have to pay. Multiple values can be provided. Possible values:  * **regular**: For normal, low-value transactions.  * **fast**: Faster way to transfer funds but has higher fees. Recommended for high-priority, low-value transactions.  * **wire**: Fastest way to transfer funds but has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: Instant way to transfer funds in [SEPA countries](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: High-value transfer to a recipient in a different country.  * **internal**: Transfer to an Adyen-issued business bank account (by bank account number/IBAN).</value>
        [DataMember(Name = "priorities", EmitDefaultValue = false)]
        public List<TransferRouteRequest.PrioritiesEnum> Priorities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferRouteRequest {\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
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
            return this.Equals(input as TransferRouteRequest);
        }

        /// <summary>
        /// Returns true if TransferRouteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRouteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRouteRequest input)
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
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities != null &&
                    input.Priorities != null &&
                    this.Priorities.SequenceEqual(input.Priorities)
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
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Priorities != null)
                {
                    hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
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
