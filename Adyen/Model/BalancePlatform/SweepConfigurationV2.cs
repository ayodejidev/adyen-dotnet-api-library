/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
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
    /// SweepConfigurationV2
    /// </summary>
    [DataContract(Name = "SweepConfigurationV2")]
    public partial class SweepConfigurationV2 : IEquatable<SweepConfigurationV2>, IValidatableObject
    {
        /// <summary>
        /// The type of sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id)   - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.
        /// </summary>
        /// <value>The type of sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id)   - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Bank for value: bank
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank = 1,

            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 2,

            /// <summary>
            /// Enum PlatformPayment for value: platformPayment
            /// </summary>
            [EnumMember(Value = "platformPayment")]
            PlatformPayment = 3

        }


        /// <summary>
        /// The type of sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id)   - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.
        /// </summary>
        /// <value>The type of sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id)   - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
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
            /// Enum DirectDebit for value: directDebit
            /// </summary>
            [EnumMember(Value = "directDebit")]
            DirectDebit = 2,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 3,

            /// <summary>
            /// Enum Instant for value: instant
            /// </summary>
            [EnumMember(Value = "instant")]
            Instant = 4,

            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 5,

            /// <summary>
            /// Enum Regular for value: regular
            /// </summary>
            [EnumMember(Value = "regular")]
            Regular = 6,

            /// <summary>
            /// Enum Wire for value: wire
            /// </summary>
            [EnumMember(Value = "wire")]
            Wire = 7

        }

        /// <summary>
        /// The reason for disabling the sweep.
        /// </summary>
        /// <value>The reason for disabling the sweep.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum AmountLimitExceeded for value: amountLimitExceeded
            /// </summary>
            [EnumMember(Value = "amountLimitExceeded")]
            AmountLimitExceeded = 1,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 2,

            /// <summary>
            /// Enum CounterpartyAccountBlocked for value: counterpartyAccountBlocked
            /// </summary>
            [EnumMember(Value = "counterpartyAccountBlocked")]
            CounterpartyAccountBlocked = 3,

            /// <summary>
            /// Enum CounterpartyAccountClosed for value: counterpartyAccountClosed
            /// </summary>
            [EnumMember(Value = "counterpartyAccountClosed")]
            CounterpartyAccountClosed = 4,

            /// <summary>
            /// Enum CounterpartyAccountNotFound for value: counterpartyAccountNotFound
            /// </summary>
            [EnumMember(Value = "counterpartyAccountNotFound")]
            CounterpartyAccountNotFound = 5,

            /// <summary>
            /// Enum CounterpartyAddressRequired for value: counterpartyAddressRequired
            /// </summary>
            [EnumMember(Value = "counterpartyAddressRequired")]
            CounterpartyAddressRequired = 6,

            /// <summary>
            /// Enum CounterpartyBankTimedOut for value: counterpartyBankTimedOut
            /// </summary>
            [EnumMember(Value = "counterpartyBankTimedOut")]
            CounterpartyBankTimedOut = 7,

            /// <summary>
            /// Enum CounterpartyBankUnavailable for value: counterpartyBankUnavailable
            /// </summary>
            [EnumMember(Value = "counterpartyBankUnavailable")]
            CounterpartyBankUnavailable = 8,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 9,

            /// <summary>
            /// Enum NotEnoughBalance for value: notEnoughBalance
            /// </summary>
            [EnumMember(Value = "notEnoughBalance")]
            NotEnoughBalance = 10,

            /// <summary>
            /// Enum RefusedByCounterpartyBank for value: refusedByCounterpartyBank
            /// </summary>
            [EnumMember(Value = "refusedByCounterpartyBank")]
            RefusedByCounterpartyBank = 11,

            /// <summary>
            /// Enum RouteNotFound for value: routeNotFound
            /// </summary>
            [EnumMember(Value = "routeNotFound")]
            RouteNotFound = 12,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 13

        }


        /// <summary>
        /// The reason for disabling the sweep.
        /// </summary>
        /// <value>The reason for disabling the sweep.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public ReasonEnum? Reason { get; set; }

        /// <summary>
        /// Returns false as Reason should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReason()
        {
            return false;
        }
        /// <summary>
        /// The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   
        /// </summary>
        /// <value>The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }


        /// <summary>
        /// The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   
        /// </summary>
        /// <value>The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.
        /// </summary>
        /// <value>The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Pull for value: pull
            /// </summary>
            [EnumMember(Value = "pull")]
            Pull = 1,

            /// <summary>
            /// Enum Push for value: push
            /// </summary>
            [EnumMember(Value = "push")]
            Push = 2

        }


        /// <summary>
        /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.
        /// </summary>
        /// <value>The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SweepConfigurationV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2" /> class.
        /// </summary>
        /// <param name="category">The type of sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id)   - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform..</param>
        /// <param name="counterparty">counterparty (required).</param>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances). (required).</param>
        /// <param name="description">The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters..</param>
        /// <param name="priorities">The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Required for sweeps with &#x60;category&#x60; **bank**.  Some transfer routes have an amount limit. The sweep will be executed using the first priority that leads to a valid route given the sweep amount.All supplied priorities need to lead to a valid route at time of configuration given the sweep currency and counterparty details.  Possible values:  * **regular**: For normal, low-value transactions.  * **fast**: Faster way to transfer funds but has higher fees. Recommended for high-priority, low-value transactions.  * **wire**: Fastest way to transfer funds but has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: Instant way to transfer funds in [SEPA countries](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: High-value transfer to a recipient in a different country.  * **internal**: Transfer to an Adyen-issued business bank account (by bank account number/IBAN)..</param>
        /// <param name="schedule">schedule (required).</param>
        /// <param name="status">The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   .</param>
        /// <param name="sweepAmount">sweepAmount.</param>
        /// <param name="targetAmount">targetAmount.</param>
        /// <param name="triggerAmount">triggerAmount.</param>
        /// <param name="type">The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account. (default to TypeEnum.Push).</param>
        public SweepConfigurationV2(CategoryEnum? category = default(CategoryEnum?), SweepCounterparty counterparty = default(SweepCounterparty), string currency = default(string), string description = default(string), List<PrioritiesEnum> priorities = default(List<PrioritiesEnum>), SweepConfigurationV2Schedule schedule = default(SweepConfigurationV2Schedule), StatusEnum? status = default(StatusEnum?), Amount sweepAmount = default(Amount), Amount targetAmount = default(Amount), Amount triggerAmount = default(Amount), TypeEnum? type = TypeEnum.Push)
        {
            this.Counterparty = counterparty;
            this.Currency = currency;
            this.Schedule = schedule;
            this.Category = category;
            this.Description = description;
            this.Priorities = priorities;
            this.Status = status;
            this.SweepAmount = sweepAmount;
            this.TargetAmount = targetAmount;
            this.TriggerAmount = triggerAmount;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", IsRequired = false, EmitDefaultValue = false)]
        public SweepCounterparty Counterparty { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances).</value>
        [DataMember(Name = "currency", IsRequired = false, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters.
        /// </summary>
        /// <value>The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the sweep.
        /// </summary>
        /// <value>The unique identifier of the sweep.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Required for sweeps with &#x60;category&#x60; **bank**.  Some transfer routes have an amount limit. The sweep will be executed using the first priority that leads to a valid route given the sweep amount.All supplied priorities need to lead to a valid route at time of configuration given the sweep currency and counterparty details.  Possible values:  * **regular**: For normal, low-value transactions.  * **fast**: Faster way to transfer funds but has higher fees. Recommended for high-priority, low-value transactions.  * **wire**: Fastest way to transfer funds but has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: Instant way to transfer funds in [SEPA countries](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: High-value transfer to a recipient in a different country.  * **internal**: Transfer to an Adyen-issued business bank account (by bank account number/IBAN).
        /// </summary>
        /// <value>The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Required for sweeps with &#x60;category&#x60; **bank**.  Some transfer routes have an amount limit. The sweep will be executed using the first priority that leads to a valid route given the sweep amount.All supplied priorities need to lead to a valid route at time of configuration given the sweep currency and counterparty details.  Possible values:  * **regular**: For normal, low-value transactions.  * **fast**: Faster way to transfer funds but has higher fees. Recommended for high-priority, low-value transactions.  * **wire**: Fastest way to transfer funds but has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: Instant way to transfer funds in [SEPA countries](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: High-value transfer to a recipient in a different country.  * **internal**: Transfer to an Adyen-issued business bank account (by bank account number/IBAN).</value>
        [DataMember(Name = "priorities", EmitDefaultValue = false)]
        public List<SweepConfigurationV2.PrioritiesEnum> Priorities { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", IsRequired = false, EmitDefaultValue = false)]
        public SweepConfigurationV2Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets SweepAmount
        /// </summary>
        [DataMember(Name = "sweepAmount", EmitDefaultValue = false)]
        public Amount SweepAmount { get; set; }

        /// <summary>
        /// Gets or Sets TargetAmount
        /// </summary>
        [DataMember(Name = "targetAmount", EmitDefaultValue = false)]
        public Amount TargetAmount { get; set; }

        /// <summary>
        /// Gets or Sets TriggerAmount
        /// </summary>
        [DataMember(Name = "triggerAmount", EmitDefaultValue = false)]
        public Amount TriggerAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SweepConfigurationV2 {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SweepAmount: ").Append(SweepAmount).Append("\n");
            sb.Append("  TargetAmount: ").Append(TargetAmount).Append("\n");
            sb.Append("  TriggerAmount: ").Append(TriggerAmount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SweepConfigurationV2);
        }

        /// <summary>
        /// Returns true if SweepConfigurationV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepConfigurationV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepConfigurationV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities != null &&
                    input.Priorities != null &&
                    this.Priorities.SequenceEqual(input.Priorities)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SweepAmount == input.SweepAmount ||
                    (this.SweepAmount != null &&
                    this.SweepAmount.Equals(input.SweepAmount))
                ) && 
                (
                    this.TargetAmount == input.TargetAmount ||
                    (this.TargetAmount != null &&
                    this.TargetAmount.Equals(input.TargetAmount))
                ) && 
                (
                    this.TriggerAmount == input.TriggerAmount ||
                    (this.TriggerAmount != null &&
                    this.TriggerAmount.Equals(input.TriggerAmount))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Priorities != null)
                {
                    hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SweepAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SweepAmount.GetHashCode();
                }
                if (this.TargetAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAmount.GetHashCode();
                }
                if (this.TriggerAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
