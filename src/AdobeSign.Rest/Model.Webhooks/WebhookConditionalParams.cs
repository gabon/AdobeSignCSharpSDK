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

namespace AdobeSign.Rest.Model.Webhooks
{
    /// <summary>
    /// WebhookConditionalParams
    /// </summary>
    [DataContract]
    public partial class WebhookConditionalParams :  IEquatable<WebhookConditionalParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConditionalParams" /> class.
        /// </summary>
        /// <param name="WebhookAgreementEvents">Conditional parameters for webhook agreement events.</param>
        /// <param name="WebhookLibraryDocumentEvents">Conditional parameters for webhook library document events.</param>
        /// <param name="WebhookMegaSignEvents">Conditional parameters for webhook megasign events.</param>
        /// <param name="WebhookWidgetEvents">Conditional parameters for webhook widget events.</param>
        public WebhookConditionalParams(WebhookAgreementEvents WebhookAgreementEvents = default(WebhookAgreementEvents), WebhookLibraryDocumentEvents WebhookLibraryDocumentEvents = default(WebhookLibraryDocumentEvents), WebhookMegaSignEvents WebhookMegaSignEvents = default(WebhookMegaSignEvents), WebhookWidgetEvents WebhookWidgetEvents = default(WebhookWidgetEvents))
        {
            this.WebhookAgreementEvents = WebhookAgreementEvents;
            this.WebhookLibraryDocumentEvents = WebhookLibraryDocumentEvents;
            this.WebhookMegaSignEvents = WebhookMegaSignEvents;
            this.WebhookWidgetEvents = WebhookWidgetEvents;
        }
        
        /// <summary>
        /// Conditional parameters for webhook agreement events
        /// </summary>
        /// <value>Conditional parameters for webhook agreement events</value>
        [DataMember(Name="webhookAgreementEvents", EmitDefaultValue=false)]
        public WebhookAgreementEvents WebhookAgreementEvents { get; set; }

        /// <summary>
        /// Conditional parameters for webhook library document events
        /// </summary>
        /// <value>Conditional parameters for webhook library document events</value>
        [DataMember(Name="webhookLibraryDocumentEvents", EmitDefaultValue=false)]
        public WebhookLibraryDocumentEvents WebhookLibraryDocumentEvents { get; set; }

        /// <summary>
        /// Conditional parameters for webhook megasign events
        /// </summary>
        /// <value>Conditional parameters for webhook megasign events</value>
        [DataMember(Name="webhookMegaSignEvents", EmitDefaultValue=false)]
        public WebhookMegaSignEvents WebhookMegaSignEvents { get; set; }

        /// <summary>
        /// Conditional parameters for webhook widget events
        /// </summary>
        /// <value>Conditional parameters for webhook widget events</value>
        [DataMember(Name="webhookWidgetEvents", EmitDefaultValue=false)]
        public WebhookWidgetEvents WebhookWidgetEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookConditionalParams {\n");
            sb.Append("  WebhookAgreementEvents: ").Append(WebhookAgreementEvents).Append("\n");
            sb.Append("  WebhookLibraryDocumentEvents: ").Append(WebhookLibraryDocumentEvents).Append("\n");
            sb.Append("  WebhookMegaSignEvents: ").Append(WebhookMegaSignEvents).Append("\n");
            sb.Append("  WebhookWidgetEvents: ").Append(WebhookWidgetEvents).Append("\n");
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
            return this.Equals(input as WebhookConditionalParams);
        }

        /// <summary>
        /// Returns true if WebhookConditionalParams instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookConditionalParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookConditionalParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebhookAgreementEvents == input.WebhookAgreementEvents ||
                    (this.WebhookAgreementEvents != null &&
                    this.WebhookAgreementEvents.Equals(input.WebhookAgreementEvents))
                ) && 
                (
                    this.WebhookLibraryDocumentEvents == input.WebhookLibraryDocumentEvents ||
                    (this.WebhookLibraryDocumentEvents != null &&
                    this.WebhookLibraryDocumentEvents.Equals(input.WebhookLibraryDocumentEvents))
                ) && 
                (
                    this.WebhookMegaSignEvents == input.WebhookMegaSignEvents ||
                    (this.WebhookMegaSignEvents != null &&
                    this.WebhookMegaSignEvents.Equals(input.WebhookMegaSignEvents))
                ) && 
                (
                    this.WebhookWidgetEvents == input.WebhookWidgetEvents ||
                    (this.WebhookWidgetEvents != null &&
                    this.WebhookWidgetEvents.Equals(input.WebhookWidgetEvents))
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
                if (this.WebhookAgreementEvents != null)
                    hashCode = hashCode * 59 + this.WebhookAgreementEvents.GetHashCode();
                if (this.WebhookLibraryDocumentEvents != null)
                    hashCode = hashCode * 59 + this.WebhookLibraryDocumentEvents.GetHashCode();
                if (this.WebhookMegaSignEvents != null)
                    hashCode = hashCode * 59 + this.WebhookMegaSignEvents.GetHashCode();
                if (this.WebhookWidgetEvents != null)
                    hashCode = hashCode * 59 + this.WebhookWidgetEvents.GetHashCode();
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
