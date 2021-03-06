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

namespace AdobeSign.Rest.Model.Groups
{
    /// <summary>
    /// GroupsInfo
    /// </summary>
    [DataContract]
    public partial class GroupsInfo :  IEquatable<GroupsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsInfo" /> class.
        /// </summary>
        /// <param name="GroupInfoList">The list of groups in the account..</param>
        /// <param name="Page">Pagination information for navigating through the response.</param>
        public GroupsInfo(List<GroupInfo> GroupInfoList = default(List<GroupInfo>), PageInfo Page = default(PageInfo))
        {
            this.GroupInfoList = GroupInfoList;
            this.Page = Page;
        }
        
        /// <summary>
        /// The list of groups in the account.
        /// </summary>
        /// <value>The list of groups in the account.</value>
        [DataMember(Name="groupInfoList", EmitDefaultValue=false)]
        public List<GroupInfo> GroupInfoList { get; set; }

        /// <summary>
        /// Pagination information for navigating through the response
        /// </summary>
        /// <value>Pagination information for navigating through the response</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public PageInfo Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsInfo {\n");
            sb.Append("  GroupInfoList: ").Append(GroupInfoList).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as GroupsInfo);
        }

        /// <summary>
        /// Returns true if GroupsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupInfoList == input.GroupInfoList ||
                    this.GroupInfoList != null &&
                    this.GroupInfoList.SequenceEqual(input.GroupInfoList)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.GroupInfoList != null)
                    hashCode = hashCode * 59 + this.GroupInfoList.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
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
