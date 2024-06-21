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
    /// SweepSchedule
    /// </summary>
    [DataContract(Name = "SweepSchedule")]
    public partial class SweepSchedule : IEquatable<SweepSchedule>, IValidatableObject
    {
        /// <summary>
        /// The schedule type.  Possible values:  * **cron**: push out funds based on a &#x60;cronExpression&#x60;.  * **daily**: push out funds daily at 07:00 AM CET.  * **weekly**: push out funds every Monday at 07:00 AM CET.  * **monthly**: push out funds every first of the month at 07:00 AM CET.  * **balance**: execute the sweep instantly if the &#x60;triggerAmount&#x60; is reached. 
        /// </summary>
        /// <value>The schedule type.  Possible values:  * **cron**: push out funds based on a &#x60;cronExpression&#x60;.  * **daily**: push out funds daily at 07:00 AM CET.  * **weekly**: push out funds every Monday at 07:00 AM CET.  * **monthly**: push out funds every first of the month at 07:00 AM CET.  * **balance**: execute the sweep instantly if the &#x60;triggerAmount&#x60; is reached. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum Balance for value: balance
            /// </summary>
            [EnumMember(Value = "balance")]
            Balance = 4,

            /// <summary>
            /// Enum Cron for value: cron
            /// </summary>
            [EnumMember(Value = "cron")]
            Cron = 5

        }


        /// <summary>
        /// The schedule type.  Possible values:  * **cron**: push out funds based on a &#x60;cronExpression&#x60;.  * **daily**: push out funds daily at 07:00 AM CET.  * **weekly**: push out funds every Monday at 07:00 AM CET.  * **monthly**: push out funds every first of the month at 07:00 AM CET.  * **balance**: execute the sweep instantly if the &#x60;triggerAmount&#x60; is reached. 
        /// </summary>
        /// <value>The schedule type.  Possible values:  * **cron**: push out funds based on a &#x60;cronExpression&#x60;.  * **daily**: push out funds daily at 07:00 AM CET.  * **weekly**: push out funds every Monday at 07:00 AM CET.  * **monthly**: push out funds every first of the month at 07:00 AM CET.  * **balance**: execute the sweep instantly if the &#x60;triggerAmount&#x60; is reached. </value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SweepSchedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepSchedule" /> class.
        /// </summary>
        /// <param name="cronExpression">A [cron expression](https://en.wikipedia.org/wiki/Cron#CRON_expression) that is used to set the sweep schedule. The schedule uses the time zone of the balance account.  For example, **30 17 * * MON** schedules a sweep every Monday at 17:30.  The expression must have five values separated by a single space in the following order:  * Minute: **0-59**  * Hour: **0-23**  * Day of the month: **1-31**  * Month: **1-12** or **JAN-DEC**  * Day of the week: **0-7** (0 and 7 are Sunday) or **MON-SUN**.  The following non-standard characters are supported: **&amp;ast;**, **L**, **#**, **W** and **_/_**. See [crontab guru](https://crontab.guru/) for more examples.  Required when &#x60;type&#x60; is **cron**. .</param>
        /// <param name="type">The schedule type.  Possible values:  * **cron**: push out funds based on a &#x60;cronExpression&#x60;.  * **daily**: push out funds daily at 07:00 AM CET.  * **weekly**: push out funds every Monday at 07:00 AM CET.  * **monthly**: push out funds every first of the month at 07:00 AM CET.  * **balance**: execute the sweep instantly if the &#x60;triggerAmount&#x60; is reached.  (required).</param>
        public SweepSchedule(string cronExpression = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Type = type;
            this.CronExpression = cronExpression;
        }

        /// <summary>
        /// A [cron expression](https://en.wikipedia.org/wiki/Cron#CRON_expression) that is used to set the sweep schedule. The schedule uses the time zone of the balance account.  For example, **30 17 * * MON** schedules a sweep every Monday at 17:30.  The expression must have five values separated by a single space in the following order:  * Minute: **0-59**  * Hour: **0-23**  * Day of the month: **1-31**  * Month: **1-12** or **JAN-DEC**  * Day of the week: **0-7** (0 and 7 are Sunday) or **MON-SUN**.  The following non-standard characters are supported: **&amp;ast;**, **L**, **#**, **W** and **_/_**. See [crontab guru](https://crontab.guru/) for more examples.  Required when &#x60;type&#x60; is **cron**. 
        /// </summary>
        /// <value>A [cron expression](https://en.wikipedia.org/wiki/Cron#CRON_expression) that is used to set the sweep schedule. The schedule uses the time zone of the balance account.  For example, **30 17 * * MON** schedules a sweep every Monday at 17:30.  The expression must have five values separated by a single space in the following order:  * Minute: **0-59**  * Hour: **0-23**  * Day of the month: **1-31**  * Month: **1-12** or **JAN-DEC**  * Day of the week: **0-7** (0 and 7 are Sunday) or **MON-SUN**.  The following non-standard characters are supported: **&amp;ast;**, **L**, **#**, **W** and **_/_**. See [crontab guru](https://crontab.guru/) for more examples.  Required when &#x60;type&#x60; is **cron**. </value>
        [DataMember(Name = "cronExpression", EmitDefaultValue = false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SweepSchedule {\n");
            sb.Append("  CronExpression: ").Append(CronExpression).Append("\n");
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
            return this.Equals(input as SweepSchedule);
        }

        /// <summary>
        /// Returns true if SweepSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepSchedule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CronExpression == input.CronExpression ||
                    (this.CronExpression != null &&
                    this.CronExpression.Equals(input.CronExpression))
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
                if (this.CronExpression != null)
                {
                    hashCode = (hashCode * 59) + this.CronExpression.GetHashCode();
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
