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

namespace AdobeSign.Rest.Model.Agreements
{
    /// <summary>
    /// DelegatedParticipantSetInfo
    /// </summary>
    [DataContract]
    public partial class DelegatedParticipantSetInfo :  IEquatable<DelegatedParticipantSetInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegatedParticipantSetInfo" /> class.
        /// </summary>
        /// <param name="MemberInfos">Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set.</param>
        /// <param name="PrivateMessage">Participant set&#39;s private message - all participants in the set will receive the same message. This cannot be changed as part of the PUT call..</param>
        public DelegatedParticipantSetInfo(List<DelegatedParticipantInfo> MemberInfos = default(List<DelegatedParticipantInfo>), string PrivateMessage = default(string))
        {
            this.MemberInfos = MemberInfos;
            this.PrivateMessage = PrivateMessage;
        }
        
        /// <summary>
        /// Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set
        /// </summary>
        /// <value>Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set</value>
        [DataMember(Name="memberInfos", EmitDefaultValue=false)]
        public List<DelegatedParticipantInfo> MemberInfos { get; set; }

        /// <summary>
        /// Participant set&#39;s private message - all participants in the set will receive the same message. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>Participant set&#39;s private message - all participants in the set will receive the same message. This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="privateMessage", EmitDefaultValue=false)]
        public string PrivateMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegatedParticipantSetInfo {\n");
            sb.Append("  MemberInfos: ").Append(MemberInfos).Append("\n");
            sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
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
            return this.Equals(input as DelegatedParticipantSetInfo);
        }

        /// <summary>
        /// Returns true if DelegatedParticipantSetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DelegatedParticipantSetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DelegatedParticipantSetInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MemberInfos == input.MemberInfos ||
                    this.MemberInfos != null &&
                    this.MemberInfos.SequenceEqual(input.MemberInfos)
                ) && 
                (
                    this.PrivateMessage == input.PrivateMessage ||
                    (this.PrivateMessage != null &&
                    this.PrivateMessage.Equals(input.PrivateMessage))
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
                if (this.MemberInfos != null)
                    hashCode = hashCode * 59 + this.MemberInfos.GetHashCode();
                if (this.PrivateMessage != null)
                    hashCode = hashCode * 59 + this.PrivateMessage.GetHashCode();
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
