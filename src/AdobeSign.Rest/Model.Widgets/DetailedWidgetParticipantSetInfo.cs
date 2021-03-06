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

namespace AdobeSign.Rest.Model.Widgets
{
    /// <summary>
    /// DetailedWidgetParticipantSetInfo
    /// </summary>
    [DataContract]
    public partial class DetailedWidgetParticipantSetInfo :  IEquatable<DetailedWidgetParticipantSetInfo>, IValidatableObject
    {
        /// <summary>
        /// Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum SIGNER for value: SIGNER
            /// </summary>
            [EnumMember(Value = "SIGNER")]
            SIGNER = 1,
            
            /// <summary>
            /// Enum SENDER for value: SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDER = 2,
            
            /// <summary>
            /// Enum APPROVER for value: APPROVER
            /// </summary>
            [EnumMember(Value = "APPROVER")]
            APPROVER = 3,
            
            /// <summary>
            /// Enum ACCEPTOR for value: ACCEPTOR
            /// </summary>
            [EnumMember(Value = "ACCEPTOR")]
            ACCEPTOR = 4,
            
            /// <summary>
            /// Enum CERTIFIEDRECIPIENT for value: CERTIFIED_RECIPIENT
            /// </summary>
            [EnumMember(Value = "CERTIFIED_RECIPIENT")]
            CERTIFIEDRECIPIENT = 5,
            
            /// <summary>
            /// Enum FORMFILLER for value: FORM_FILLER
            /// </summary>
            [EnumMember(Value = "FORM_FILLER")]
            FORMFILLER = 6,
            
            /// <summary>
            /// Enum DELEGATETOSIGNER for value: DELEGATE_TO_SIGNER
            /// </summary>
            [EnumMember(Value = "DELEGATE_TO_SIGNER")]
            DELEGATETOSIGNER = 7,
            
            /// <summary>
            /// Enum DELEGATETOAPPROVER for value: DELEGATE_TO_APPROVER
            /// </summary>
            [EnumMember(Value = "DELEGATE_TO_APPROVER")]
            DELEGATETOAPPROVER = 8,
            
            /// <summary>
            /// Enum DELEGATETOACCEPTOR for value: DELEGATE_TO_ACCEPTOR
            /// </summary>
            [EnumMember(Value = "DELEGATE_TO_ACCEPTOR")]
            DELEGATETOACCEPTOR = 9,
            
            /// <summary>
            /// Enum DELEGATETOCERTIFIEDRECIPIENT for value: DELEGATE_TO_CERTIFIED_RECIPIENT
            /// </summary>
            [EnumMember(Value = "DELEGATE_TO_CERTIFIED_RECIPIENT")]
            DELEGATETOCERTIFIEDRECIPIENT = 10,
            
            /// <summary>
            /// Enum DELEGATETOFORMFILLER for value: DELEGATE_TO_FORM_FILLER
            /// </summary>
            [EnumMember(Value = "DELEGATE_TO_FORM_FILLER")]
            DELEGATETOFORMFILLER = 11,
            
            /// <summary>
            /// Enum SHARE for value: SHARE
            /// </summary>
            [EnumMember(Value = "SHARE")]
            SHARE = 12
        }

        /// <summary>
        /// Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedWidgetParticipantSetInfo" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier of the participant set. This cannot be changed as part of the PUT call..</param>
        /// <param name="MemberInfos">Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set.</param>
        /// <param name="Order">Index indicating sequential signing group (specified for hybrid routing). This cannot be changed as part of the PUT call..</param>
        /// <param name="Role">Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call..</param>
        public DetailedWidgetParticipantSetInfo(string Id = default(string), List<DetailedParticipantInfo> MemberInfos = default(List<DetailedParticipantInfo>), int? Order = default(int?), RoleEnum? Role = default(RoleEnum?))
        {
            this.Id = Id;
            this.MemberInfos = MemberInfos;
            this.Order = Order;
            this.Role = Role;
        }
        
        /// <summary>
        /// The unique identifier of the participant set. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>The unique identifier of the participant set. This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set
        /// </summary>
        /// <value>Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set</value>
        [DataMember(Name="memberInfos", EmitDefaultValue=false)]
        public List<DetailedParticipantInfo> MemberInfos { get; set; }

        /// <summary>
        /// Index indicating sequential signing group (specified for hybrid routing). This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>Index indicating sequential signing group (specified for hybrid routing). This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedWidgetParticipantSetInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberInfos: ").Append(MemberInfos).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as DetailedWidgetParticipantSetInfo);
        }

        /// <summary>
        /// Returns true if DetailedWidgetParticipantSetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedWidgetParticipantSetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedWidgetParticipantSetInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MemberInfos == input.MemberInfos ||
                    this.MemberInfos != null &&
                    this.MemberInfos.SequenceEqual(input.MemberInfos)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemberInfos != null)
                    hashCode = hashCode * 59 + this.MemberInfos.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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
