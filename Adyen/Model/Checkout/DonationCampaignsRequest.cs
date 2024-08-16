/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DonationCampaignsRequest
    /// </summary>
    [DataContract(Name = "DonationCampaignsRequest")]
    public partial class DonationCampaignsRequest : IEquatable<DonationCampaignsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationCampaignsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DonationCampaignsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationCampaignsRequest" /> class.
        /// </summary>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes/). (required).</param>
        /// <param name="locale">Locale on the shopper interaction device..</param>
        /// <param name="merchantAccount">Your merchant account identifier. (required).</param>
        public DonationCampaignsRequest(string currency = default(string), string locale = default(string), string merchantAccount = default(string))
        {
            this.Currency = currency;
            this.MerchantAccount = merchantAccount;
            this.Locale = locale;
        }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes/).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes/).</value>
        [DataMember(Name = "currency", IsRequired = false, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Locale on the shopper interaction device.
        /// </summary>
        /// <value>Locale on the shopper interaction device.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Your merchant account identifier.
        /// </summary>
        /// <value>Your merchant account identifier.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DonationCampaignsRequest {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
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
            return this.Equals(input as DonationCampaignsRequest);
        }

        /// <summary>
        /// Returns true if DonationCampaignsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DonationCampaignsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DonationCampaignsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
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
