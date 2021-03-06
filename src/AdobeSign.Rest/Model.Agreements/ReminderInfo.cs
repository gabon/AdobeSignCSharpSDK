/**
*  Copyright 2019 Adobe Systems Incorporated. All rights reserved.
*  This file is licensed to you under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License. You may obtain a copy
*  of the License at http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software distributed under
*  the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
*  OF ANY KIND, either express or implied. See the License for the specific language
*  governing permissions and limitations under the License.
*
*
**/


/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 6.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = AdobeSign.Rest.Client.SwaggerDateConverter;

namespace AdobeSign.Rest.Model.Agreements
{
    /// <summary>
    /// ReminderInfo
    /// </summary>
    [DataContract]
    public partial class ReminderInfo :  IEquatable<ReminderInfo>, IValidatableObject
    {
        /// <summary>
        /// The frequency at which reminder will be sent until the agreement is completed.&lt;br&gt;If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT
        /// </summary>
        /// <value>The frequency at which reminder will be sent until the agreement is completed.&lt;br&gt;If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            
            /// <summary>
            /// Enum DAILYUNTILSIGNED for value: DAILY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
            DAILYUNTILSIGNED = 1,
            
            /// <summary>
            /// Enum WEEKDAILYUNTILSIGNED for value: WEEKDAILY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "WEEKDAILY_UNTIL_SIGNED")]
            WEEKDAILYUNTILSIGNED = 2,
            
            /// <summary>
            /// Enum EVERYOTHERDAYUNTILSIGNED for value: EVERY_OTHER_DAY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "EVERY_OTHER_DAY_UNTIL_SIGNED")]
            EVERYOTHERDAYUNTILSIGNED = 3,
            
            /// <summary>
            /// Enum EVERYTHIRDDAYUNTILSIGNED for value: EVERY_THIRD_DAY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "EVERY_THIRD_DAY_UNTIL_SIGNED")]
            EVERYTHIRDDAYUNTILSIGNED = 4,
            
            /// <summary>
            /// Enum EVERYFIFTHDAYUNTILSIGNED for value: EVERY_FIFTH_DAY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "EVERY_FIFTH_DAY_UNTIL_SIGNED")]
            EVERYFIFTHDAYUNTILSIGNED = 5,
            
            /// <summary>
            /// Enum WEEKLYUNTILSIGNED for value: WEEKLY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
            WEEKLYUNTILSIGNED = 6,
            
            /// <summary>
            /// Enum ONCE for value: ONCE
            /// </summary>
            [EnumMember(Value = "ONCE")]
            ONCE = 7
        }

        /// <summary>
        /// The frequency at which reminder will be sent until the agreement is completed.&lt;br&gt;If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT
        /// </summary>
        /// <value>The frequency at which reminder will be sent until the agreement is completed.&lt;br&gt;If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Reminder can be sent based on when the agreement becomes available or when the reminder is created&lt;br&gt;AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.&lt;br&gt;REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.&lt;br&gt;Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT
        /// </summary>
        /// <value>Reminder can be sent based on when the agreement becomes available or when the reminder is created&lt;br&gt;AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.&lt;br&gt;REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.&lt;br&gt;Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StartReminderCounterFromEnum
        {
            
            /// <summary>
            /// Enum AGREEMENTAVAILABILITY for value: AGREEMENT_AVAILABILITY
            /// </summary>
            [EnumMember(Value = "AGREEMENT_AVAILABILITY")]
            AGREEMENTAVAILABILITY = 1,
            
            /// <summary>
            /// Enum REMINDERCREATION for value: REMINDER_CREATION
            /// </summary>
            [EnumMember(Value = "REMINDER_CREATION")]
            REMINDERCREATION = 2
        }

        /// <summary>
        /// Reminder can be sent based on when the agreement becomes available or when the reminder is created&lt;br&gt;AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.&lt;br&gt;REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.&lt;br&gt;Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT
        /// </summary>
        /// <value>Reminder can be sent based on when the agreement becomes available or when the reminder is created&lt;br&gt;AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.&lt;br&gt;REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.&lt;br&gt;Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT</value>
        [DataMember(Name="startReminderCounterFrom", EmitDefaultValue=false)]
        public StartReminderCounterFromEnum? StartReminderCounterFrom { get; set; }
        /// <summary>
        /// Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST.
        /// </summary>
        /// <value>Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,
            
            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED = 2,
            
            /// <summary>
            /// Enum COMPLETE for value: COMPLETE
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            COMPLETE = 3
        }

        /// <summary>
        /// Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST.
        /// </summary>
        /// <value>Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReminderInfo" /> class.
        /// </summary>
        /// <param name="FirstReminderDelay">Integer which specifies the delay in hours before sending the first reminder.&lt;br&gt;This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.&lt;br&gt;If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.&lt;br&gt;i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT.</param>
        /// <param name="Frequency">The frequency at which reminder will be sent until the agreement is completed.&lt;br&gt;If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT.</param>
        /// <param name="LastSentDate">The date when the reminder was last sent. Only provided in GET. Cannot be provided in POST request. If provided in POST, it will be ignored. Cannot be updated in a PUT. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="NextSentDate">The date when the reminder is scheduled to be sent next. When provided in POST request, frequency needs to be ONCE (or not specified), startReminderCounterFrom needs to be REMINDER_CREATION (or not specified) and firstReminderDelay needs to be 0 (or not specified). Cannot be updated in a PUT. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="Note">An optional message sent to the recipients, describing why their participation is required.</param>
        /// <param name="RecipientParticipantIds">A list of one or more participant IDs that the reminder should be sent to. These must be recipients of the agreement and not sharees or cc&#39;s..</param>
        /// <param name="ReminderId">An identifier of the reminder resource created on the server. If provided in POST or PUT, it will be ignored.</param>
        /// <param name="StartReminderCounterFrom">Reminder can be sent based on when the agreement becomes available or when the reminder is created&lt;br&gt;AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.&lt;br&gt;REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.&lt;br&gt;Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT.</param>
        /// <param name="Status">Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST..</param>
        public ReminderInfo(int? FirstReminderDelay = default(int?), FrequencyEnum? Frequency = default(FrequencyEnum?), DateTime? LastSentDate = default(DateTime?), DateTime? NextSentDate = default(DateTime?), string Note = default(string), List<string> RecipientParticipantIds = default(List<string>), string ReminderId = default(string), StartReminderCounterFromEnum? StartReminderCounterFrom = default(StartReminderCounterFromEnum?), StatusEnum? Status = default(StatusEnum?))
        {
            this.FirstReminderDelay = FirstReminderDelay;
            this.Frequency = Frequency;
            this.LastSentDate = LastSentDate;
            this.NextSentDate = NextSentDate;
            this.Note = Note;
            this.RecipientParticipantIds = RecipientParticipantIds;
            this.ReminderId = ReminderId;
            this.StartReminderCounterFrom = StartReminderCounterFrom;
            this.Status = Status;
        }
        
        /// <summary>
        /// Integer which specifies the delay in hours before sending the first reminder.&lt;br&gt;This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.&lt;br&gt;If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.&lt;br&gt;i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT
        /// </summary>
        /// <value>Integer which specifies the delay in hours before sending the first reminder.&lt;br&gt;This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.&lt;br&gt;If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.&lt;br&gt;i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT</value>
        [DataMember(Name="firstReminderDelay", EmitDefaultValue=false)]
        public int? FirstReminderDelay { get; set; }


        /// <summary>
        /// The date when the reminder was last sent. Only provided in GET. Cannot be provided in POST request. If provided in POST, it will be ignored. Cannot be updated in a PUT. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>The date when the reminder was last sent. Only provided in GET. Cannot be provided in POST request. If provided in POST, it will be ignored. Cannot be updated in a PUT. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="lastSentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastSentDate { get; set; }

        /// <summary>
        /// The date when the reminder is scheduled to be sent next. When provided in POST request, frequency needs to be ONCE (or not specified), startReminderCounterFrom needs to be REMINDER_CREATION (or not specified) and firstReminderDelay needs to be 0 (or not specified). Cannot be updated in a PUT. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>The date when the reminder is scheduled to be sent next. When provided in POST request, frequency needs to be ONCE (or not specified), startReminderCounterFrom needs to be REMINDER_CREATION (or not specified) and firstReminderDelay needs to be 0 (or not specified). Cannot be updated in a PUT. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="nextSentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? NextSentDate { get; set; }

        /// <summary>
        /// An optional message sent to the recipients, describing why their participation is required
        /// </summary>
        /// <value>An optional message sent to the recipients, describing why their participation is required</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// A list of one or more participant IDs that the reminder should be sent to. These must be recipients of the agreement and not sharees or cc&#39;s.
        /// </summary>
        /// <value>A list of one or more participant IDs that the reminder should be sent to. These must be recipients of the agreement and not sharees or cc&#39;s.</value>
        [DataMember(Name="recipientParticipantIds", EmitDefaultValue=false)]
        public List<string> RecipientParticipantIds { get; set; }

        /// <summary>
        /// An identifier of the reminder resource created on the server. If provided in POST or PUT, it will be ignored
        /// </summary>
        /// <value>An identifier of the reminder resource created on the server. If provided in POST or PUT, it will be ignored</value>
        [DataMember(Name="reminderId", EmitDefaultValue=false)]
        public string ReminderId { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReminderInfo {\n");
            sb.Append("  FirstReminderDelay: ").Append(FirstReminderDelay).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  LastSentDate: ").Append(LastSentDate).Append("\n");
            sb.Append("  NextSentDate: ").Append(NextSentDate).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  RecipientParticipantIds: ").Append(RecipientParticipantIds).Append("\n");
            sb.Append("  ReminderId: ").Append(ReminderId).Append("\n");
            sb.Append("  StartReminderCounterFrom: ").Append(StartReminderCounterFrom).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ReminderInfo);
        }

        /// <summary>
        /// Returns true if ReminderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReminderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReminderInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstReminderDelay == input.FirstReminderDelay ||
                    (this.FirstReminderDelay != null &&
                    this.FirstReminderDelay.Equals(input.FirstReminderDelay))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.LastSentDate == input.LastSentDate ||
                    (this.LastSentDate != null &&
                    this.LastSentDate.Equals(input.LastSentDate))
                ) && 
                (
                    this.NextSentDate == input.NextSentDate ||
                    (this.NextSentDate != null &&
                    this.NextSentDate.Equals(input.NextSentDate))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.RecipientParticipantIds == input.RecipientParticipantIds ||
                    this.RecipientParticipantIds != null &&
                    this.RecipientParticipantIds.SequenceEqual(input.RecipientParticipantIds)
                ) && 
                (
                    this.ReminderId == input.ReminderId ||
                    (this.ReminderId != null &&
                    this.ReminderId.Equals(input.ReminderId))
                ) && 
                (
                    this.StartReminderCounterFrom == input.StartReminderCounterFrom ||
                    (this.StartReminderCounterFrom != null &&
                    this.StartReminderCounterFrom.Equals(input.StartReminderCounterFrom))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.FirstReminderDelay != null)
                    hashCode = hashCode * 59 + this.FirstReminderDelay.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.LastSentDate != null)
                    hashCode = hashCode * 59 + this.LastSentDate.GetHashCode();
                if (this.NextSentDate != null)
                    hashCode = hashCode * 59 + this.NextSentDate.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.RecipientParticipantIds != null)
                    hashCode = hashCode * 59 + this.RecipientParticipantIds.GetHashCode();
                if (this.ReminderId != null)
                    hashCode = hashCode * 59 + this.ReminderId.GetHashCode();
                if (this.StartReminderCounterFrom != null)
                    hashCode = hashCode * 59 + this.StartReminderCounterFrom.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
