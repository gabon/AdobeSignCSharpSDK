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

namespace AdobeSign.Rest.Model.Widgets
{
    /// <summary>
    /// WidgetCreationInfoV6
    /// </summary>
    [DataContract]
    public partial class WidgetCreationInfoV6 :  IEquatable<WidgetCreationInfoV6>, IValidatableObject
    {
        /// <summary>
        /// The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID
        /// </summary>
        /// <value>The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 2,
            
            /// <summary>
            /// Enum AUTHORING for value: AUTHORING
            /// </summary>
            [EnumMember(Value = "AUTHORING")]
            AUTHORING = 3
        }

        /// <summary>
        /// The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID
        /// </summary>
        /// <value>The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Status of the Widget. If provided in POST, it will simply be ignored
        /// </summary>
        /// <value>Status of the Widget. If provided in POST, it will simply be ignored</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,
            
            /// <summary>
            /// Enum AUTHORING for value: AUTHORING
            /// </summary>
            [EnumMember(Value = "AUTHORING")]
            AUTHORING = 2,
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 3,
            
            /// <summary>
            /// Enum DOCUMENTSNOTYETPROCESSED for value: DOCUMENTS_NOT_YET_PROCESSED
            /// </summary>
            [EnumMember(Value = "DOCUMENTS_NOT_YET_PROCESSED")]
            DOCUMENTSNOTYETPROCESSED = 4,
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 5,
            
            /// <summary>
            /// Enum DISCARDED for value: DISCARDED
            /// </summary>
            [EnumMember(Value = "DISCARDED")]
            DISCARDED = 6
        }

        /// <summary>
        /// Status of the Widget. If provided in POST, it will simply be ignored
        /// </summary>
        /// <value>Status of the Widget. If provided in POST, it will simply be ignored</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetCreationInfoV6" /> class.
        /// </summary>
        /// <param name="AdditionalParticipantSetsInfo">List of all the participants in the widget except widget signer.</param>
        /// <param name="AuthFailureInfo">URL and associated properties for the error page the widget signer will be taken after failing to authenticate.</param>
        /// <param name="Ccs">A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file.</param>
        /// <param name="CompletionInfo">URL and associated properties for the success page the widget signer will be taken to after performing desired action on the widget.</param>
        /// <param name="CreatedDate">Date when widget was created. If provided in POST, it will simply be ignored. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="CreatorEmail">Email of widget creator. Only returned in GET response. Cannot be provided in POST/PUT request. If provided in POST, it will simply be ignored.</param>
        /// <param name="FileInfos">A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified.</param>
        /// <param name="Id">A resource identifier that can be used to uniquely identify the widget in other apis. If provided in POST, it will simply be ignored.</param>
        /// <param name="Locale">The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the widget creator.</param>
        /// <param name="Name">The name of the widget that will be used to identify it, in emails, website and other places.</param>
        /// <param name="SecurityOption">Secondary security parameters for the widget.</param>
        /// <param name="State">The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID.</param>
        /// <param name="Status">Status of the Widget. If provided in POST, it will simply be ignored.</param>
        /// <param name="VaultingInfo">Vaulting properties that allows Adobe Sign to securely store documents with a vault provider.</param>
        /// <param name="WidgetInActiveInfo">The custom message which will be displayed to the user or the URL to which user will be redirected when the widget is accessed in a disabled state. This can only be specified in PUT request.</param>
        /// <param name="WidgetParticipantSetInfo">Represents widget participant for whom email should not be provided.</param>
        public WidgetCreationInfoV6(List<WidgetAdditionalParticipationSetInfo> AdditionalParticipantSetsInfo = default(List<WidgetAdditionalParticipationSetInfo>), WidgetRedirectionInfo AuthFailureInfo = default(WidgetRedirectionInfo), List<WidgetCcInfo> Ccs = default(List<WidgetCcInfo>), WidgetRedirectionInfo CompletionInfo = default(WidgetRedirectionInfo), DateTime? CreatedDate = default(DateTime?), string CreatorEmail = default(string), List<FileInfo> FileInfos = default(List<FileInfo>), string Id = default(string), string Locale = default(string), string Name = default(string), SecurityOption SecurityOption = default(SecurityOption), StateEnum? State = default(StateEnum?), StatusEnum? Status = default(StatusEnum?), VaultingInfo VaultingInfo = default(VaultingInfo), WidgetInActiveInfo WidgetInActiveInfo = default(WidgetInActiveInfo), WidgetParticipantSetInfo WidgetParticipantSetInfo = default(WidgetParticipantSetInfo))
        {
            this.AdditionalParticipantSetsInfo = AdditionalParticipantSetsInfo;
            this.AuthFailureInfo = AuthFailureInfo;
            this.Ccs = Ccs;
            this.CompletionInfo = CompletionInfo;
            this.CreatedDate = CreatedDate;
            this.CreatorEmail = CreatorEmail;
            this.FileInfos = FileInfos;
            this.Id = Id;
            this.Locale = Locale;
            this.Name = Name;
            this.SecurityOption = SecurityOption;
            this.State = State;
            this.Status = Status;
            this.VaultingInfo = VaultingInfo;
            this.WidgetInActiveInfo = WidgetInActiveInfo;
            this.WidgetParticipantSetInfo = WidgetParticipantSetInfo;
        }
        
        /// <summary>
        /// List of all the participants in the widget except widget signer
        /// </summary>
        /// <value>List of all the participants in the widget except widget signer</value>
        [DataMember(Name="additionalParticipantSetsInfo", EmitDefaultValue=false)]
        public List<WidgetAdditionalParticipationSetInfo> AdditionalParticipantSetsInfo { get; set; }

        /// <summary>
        /// URL and associated properties for the error page the widget signer will be taken after failing to authenticate
        /// </summary>
        /// <value>URL and associated properties for the error page the widget signer will be taken after failing to authenticate</value>
        [DataMember(Name="authFailureInfo", EmitDefaultValue=false)]
        public WidgetRedirectionInfo AuthFailureInfo { get; set; }

        /// <summary>
        /// A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file
        /// </summary>
        /// <value>A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file</value>
        [DataMember(Name="ccs", EmitDefaultValue=false)]
        public List<WidgetCcInfo> Ccs { get; set; }

        /// <summary>
        /// URL and associated properties for the success page the widget signer will be taken to after performing desired action on the widget
        /// </summary>
        /// <value>URL and associated properties for the success page the widget signer will be taken to after performing desired action on the widget</value>
        [DataMember(Name="completionInfo", EmitDefaultValue=false)]
        public WidgetRedirectionInfo CompletionInfo { get; set; }

        /// <summary>
        /// Date when widget was created. If provided in POST, it will simply be ignored. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>Date when widget was created. If provided in POST, it will simply be ignored. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Email of widget creator. Only returned in GET response. Cannot be provided in POST/PUT request. If provided in POST, it will simply be ignored
        /// </summary>
        /// <value>Email of widget creator. Only returned in GET response. Cannot be provided in POST/PUT request. If provided in POST, it will simply be ignored</value>
        [DataMember(Name="creatorEmail", EmitDefaultValue=false)]
        public string CreatorEmail { get; set; }

        /// <summary>
        /// A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified
        /// </summary>
        /// <value>A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified</value>
        [DataMember(Name="fileInfos", EmitDefaultValue=false)]
        public List<FileInfo> FileInfos { get; set; }

        /// <summary>
        /// A resource identifier that can be used to uniquely identify the widget in other apis. If provided in POST, it will simply be ignored
        /// </summary>
        /// <value>A resource identifier that can be used to uniquely identify the widget in other apis. If provided in POST, it will simply be ignored</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the widget creator
        /// </summary>
        /// <value>The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the widget creator</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// The name of the widget that will be used to identify it, in emails, website and other places
        /// </summary>
        /// <value>The name of the widget that will be used to identify it, in emails, website and other places</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Secondary security parameters for the widget
        /// </summary>
        /// <value>Secondary security parameters for the widget</value>
        [DataMember(Name="securityOption", EmitDefaultValue=false)]
        public SecurityOption SecurityOption { get; set; }



        /// <summary>
        /// Vaulting properties that allows Adobe Sign to securely store documents with a vault provider
        /// </summary>
        /// <value>Vaulting properties that allows Adobe Sign to securely store documents with a vault provider</value>
        [DataMember(Name="vaultingInfo", EmitDefaultValue=false)]
        public VaultingInfo VaultingInfo { get; set; }

        /// <summary>
        /// The custom message which will be displayed to the user or the URL to which user will be redirected when the widget is accessed in a disabled state. This can only be specified in PUT request
        /// </summary>
        /// <value>The custom message which will be displayed to the user or the URL to which user will be redirected when the widget is accessed in a disabled state. This can only be specified in PUT request</value>
        [DataMember(Name="widgetInActiveInfo", EmitDefaultValue=false)]
        public WidgetInActiveInfo WidgetInActiveInfo { get; set; }

        /// <summary>
        /// Represents widget participant for whom email should not be provided
        /// </summary>
        /// <value>Represents widget participant for whom email should not be provided</value>
        [DataMember(Name="widgetParticipantSetInfo", EmitDefaultValue=false)]
        public WidgetParticipantSetInfo WidgetParticipantSetInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WidgetCreationInfoV6 {\n");
            sb.Append("  AdditionalParticipantSetsInfo: ").Append(AdditionalParticipantSetsInfo).Append("\n");
            sb.Append("  AuthFailureInfo: ").Append(AuthFailureInfo).Append("\n");
            sb.Append("  Ccs: ").Append(Ccs).Append("\n");
            sb.Append("  CompletionInfo: ").Append(CompletionInfo).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatorEmail: ").Append(CreatorEmail).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
            sb.Append("  WidgetInActiveInfo: ").Append(WidgetInActiveInfo).Append("\n");
            sb.Append("  WidgetParticipantSetInfo: ").Append(WidgetParticipantSetInfo).Append("\n");
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
            return this.Equals(input as WidgetCreationInfoV6);
        }

        /// <summary>
        /// Returns true if WidgetCreationInfoV6 instances are equal
        /// </summary>
        /// <param name="input">Instance of WidgetCreationInfoV6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WidgetCreationInfoV6 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalParticipantSetsInfo == input.AdditionalParticipantSetsInfo ||
                    this.AdditionalParticipantSetsInfo != null &&
                    this.AdditionalParticipantSetsInfo.SequenceEqual(input.AdditionalParticipantSetsInfo)
                ) && 
                (
                    this.AuthFailureInfo == input.AuthFailureInfo ||
                    (this.AuthFailureInfo != null &&
                    this.AuthFailureInfo.Equals(input.AuthFailureInfo))
                ) && 
                (
                    this.Ccs == input.Ccs ||
                    this.Ccs != null &&
                    this.Ccs.SequenceEqual(input.Ccs)
                ) && 
                (
                    this.CompletionInfo == input.CompletionInfo ||
                    (this.CompletionInfo != null &&
                    this.CompletionInfo.Equals(input.CompletionInfo))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CreatorEmail == input.CreatorEmail ||
                    (this.CreatorEmail != null &&
                    this.CreatorEmail.Equals(input.CreatorEmail))
                ) && 
                (
                    this.FileInfos == input.FileInfos ||
                    this.FileInfos != null &&
                    this.FileInfos.SequenceEqual(input.FileInfos)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SecurityOption == input.SecurityOption ||
                    (this.SecurityOption != null &&
                    this.SecurityOption.Equals(input.SecurityOption))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VaultingInfo == input.VaultingInfo ||
                    (this.VaultingInfo != null &&
                    this.VaultingInfo.Equals(input.VaultingInfo))
                ) && 
                (
                    this.WidgetInActiveInfo == input.WidgetInActiveInfo ||
                    (this.WidgetInActiveInfo != null &&
                    this.WidgetInActiveInfo.Equals(input.WidgetInActiveInfo))
                ) && 
                (
                    this.WidgetParticipantSetInfo == input.WidgetParticipantSetInfo ||
                    (this.WidgetParticipantSetInfo != null &&
                    this.WidgetParticipantSetInfo.Equals(input.WidgetParticipantSetInfo))
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
                if (this.AdditionalParticipantSetsInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalParticipantSetsInfo.GetHashCode();
                if (this.AuthFailureInfo != null)
                    hashCode = hashCode * 59 + this.AuthFailureInfo.GetHashCode();
                if (this.Ccs != null)
                    hashCode = hashCode * 59 + this.Ccs.GetHashCode();
                if (this.CompletionInfo != null)
                    hashCode = hashCode * 59 + this.CompletionInfo.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatorEmail != null)
                    hashCode = hashCode * 59 + this.CreatorEmail.GetHashCode();
                if (this.FileInfos != null)
                    hashCode = hashCode * 59 + this.FileInfos.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SecurityOption != null)
                    hashCode = hashCode * 59 + this.SecurityOption.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultingInfo != null)
                    hashCode = hashCode * 59 + this.VaultingInfo.GetHashCode();
                if (this.WidgetInActiveInfo != null)
                    hashCode = hashCode * 59 + this.WidgetInActiveInfo.GetHashCode();
                if (this.WidgetParticipantSetInfo != null)
                    hashCode = hashCode * 59 + this.WidgetParticipantSetInfo.GetHashCode();
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
