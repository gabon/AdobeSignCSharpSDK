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
using Newtonsoft.Json.Converters;

namespace AdobeSign.Rest.Model.Widgets
{
    /// <summary>
    /// WidgetViewInfo
    /// </summary>
    [DataContract]
    public partial class WidgetViewInfo :  IEquatable<WidgetViewInfo>, IValidatableObject
    {
        /// <summary>
        /// Name of the requested widget view
        /// </summary>
        /// <value>Name of the requested widget view</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum AUTHORING for value: AUTHORING
            /// </summary>
            [EnumMember(Value = "AUTHORING")]
            AUTHORING = 1,
            
            /// <summary>
            /// Enum DOCUMENT for value: DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENT = 2,
            
            /// <summary>
            /// Enum MANAGE for value: MANAGE
            /// </summary>
            [EnumMember(Value = "MANAGE")]
            MANAGE = 3,
            
            /// <summary>
            /// Enum POSTCREATE for value: POST_CREATE
            /// </summary>
            [EnumMember(Value = "POST_CREATE")]
            POSTCREATE = 4,
            
            /// <summary>
            /// Enum SIGNING for value: SIGNING
            /// </summary>
            [EnumMember(Value = "SIGNING")]
            SIGNING = 5,
            
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 6
        }

        /// <summary>
        /// Name of the requested widget view
        /// </summary>
        /// <value>Name of the requested widget view</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetViewInfo" /> class.
        /// </summary>
        /// <param name="CommonViewConfiguration">Common view configuration for all the available views.</param>
        /// <param name="Name">Name of the requested widget view.</param>
        public WidgetViewInfo(CommonViewConfiguration CommonViewConfiguration = default(CommonViewConfiguration), NameEnum? Name = default(NameEnum?))
        {
            this.CommonViewConfiguration = CommonViewConfiguration;
            this.Name = Name;
        }
        
        /// <summary>
        /// Common view configuration for all the available views
        /// </summary>
        /// <value>Common view configuration for all the available views</value>
        [DataMember(Name="commonViewConfiguration", EmitDefaultValue=false)]
        public CommonViewConfiguration CommonViewConfiguration { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WidgetViewInfo {\n");
            sb.Append("  CommonViewConfiguration: ").Append(CommonViewConfiguration).Append("\n");
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
            return this.Equals(input as WidgetViewInfo);
        }

        /// <summary>
        /// Returns true if WidgetViewInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WidgetViewInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WidgetViewInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommonViewConfiguration == input.CommonViewConfiguration ||
                    (this.CommonViewConfiguration != null &&
                    this.CommonViewConfiguration.Equals(input.CommonViewConfiguration))
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
                if (this.CommonViewConfiguration != null)
                    hashCode = hashCode * 59 + this.CommonViewConfiguration.GetHashCode();
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
