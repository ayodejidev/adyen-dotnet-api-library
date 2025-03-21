/*
* Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// PayToInfo
    /// </summary>
    [DataContract(Name = "PayToInfo")]
    public partial class PayToInfo : IEquatable<PayToInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayToInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayToInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayToInfo" /> class.
        /// </summary>
        /// <param name="merchantName">Merchant name displayed to the shopper in the Agreements (required).</param>
        /// <param name="payToPurpose">Represents the purpose of the Agreements created, it relates to the business type **Allowed values**: mortgage, utility, loan, gambling, retail, salary, personal, government, pension, tax, other (required).</param>
        public PayToInfo(string merchantName = default(string), string payToPurpose = default(string))
        {
            this.MerchantName = merchantName;
            this.PayToPurpose = payToPurpose;
        }

        /// <summary>
        /// Merchant name displayed to the shopper in the Agreements
        /// </summary>
        /// <value>Merchant name displayed to the shopper in the Agreements</value>
        [DataMember(Name = "merchantName", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Represents the purpose of the Agreements created, it relates to the business type **Allowed values**: mortgage, utility, loan, gambling, retail, salary, personal, government, pension, tax, other
        /// </summary>
        /// <value>Represents the purpose of the Agreements created, it relates to the business type **Allowed values**: mortgage, utility, loan, gambling, retail, salary, personal, government, pension, tax, other</value>
        [DataMember(Name = "payToPurpose", IsRequired = false, EmitDefaultValue = false)]
        public string PayToPurpose { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayToInfo {\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  PayToPurpose: ").Append(PayToPurpose).Append("\n");
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
            return this.Equals(input as PayToInfo);
        }

        /// <summary>
        /// Returns true if PayToInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PayToInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayToInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.PayToPurpose == input.PayToPurpose ||
                    (this.PayToPurpose != null &&
                    this.PayToPurpose.Equals(input.PayToPurpose))
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
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.PayToPurpose != null)
                {
                    hashCode = (hashCode * 59) + this.PayToPurpose.GetHashCode();
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
