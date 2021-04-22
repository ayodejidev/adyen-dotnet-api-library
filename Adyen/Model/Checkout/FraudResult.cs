#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// FraudResult
    /// </summary>
    [DataContract]
    public partial class FraudResult : IEquatable<FraudResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudResult" /> class.
        /// </summary>
        /// <param name="AccountScore">The total fraud score generated by the risk checks. (required).</param>
        /// <param name="Results">The result of the individual risk checks..</param>
        public FraudResult(int? AccountScore = default(int?), List<FraudCheckResultContainer> Results = default(List<FraudCheckResultContainer>))
        {
            // to ensure "AccountScore" is required (not null)
            if (AccountScore == null)
            {
                throw new InvalidDataException("AccountScore is a required property for FraudResult and cannot be null");
            }
            else
            {
                this.AccountScore = AccountScore;
            }
            this.Results = Results;
        }

        /// <summary>
        /// The total fraud score generated by the risk checks.
        /// </summary>
        /// <value>The total fraud score generated by the risk checks.</value>
        [DataMember(Name = "accountScore", EmitDefaultValue = false)]
        public int? AccountScore { get; set; }

        /// <summary>
        /// The result of the individual risk checks.
        /// </summary>
        /// <value>The result of the individual risk checks.</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<FraudCheckResultContainer> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudResult {\n");
            sb.Append("  AccountScore: ").Append(AccountScore).Append("\n");
            sb.Append("  Results: ").Append(Results.ObjectListToString()).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FraudResult);
        }

        /// <summary>
        /// Returns true if FraudResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountScore == input.AccountScore ||
                    (this.AccountScore != null &&
                    this.AccountScore.Equals(input.AccountScore))
                ) &&
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.AccountScore != null)
                    hashCode = hashCode * 59 + this.AccountScore.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}