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

namespace AdobeSign.Rest.Model.LibraryDocuments
{
    /// <summary>
    /// SendViewConfiguration
    /// </summary>
    [DataContract]
    public partial class SendViewConfiguration :  IEquatable<SendViewConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendViewConfiguration" /> class.
        /// </summary>
        /// <param name="AgrName">The agreement name for the library document on the compose page.</param>
        /// <param name="FileUploadOptions">Controls various file upload options available on the compose page.</param>
        /// <param name="IsPreviewSelected">Should the compose page be provided with authoring mode selected?.</param>
        public SendViewConfiguration(string AgrName = default(string), FileUploadOptions FileUploadOptions = default(FileUploadOptions), bool? IsPreviewSelected = default(bool?))
        {
            this.AgrName = AgrName;
            this.FileUploadOptions = FileUploadOptions;
            this.IsPreviewSelected = IsPreviewSelected;
        }
        
        /// <summary>
        /// The agreement name for the library document on the compose page
        /// </summary>
        /// <value>The agreement name for the library document on the compose page</value>
        [DataMember(Name="agrName", EmitDefaultValue=false)]
        public string AgrName { get; set; }

        /// <summary>
        /// Controls various file upload options available on the compose page
        /// </summary>
        /// <value>Controls various file upload options available on the compose page</value>
        [DataMember(Name="fileUploadOptions", EmitDefaultValue=false)]
        public FileUploadOptions FileUploadOptions { get; set; }

        /// <summary>
        /// Should the compose page be provided with authoring mode selected?
        /// </summary>
        /// <value>Should the compose page be provided with authoring mode selected?</value>
        [DataMember(Name="isPreviewSelected", EmitDefaultValue=false)]
        public bool? IsPreviewSelected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendViewConfiguration {\n");
            sb.Append("  AgrName: ").Append(AgrName).Append("\n");
            sb.Append("  FileUploadOptions: ").Append(FileUploadOptions).Append("\n");
            sb.Append("  IsPreviewSelected: ").Append(IsPreviewSelected).Append("\n");
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
            return this.Equals(input as SendViewConfiguration);
        }

        /// <summary>
        /// Returns true if SendViewConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SendViewConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendViewConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgrName == input.AgrName ||
                    (this.AgrName != null &&
                    this.AgrName.Equals(input.AgrName))
                ) && 
                (
                    this.FileUploadOptions == input.FileUploadOptions ||
                    (this.FileUploadOptions != null &&
                    this.FileUploadOptions.Equals(input.FileUploadOptions))
                ) && 
                (
                    this.IsPreviewSelected == input.IsPreviewSelected ||
                    (this.IsPreviewSelected != null &&
                    this.IsPreviewSelected.Equals(input.IsPreviewSelected))
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
                if (this.AgrName != null)
                    hashCode = hashCode * 59 + this.AgrName.GetHashCode();
                if (this.FileUploadOptions != null)
                    hashCode = hashCode * 59 + this.FileUploadOptions.GetHashCode();
                if (this.IsPreviewSelected != null)
                    hashCode = hashCode * 59 + this.IsPreviewSelected.GetHashCode();
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
