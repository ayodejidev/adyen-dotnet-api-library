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
    /// AccountHolderInfo
    /// </summary>
    [DataContract(Name = "AccountHolderInfo")]
    public partial class AccountHolderInfo : IEquatable<AccountHolderInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountHolderInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderInfo" /> class.
        /// </summary>
        /// <param name="balancePlatform">The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms..</param>
        /// <param name="capabilities">Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, **issueCard** for Issuing. The value is an object containing the settings for the capability..</param>
        /// <param name="contactDetails">contactDetails.</param>
        /// <param name="description">Your description for the account holder..</param>
        /// <param name="legalEntityId">The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) associated with the account holder. Adyen performs a verification process against the legal entity of the account holder. (required).</param>
        /// <param name="metadata">A set of key and value pairs for general use. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="reference">Your reference for the account holder..</param>
        /// <param name="timeZone">The time zone of the account holder. For example, **Europe/Amsterdam**. Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)..</param>
        public AccountHolderInfo(string balancePlatform = default(string), Dictionary<string, AccountHolderCapability> capabilities = default(Dictionary<string, AccountHolderCapability>), ContactDetails contactDetails = default(ContactDetails), string description = default(string), string legalEntityId = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string reference = default(string), string timeZone = default(string))
        {
            this.LegalEntityId = legalEntityId;
            this.BalancePlatform = balancePlatform;
            this.Capabilities = capabilities;
            this.ContactDetails = contactDetails;
            this.Description = description;
            this.Metadata = metadata;
            this.Reference = reference;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms.
        /// </summary>
        /// <value>The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms.</value>
        [DataMember(Name = "balancePlatform", EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, **issueCard** for Issuing. The value is an object containing the settings for the capability.
        /// </summary>
        /// <value>Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, **issueCard** for Issuing. The value is an object containing the settings for the capability.</value>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Dictionary<string, AccountHolderCapability> Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name = "contactDetails", EmitDefaultValue = false)]
        [Obsolete]
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Your description for the account holder.
        /// </summary>
        /// <value>Your description for the account holder.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) associated with the account holder. Adyen performs a verification process against the legal entity of the account holder.
        /// </summary>
        /// <value>The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) associated with the account holder. Adyen performs a verification process against the legal entity of the account holder.</value>
        [DataMember(Name = "legalEntityId", IsRequired = false, EmitDefaultValue = false)]
        public string LegalEntityId { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The unique identifier of the migrated account holder in the classic integration.
        /// </summary>
        /// <value>The unique identifier of the migrated account holder in the classic integration.</value>
        [DataMember(Name = "migratedAccountHolderCode", EmitDefaultValue = false)]
        public string MigratedAccountHolderCode { get; private set; }

        /// <summary>
        /// Your reference for the account holder.
        /// </summary>
        /// <value>Your reference for the account holder.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The time zone of the account holder. For example, **Europe/Amsterdam**. Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).
        /// </summary>
        /// <value>The time zone of the account holder. For example, **Europe/Amsterdam**. Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderInfo {\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LegalEntityId: ").Append(LegalEntityId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MigratedAccountHolderCode: ").Append(MigratedAccountHolderCode).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as AccountHolderInfo);
        }

        /// <summary>
        /// Returns true if AccountHolderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.ContactDetails == input.ContactDetails ||
                    (this.ContactDetails != null &&
                    this.ContactDetails.Equals(input.ContactDetails))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LegalEntityId == input.LegalEntityId ||
                    (this.LegalEntityId != null &&
                    this.LegalEntityId.Equals(input.LegalEntityId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MigratedAccountHolderCode == input.MigratedAccountHolderCode ||
                    (this.MigratedAccountHolderCode != null &&
                    this.MigratedAccountHolderCode.Equals(input.MigratedAccountHolderCode))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.ContactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ContactDetails.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityId.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MigratedAccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.MigratedAccountHolderCode.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
