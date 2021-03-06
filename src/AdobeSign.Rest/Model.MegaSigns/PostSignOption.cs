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

namespace AdobeSign.Rest.Model.MegaSigns
{
    /// <summary>
    /// PostSignOption
    /// </summary>
    [DataContract]
    public partial class PostSignOption :  IEquatable<PostSignOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSignOption" /> class.
        /// </summary>
        /// <param name="RedirectDelay">The delay (in seconds) before the user is taken to the success page. If this value is greater than 0, the user will first see the standard Adobe Sign success message, and then after a delay will be redirected to your success page.</param>
        /// <param name="RedirectUrl">A publicly accessible url to which the user will be sent after successfully completing the signing process.</param>
        public PostSignOption(int? RedirectDelay = default(int?), string RedirectUrl = default(string))
        {
            this.RedirectDelay = RedirectDelay;
            this.RedirectUrl = RedirectUrl;
        }
        
        /// <summary>
        /// The delay (in seconds) before the user is taken to the success page. If this value is greater than 0, the user will first see the standard Adobe Sign success message, and then after a delay will be redirected to your success page
        /// </summary>
        /// <value>The delay (in seconds) before the user is taken to the success page. If this value is greater than 0, the user will first see the standard Adobe Sign success message, and then after a delay will be redirected to your success page</value>
        [DataMember(Name="redirectDelay", EmitDefaultValue=false)]
        public int? RedirectDelay { get; set; }

        /// <summary>
        /// A publicly accessible url to which the user will be sent after successfully completing the signing process
        /// </summary>
        /// <value>A publicly accessible url to which the user will be sent after successfully completing the signing process</value>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostSignOption {\n");
            sb.Append("  RedirectDelay: ").Append(RedirectDelay).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(input as PostSignOption);
        }

        /// <summary>
        /// Returns true if PostSignOption instances are equal
        /// </summary>
        /// <param name="input">Instance of PostSignOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSignOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RedirectDelay == input.RedirectDelay ||
                    (this.RedirectDelay != null &&
                    this.RedirectDelay.Equals(input.RedirectDelay))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
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
                if (this.RedirectDelay != null)
                    hashCode = hashCode * 59 + this.RedirectDelay.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
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
