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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using SwaggerDateConverter = AdobeSign.Rest.Client.SwaggerDateConverter;

namespace AdobeSign.Rest.Model.Groups
{
    /// <summary>
    /// DetailedGroupInfo
    /// </summary>
    [DataContract]
    public partial class DetailedGroupInfo :  IEquatable<DetailedGroupInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedGroupInfo" /> class.
        /// </summary>
        /// <param name="Created">Date of creation of the group. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="Id">The unique identifier of the Group. This will be returned as part of GET call but is not mandatory to be passed as part of PUT/POST call for groups/{groupId}.</param>
        /// <param name="Name">Name of the group.</param>
        public DetailedGroupInfo(DateTime? Created = default(DateTime?), string Id = default(string), string Name = default(string))
        {
            this.Created = Created;
            this.Id = Id;
            this.Name = Name;
        }
        
        /// <summary>
        /// Date of creation of the group. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>Date of creation of the group. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The unique identifier of the Group. This will be returned as part of GET call but is not mandatory to be passed as part of PUT/POST call for groups/{groupId}
        /// </summary>
        /// <value>The unique identifier of the Group. This will be returned as part of GET call but is not mandatory to be passed as part of PUT/POST call for groups/{groupId}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the group
        /// </summary>
        /// <value>Name of the group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedGroupInfo {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as DetailedGroupInfo);
        }

        /// <summary>
        /// Returns true if DetailedGroupInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedGroupInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedGroupInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
