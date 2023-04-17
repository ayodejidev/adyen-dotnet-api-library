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
    /// CardConfiguration
    /// </summary>
    [DataContract(Name = "CardConfiguration")]
    public partial class CardConfiguration : IEquatable<CardConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardConfiguration" /> class.
        /// </summary>
        /// <param name="activation">Overrides the activation label design ID defined in the &#x60;configurationProfileId&#x60;. The activation label is attached to the card and contains the activation instructions..</param>
        /// <param name="activationUrl">Your app&#39;s URL, if you want to activate cards through your app. For example, **my-app://ref1236a7d**. A QR code is created based on this URL, and is included in the carrier. Before you use this field, reach out to your Adyen contact to set up the QR code process.   Maximum length: 255 characters..</param>
        /// <param name="bulkAddress">bulkAddress.</param>
        /// <param name="cardImageId">The ID of the card image. This is the image that will be printed on the full front of the card..</param>
        /// <param name="carrier">Overrides the carrier design ID defined in the &#x60;configurationProfileId&#x60;. The carrier is the letter or packaging to which the card is attached..</param>
        /// <param name="carrierImageId">The ID of the carrier image. This is the image that will printed on the letter to which the card is attached..</param>
        /// <param name="configurationProfileId">The ID of the card configuration profile that contains the settings of the card. For example, the envelope and PIN mailer designs or the logistics company handling the shipment. All the settings in the profile are applied to the card, unless you provide other fields to override them.  For example, send the &#x60;shipmentMethod&#x60; to override the logistics company defined in the card configuration profile. (required).</param>
        /// <param name="currency">The three-letter [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) currency code of the card. For example, **EUR**..</param>
        /// <param name="envelope">Overrides the envelope design ID defined in the &#x60;configurationProfileId&#x60;. .</param>
        /// <param name="insert">Overrides the insert design ID defined in the &#x60;configurationProfileId&#x60;. An insert is any additional material, such as marketing materials, that are shipped together with the card..</param>
        /// <param name="language">The two-letter [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code of the card. For example, **en**..</param>
        /// <param name="logoImageId">The ID of the logo image. This is the image that will be printed on the partial front of the card, such as a logo on the upper right corner..</param>
        /// <param name="pinMailer">Overrides the PIN mailer design ID defined in the &#x60;configurationProfileId&#x60;. The PIN mailer is the letter on which the PIN is printed..</param>
        /// <param name="shipmentMethod">Overrides the logistics company defined in the &#x60;configurationProfileId&#x60;..</param>
        public CardConfiguration(string activation = default(string), string activationUrl = default(string), BulkAddress bulkAddress = default(BulkAddress), string cardImageId = default(string), string carrier = default(string), string carrierImageId = default(string), string configurationProfileId = default(string), string currency = default(string), string envelope = default(string), string insert = default(string), string language = default(string), string logoImageId = default(string), string pinMailer = default(string), string shipmentMethod = default(string))
        {
            this.ConfigurationProfileId = configurationProfileId;
            this.Activation = activation;
            this.ActivationUrl = activationUrl;
            this.BulkAddress = bulkAddress;
            this.CardImageId = cardImageId;
            this.Carrier = carrier;
            this.CarrierImageId = carrierImageId;
            this.Currency = currency;
            this.Envelope = envelope;
            this.Insert = insert;
            this.Language = language;
            this.LogoImageId = logoImageId;
            this.PinMailer = pinMailer;
            this.ShipmentMethod = shipmentMethod;
        }

        /// <summary>
        /// Overrides the activation label design ID defined in the &#x60;configurationProfileId&#x60;. The activation label is attached to the card and contains the activation instructions.
        /// </summary>
        /// <value>Overrides the activation label design ID defined in the &#x60;configurationProfileId&#x60;. The activation label is attached to the card and contains the activation instructions.</value>
        [DataMember(Name = "activation", EmitDefaultValue = false)]
        public string Activation { get; set; }

        /// <summary>
        /// Your app&#39;s URL, if you want to activate cards through your app. For example, **my-app://ref1236a7d**. A QR code is created based on this URL, and is included in the carrier. Before you use this field, reach out to your Adyen contact to set up the QR code process.   Maximum length: 255 characters.
        /// </summary>
        /// <value>Your app&#39;s URL, if you want to activate cards through your app. For example, **my-app://ref1236a7d**. A QR code is created based on this URL, and is included in the carrier. Before you use this field, reach out to your Adyen contact to set up the QR code process.   Maximum length: 255 characters.</value>
        [DataMember(Name = "activationUrl", EmitDefaultValue = false)]
        public string ActivationUrl { get; set; }

        /// <summary>
        /// Gets or Sets BulkAddress
        /// </summary>
        [DataMember(Name = "bulkAddress", EmitDefaultValue = false)]
        public BulkAddress BulkAddress { get; set; }

        /// <summary>
        /// The ID of the card image. This is the image that will be printed on the full front of the card.
        /// </summary>
        /// <value>The ID of the card image. This is the image that will be printed on the full front of the card.</value>
        [DataMember(Name = "cardImageId", EmitDefaultValue = false)]
        public string CardImageId { get; set; }

        /// <summary>
        /// Overrides the carrier design ID defined in the &#x60;configurationProfileId&#x60;. The carrier is the letter or packaging to which the card is attached.
        /// </summary>
        /// <value>Overrides the carrier design ID defined in the &#x60;configurationProfileId&#x60;. The carrier is the letter or packaging to which the card is attached.</value>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// The ID of the carrier image. This is the image that will printed on the letter to which the card is attached.
        /// </summary>
        /// <value>The ID of the carrier image. This is the image that will printed on the letter to which the card is attached.</value>
        [DataMember(Name = "carrierImageId", EmitDefaultValue = false)]
        public string CarrierImageId { get; set; }

        /// <summary>
        /// The ID of the card configuration profile that contains the settings of the card. For example, the envelope and PIN mailer designs or the logistics company handling the shipment. All the settings in the profile are applied to the card, unless you provide other fields to override them.  For example, send the &#x60;shipmentMethod&#x60; to override the logistics company defined in the card configuration profile.
        /// </summary>
        /// <value>The ID of the card configuration profile that contains the settings of the card. For example, the envelope and PIN mailer designs or the logistics company handling the shipment. All the settings in the profile are applied to the card, unless you provide other fields to override them.  For example, send the &#x60;shipmentMethod&#x60; to override the logistics company defined in the card configuration profile.</value>
        [DataMember(Name = "configurationProfileId", IsRequired = false, EmitDefaultValue = false)]
        public string ConfigurationProfileId { get; set; }

        /// <summary>
        /// The three-letter [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) currency code of the card. For example, **EUR**.
        /// </summary>
        /// <value>The three-letter [ISO-4217](https://en.wikipedia.org/wiki/ISO_4217) currency code of the card. For example, **EUR**.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Overrides the envelope design ID defined in the &#x60;configurationProfileId&#x60;. 
        /// </summary>
        /// <value>Overrides the envelope design ID defined in the &#x60;configurationProfileId&#x60;. </value>
        [DataMember(Name = "envelope", EmitDefaultValue = false)]
        public string Envelope { get; set; }

        /// <summary>
        /// Overrides the insert design ID defined in the &#x60;configurationProfileId&#x60;. An insert is any additional material, such as marketing materials, that are shipped together with the card.
        /// </summary>
        /// <value>Overrides the insert design ID defined in the &#x60;configurationProfileId&#x60;. An insert is any additional material, such as marketing materials, that are shipped together with the card.</value>
        [DataMember(Name = "insert", EmitDefaultValue = false)]
        public string Insert { get; set; }

        /// <summary>
        /// The two-letter [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code of the card. For example, **en**.
        /// </summary>
        /// <value>The two-letter [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code of the card. For example, **en**.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The ID of the logo image. This is the image that will be printed on the partial front of the card, such as a logo on the upper right corner.
        /// </summary>
        /// <value>The ID of the logo image. This is the image that will be printed on the partial front of the card, such as a logo on the upper right corner.</value>
        [DataMember(Name = "logoImageId", EmitDefaultValue = false)]
        public string LogoImageId { get; set; }

        /// <summary>
        /// Overrides the PIN mailer design ID defined in the &#x60;configurationProfileId&#x60;. The PIN mailer is the letter on which the PIN is printed.
        /// </summary>
        /// <value>Overrides the PIN mailer design ID defined in the &#x60;configurationProfileId&#x60;. The PIN mailer is the letter on which the PIN is printed.</value>
        [DataMember(Name = "pinMailer", EmitDefaultValue = false)]
        public string PinMailer { get; set; }

        /// <summary>
        /// Overrides the logistics company defined in the &#x60;configurationProfileId&#x60;.
        /// </summary>
        /// <value>Overrides the logistics company defined in the &#x60;configurationProfileId&#x60;.</value>
        [DataMember(Name = "shipmentMethod", EmitDefaultValue = false)]
        public string ShipmentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardConfiguration {\n");
            sb.Append("  Activation: ").Append(Activation).Append("\n");
            sb.Append("  ActivationUrl: ").Append(ActivationUrl).Append("\n");
            sb.Append("  BulkAddress: ").Append(BulkAddress).Append("\n");
            sb.Append("  CardImageId: ").Append(CardImageId).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  CarrierImageId: ").Append(CarrierImageId).Append("\n");
            sb.Append("  ConfigurationProfileId: ").Append(ConfigurationProfileId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Envelope: ").Append(Envelope).Append("\n");
            sb.Append("  Insert: ").Append(Insert).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LogoImageId: ").Append(LogoImageId).Append("\n");
            sb.Append("  PinMailer: ").Append(PinMailer).Append("\n");
            sb.Append("  ShipmentMethod: ").Append(ShipmentMethod).Append("\n");
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
            return this.Equals(input as CardConfiguration);
        }

        /// <summary>
        /// Returns true if CardConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of CardConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Activation == input.Activation ||
                    (this.Activation != null &&
                    this.Activation.Equals(input.Activation))
                ) && 
                (
                    this.ActivationUrl == input.ActivationUrl ||
                    (this.ActivationUrl != null &&
                    this.ActivationUrl.Equals(input.ActivationUrl))
                ) && 
                (
                    this.BulkAddress == input.BulkAddress ||
                    (this.BulkAddress != null &&
                    this.BulkAddress.Equals(input.BulkAddress))
                ) && 
                (
                    this.CardImageId == input.CardImageId ||
                    (this.CardImageId != null &&
                    this.CardImageId.Equals(input.CardImageId))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.CarrierImageId == input.CarrierImageId ||
                    (this.CarrierImageId != null &&
                    this.CarrierImageId.Equals(input.CarrierImageId))
                ) && 
                (
                    this.ConfigurationProfileId == input.ConfigurationProfileId ||
                    (this.ConfigurationProfileId != null &&
                    this.ConfigurationProfileId.Equals(input.ConfigurationProfileId))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Envelope == input.Envelope ||
                    (this.Envelope != null &&
                    this.Envelope.Equals(input.Envelope))
                ) && 
                (
                    this.Insert == input.Insert ||
                    (this.Insert != null &&
                    this.Insert.Equals(input.Insert))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LogoImageId == input.LogoImageId ||
                    (this.LogoImageId != null &&
                    this.LogoImageId.Equals(input.LogoImageId))
                ) && 
                (
                    this.PinMailer == input.PinMailer ||
                    (this.PinMailer != null &&
                    this.PinMailer.Equals(input.PinMailer))
                ) && 
                (
                    this.ShipmentMethod == input.ShipmentMethod ||
                    (this.ShipmentMethod != null &&
                    this.ShipmentMethod.Equals(input.ShipmentMethod))
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
                if (this.Activation != null)
                {
                    hashCode = (hashCode * 59) + this.Activation.GetHashCode();
                }
                if (this.ActivationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActivationUrl.GetHashCode();
                }
                if (this.BulkAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BulkAddress.GetHashCode();
                }
                if (this.CardImageId != null)
                {
                    hashCode = (hashCode * 59) + this.CardImageId.GetHashCode();
                }
                if (this.Carrier != null)
                {
                    hashCode = (hashCode * 59) + this.Carrier.GetHashCode();
                }
                if (this.CarrierImageId != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierImageId.GetHashCode();
                }
                if (this.ConfigurationProfileId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationProfileId.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Envelope != null)
                {
                    hashCode = (hashCode * 59) + this.Envelope.GetHashCode();
                }
                if (this.Insert != null)
                {
                    hashCode = (hashCode * 59) + this.Insert.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.LogoImageId != null)
                {
                    hashCode = (hashCode * 59) + this.LogoImageId.GetHashCode();
                }
                if (this.PinMailer != null)
                {
                    hashCode = (hashCode * 59) + this.PinMailer.GetHashCode();
                }
                if (this.ShipmentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.ShipmentMethod.GetHashCode();
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
            // ActivationUrl (string) maxLength
            if (this.ActivationUrl != null && this.ActivationUrl.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivationUrl, length must be less than 255.", new [] { "ActivationUrl" });
            }

            yield break;
        }
    }

}
