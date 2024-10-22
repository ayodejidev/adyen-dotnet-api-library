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
    /// AfterpayDetails
    /// </summary>
    [DataContract(Name = "AfterpayDetails")]
    public partial class AfterpayDetails : IEquatable<AfterpayDetails>, IValidatableObject
    {
        /// <summary>
        /// **afterpay_default**
        /// </summary>
        /// <value>**afterpay_default**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AfterpayDefault for value: afterpay_default
            /// </summary>
            [EnumMember(Value = "afterpay_default")]
            AfterpayDefault = 1,

            /// <summary>
            /// Enum Afterpaytouch for value: afterpaytouch
            /// </summary>
            [EnumMember(Value = "afterpaytouch")]
            Afterpaytouch = 2,

            /// <summary>
            /// Enum AfterpayB2b for value: afterpay_b2b
            /// </summary>
            [EnumMember(Value = "afterpay_b2b")]
            AfterpayB2b = 3,

            /// <summary>
            /// Enum Clearpay for value: clearpay
            /// </summary>
            [EnumMember(Value = "clearpay")]
            Clearpay = 4

        }


        /// <summary>
        /// **afterpay_default**
        /// </summary>
        /// <value>**afterpay_default**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AfterpayDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AfterpayDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AfterpayDetails" /> class.
        /// </summary>
        /// <param name="billingAddress">The address where to send the invoice..</param>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="deliveryAddress">The address where the goods should be delivered..</param>
        /// <param name="personalDetails">Shopper name, date of birth, phone number, and email address..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**afterpay_default** (required) (default to TypeEnum.AfterpayDefault).</param>
        public AfterpayDetails(string billingAddress = default(string), string checkoutAttemptId = default(string), string deliveryAddress = default(string), string personalDetails = default(string), string recurringDetailReference = default(string), string storedPaymentMethodId = default(string), TypeEnum type = TypeEnum.AfterpayDefault)
        {
            this.Type = type;
            this.BillingAddress = billingAddress;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.DeliveryAddress = deliveryAddress;
            this.PersonalDetails = personalDetails;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
        }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        /// <value>The address where to send the invoice.</value>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The address where the goods should be delivered.
        /// </summary>
        /// <value>The address where the goods should be delivered.</value>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Shopper name, date of birth, phone number, and email address.
        /// </summary>
        /// <value>Shopper name, date of birth, phone number, and email address.</value>
        [DataMember(Name = "personalDetails", EmitDefaultValue = false)]
        public string PersonalDetails { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [Obsolete("Deprecated since Adyen Checkout API v49. Use `storedPaymentMethodId` instead.")]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AfterpayDetails {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
            return this.Equals(input as AfterpayDetails);
        }

        /// <summary>
        /// Returns true if AfterpayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AfterpayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AfterpayDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) && 
                (
                    this.PersonalDetails == input.PersonalDetails ||
                    (this.PersonalDetails != null &&
                    this.PersonalDetails.Equals(input.PersonalDetails))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
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
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.DeliveryAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAddress.GetHashCode();
                }
                if (this.PersonalDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalDetails.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
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
            // StoredPaymentMethodId (string) maxLength
            if (this.StoredPaymentMethodId != null && this.StoredPaymentMethodId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoredPaymentMethodId, length must be less than 64.", new [] { "StoredPaymentMethodId" });
            }

            yield break;
        }
    }

}
