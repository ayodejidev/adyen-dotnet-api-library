/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// Payment
    /// </summary>
    [DataContract(Name = "Payment")]
    public partial class Payment : IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="hideMinorUnitsInCurrencies">Hides the minor units for the listed [ISO currency codes](https://en.wikipedia.org/wiki/ISO_4217)..</param>
        public Payment(List<string> hideMinorUnitsInCurrencies = default(List<string>))
        {
            this.HideMinorUnitsInCurrencies = hideMinorUnitsInCurrencies;
        }

        /// <summary>
        /// Hides the minor units for the listed [ISO currency codes](https://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        /// <value>Hides the minor units for the listed [ISO currency codes](https://en.wikipedia.org/wiki/ISO_4217).</value>
        [DataMember(Name = "hideMinorUnitsInCurrencies", EmitDefaultValue = false)]
        public List<string> HideMinorUnitsInCurrencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  HideMinorUnitsInCurrencies: ").Append(HideMinorUnitsInCurrencies).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HideMinorUnitsInCurrencies == input.HideMinorUnitsInCurrencies ||
                    this.HideMinorUnitsInCurrencies != null &&
                    input.HideMinorUnitsInCurrencies != null &&
                    this.HideMinorUnitsInCurrencies.SequenceEqual(input.HideMinorUnitsInCurrencies)
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
                if (this.HideMinorUnitsInCurrencies != null)
                {
                    hashCode = (hashCode * 59) + this.HideMinorUnitsInCurrencies.GetHashCode();
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
