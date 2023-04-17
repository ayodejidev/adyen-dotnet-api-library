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
    /// AccountHolderCapability
    /// </summary>
    [DataContract(Name = "AccountHolderCapability")]
    public partial class AccountHolderCapability : IEquatable<AccountHolderCapability>, IValidatableObject
    {
        /// <summary>
        /// The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowedLevelEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 4

        }


        /// <summary>
        /// The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "allowedLevel", EmitDefaultValue = false)]
        public AllowedLevelEnum? AllowedLevel { get; set; }

        /// <summary>
        /// Returns false as AllowedLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedLevel()
        {
            return false;
        }
        /// <summary>
        /// The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestedLevelEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 4

        }


        /// <summary>
        /// The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "requestedLevel", EmitDefaultValue = false)]
        public RequestedLevelEnum? RequestedLevel { get; set; }
        /// <summary>
        /// The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerificationStatusEnum
        {
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 3,

            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 4

        }


        /// <summary>
        /// The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. </value>
        [DataMember(Name = "verificationStatus", EmitDefaultValue = false)]
        public VerificationStatusEnum? VerificationStatus { get; set; }

        /// <summary>
        /// Returns false as VerificationStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerificationStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderCapability" /> class.
        /// </summary>
        /// <param name="allowedSettings">allowedSettings.</param>
        /// <param name="enabled">Indicates whether the capability is enabled. If **false**, the capability is temporarily disabled for the account holder..</param>
        /// <param name="requested">Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the &#x60;allowed&#x60; field..</param>
        /// <param name="requestedLevel">The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**..</param>
        /// <param name="requestedSettings">requestedSettings.</param>
        /// <param name="transferInstruments">Contains the status of the transfer instruments associated with this capability. .</param>
        public AccountHolderCapability(JSONObject allowedSettings = default(JSONObject), bool enabled = default(bool), bool requested = default(bool), RequestedLevelEnum? requestedLevel = default(RequestedLevelEnum?), JSONObject requestedSettings = default(JSONObject), List<AccountSupportingEntityCapability> transferInstruments = default(List<AccountSupportingEntityCapability>))
        {
            this.AllowedSettings = allowedSettings;
            this.Enabled = enabled;
            this.Requested = requested;
            this.RequestedLevel = requestedLevel;
            this.RequestedSettings = requestedSettings;
            this.TransferInstruments = transferInstruments;
        }

        /// <summary>
        /// Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful and the account holder is permitted to use the capability.
        /// </summary>
        /// <value>Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful and the account holder is permitted to use the capability.</value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool Allowed { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedSettings
        /// </summary>
        [DataMember(Name = "allowedSettings", EmitDefaultValue = false)]
        public JSONObject AllowedSettings { get; set; }

        /// <summary>
        /// Indicates whether the capability is enabled. If **false**, the capability is temporarily disabled for the account holder.
        /// </summary>
        /// <value>Indicates whether the capability is enabled. If **false**, the capability is temporarily disabled for the account holder.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Contains verification errors and the actions that you can take to resolve them.
        /// </summary>
        /// <value>Contains verification errors and the actions that you can take to resolve them.</value>
        [DataMember(Name = "problems", EmitDefaultValue = false)]
        public List<Object> Problems { get; private set; }

        /// <summary>
        /// Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the &#x60;allowed&#x60; field.
        /// </summary>
        /// <value>Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the &#x60;allowed&#x60; field.</value>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public bool Requested { get; set; }

        /// <summary>
        /// Gets or Sets RequestedSettings
        /// </summary>
        [DataMember(Name = "requestedSettings", EmitDefaultValue = false)]
        public JSONObject RequestedSettings { get; set; }

        /// <summary>
        /// Contains the status of the transfer instruments associated with this capability. 
        /// </summary>
        /// <value>Contains the status of the transfer instruments associated with this capability. </value>
        [DataMember(Name = "transferInstruments", EmitDefaultValue = false)]
        public List<AccountSupportingEntityCapability> TransferInstruments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderCapability {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  AllowedLevel: ").Append(AllowedLevel).Append("\n");
            sb.Append("  AllowedSettings: ").Append(AllowedSettings).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  RequestedLevel: ").Append(RequestedLevel).Append("\n");
            sb.Append("  RequestedSettings: ").Append(RequestedSettings).Append("\n");
            sb.Append("  TransferInstruments: ").Append(TransferInstruments).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(input as AccountHolderCapability);
        }

        /// <summary>
        /// Returns true if AccountHolderCapability instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderCapability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderCapability input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed.Equals(input.Allowed)
                ) && 
                (
                    this.AllowedLevel == input.AllowedLevel ||
                    this.AllowedLevel.Equals(input.AllowedLevel)
                ) && 
                (
                    this.AllowedSettings == input.AllowedSettings ||
                    (this.AllowedSettings != null &&
                    this.AllowedSettings.Equals(input.AllowedSettings))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
                ) && 
                (
                    this.Requested == input.Requested ||
                    this.Requested.Equals(input.Requested)
                ) && 
                (
                    this.RequestedLevel == input.RequestedLevel ||
                    this.RequestedLevel.Equals(input.RequestedLevel)
                ) && 
                (
                    this.RequestedSettings == input.RequestedSettings ||
                    (this.RequestedSettings != null &&
                    this.RequestedSettings.Equals(input.RequestedSettings))
                ) && 
                (
                    this.TransferInstruments == input.TransferInstruments ||
                    this.TransferInstruments != null &&
                    input.TransferInstruments != null &&
                    this.TransferInstruments.SequenceEqual(input.TransferInstruments)
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    this.VerificationStatus.Equals(input.VerificationStatus)
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
                hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowedLevel.GetHashCode();
                if (this.AllowedSettings != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Problems != null)
                {
                    hashCode = (hashCode * 59) + this.Problems.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Requested.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestedLevel.GetHashCode();
                if (this.RequestedSettings != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedSettings.GetHashCode();
                }
                if (this.TransferInstruments != null)
                {
                    hashCode = (hashCode * 59) + this.TransferInstruments.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
