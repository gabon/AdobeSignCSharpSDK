/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 6.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.model.agreements;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AgreementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AgreementsApiTests
    {
        private AgreementsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AgreementsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AgreementsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AgreementsApi
            //Assert.IsInstanceOfType(typeof(AgreementsApi), instance, "instance is a AgreementsApi");
        }

        
        /// <summary>
        /// Test AddTemplateFieldsToAgreement
        /// </summary>
        [Test]
        public void AddTemplateFieldsToAgreementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //FormFieldPostInfo formFieldPostInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.AddTemplateFieldsToAgreement(authorization, ifMatch, agreementId, formFieldPostInfo, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<AgreementFormFields> (response, "response is AgreementFormFields");
        }
        
        /// <summary>
        /// Test CreateAgreement
        /// </summary>
        [Test]
        public void CreateAgreementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //AgreementCreationInfo agreementInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.CreateAgreement(authorization, agreementInfo, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<AgreementCreationResponse> (response, "response is AgreementCreationResponse");
        }
        
        /// <summary>
        /// Test CreateAgreementView
        /// </summary>
        [Test]
        public void CreateAgreementViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //AgreementViewInfo agreementViewInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.CreateAgreementView(authorization, agreementId, agreementViewInfo, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<AgreementViews> (response, "response is AgreementViews");
        }
        
        /// <summary>
        /// Test CreateDelegatedParticipantSets
        /// </summary>
        [Test]
        public void CreateDelegatedParticipantSetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string participantSetId = null;
            //DelegatedParticipantSetInfo delegatedParticipantSetInfo = null;
            //string xApiUser = null;
            //var response = instance.CreateDelegatedParticipantSets(authorization, agreementId, participantSetId, delegatedParticipantSetInfo, xApiUser);
            //Assert.IsInstanceOf<DelegationResponse> (response, "response is DelegationResponse");
        }
        
        /// <summary>
        /// Test CreateReminderOnParticipant
        /// </summary>
        [Test]
        public void CreateReminderOnParticipantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //ReminderInfo reminderInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.CreateReminderOnParticipant(authorization, agreementId, reminderInfo, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<ReminderCreationResult> (response, "response is ReminderCreationResult");
        }
        
        /// <summary>
        /// Test CreateShareOnAgreement
        /// </summary>
        [Test]
        public void CreateShareOnAgreementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //ShareCreationInfoList shareCreationInfoList = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.CreateShareOnAgreement(authorization, agreementId, shareCreationInfoList, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<ShareCreationResponseList> (response, "response is ShareCreationResponseList");
        }
        
        /// <summary>
        /// Test DeleteDocuments
        /// </summary>
        [Test]
        public void DeleteDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.DeleteDocuments(authorization, ifMatch, agreementId, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test GetAgreementInfo
        /// </summary>
        [Test]
        public void GetAgreementInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetAgreementInfo(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<AgreementInfo> (response, "response is AgreementInfo");
        }
        
        /// <summary>
        /// Test GetAgreementNoteForApiUser
        /// </summary>
        [Test]
        public void GetAgreementNoteForApiUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.GetAgreementNoteForApiUser(authorization, agreementId, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<Note> (response, "response is Note");
        }
        
        /// <summary>
        /// Test GetAgreementReminder
        /// </summary>
        [Test]
        public void GetAgreementReminderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string reminderId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.GetAgreementReminder(authorization, agreementId, reminderId, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<ReminderInfo> (response, "response is ReminderInfo");
        }
        
        /// <summary>
        /// Test GetAgreementReminders
        /// </summary>
        [Test]
        public void GetAgreementRemindersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string status = null;
            //var response = instance.GetAgreementReminders(authorization, agreementId, xApiUser, xOnBehalfOfUser, status);
            //Assert.IsInstanceOf<RemindersResponse> (response, "response is RemindersResponse");
        }
        
        /// <summary>
        /// Test GetAgreementSecurityOptionsForParticipation
        /// </summary>
        [Test]
        public void GetAgreementSecurityOptionsForParticipationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string participantSetId = null;
            //string participantId = null;
            //string ifNoneMatch = null;
            //string xApiUser = null;
            //var response = instance.GetAgreementSecurityOptionsForParticipation(authorization, agreementId, participantSetId, participantId, ifNoneMatch, xApiUser);
            //Assert.IsInstanceOf<ParticipantSecurityOption> (response, "response is ParticipantSecurityOption");
        }
        
        /// <summary>
        /// Test GetAgreements
        /// </summary>
        [Test]
        public void GetAgreementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string externalId = null;
            //bool? showHiddenAgreements = null;
            //string cursor = null;
            //int? pageSize = null;
            //var response = instance.GetAgreements(authorization, xApiUser, xOnBehalfOfUser, externalId, showHiddenAgreements, cursor, pageSize);
            //Assert.IsInstanceOf<UserAgreements> (response, "response is UserAgreements");
        }
        
        /// <summary>
        /// Test GetAllDocuments
        /// </summary>
        [Test]
        public void GetAllDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //string versionId = null;
            //string participantId = null;
            //string supportingDocumentContentFormat = null;
            //var response = instance.GetAllDocuments(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch, versionId, participantId, supportingDocumentContentFormat);
            //Assert.IsInstanceOf<AgreementDocuments> (response, "response is AgreementDocuments");
        }
        
        /// <summary>
        /// Test GetAllDocumentsImageUrls
        /// </summary>
        [Test]
        public void GetAllDocumentsImageUrlsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string versionId = null;
            //string participantId = null;
            //string imageSizes = null;
            //bool? includeSupportingDocumentsImageUrls = null;
            //bool? showImageAvailabilityOnly = null;
            //var response = instance.GetAllDocumentsImageUrls(authorization, agreementId, xApiUser, xOnBehalfOfUser, versionId, participantId, imageSizes, includeSupportingDocumentsImageUrls, showImageAvailabilityOnly);
            //Assert.IsInstanceOf<DocumentsImageUrlsInfo> (response, "response is DocumentsImageUrlsInfo");
        }
        
        /// <summary>
        /// Test GetAllMembers
        /// </summary>
        [Test]
        public void GetAllMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //bool? includeNextParticipantSet = null;
            //var response = instance.GetAllMembers(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch, includeNextParticipantSet);
            //Assert.IsInstanceOf<MembersInfo> (response, "response is MembersInfo");
        }
        
        /// <summary>
        /// Test GetAuditTrail
        /// </summary>
        [Test]
        public void GetAuditTrailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetAuditTrail(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetCombinedDocument
        /// </summary>
        [Test]
        public void GetCombinedDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //string versionId = null;
            //string participantId = null;
            //bool? attachSupportingDocuments = null;
            //bool? attachAuditReport = null;
            //var response = instance.GetCombinedDocument(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch, versionId, participantId, attachSupportingDocuments, attachAuditReport);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetCombinedDocumentPagesInfo
        /// </summary>
        [Test]
        public void GetCombinedDocumentPagesInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //bool? includeSupportingDocumentsPagesInfo = null;
            //var response = instance.GetCombinedDocumentPagesInfo(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch, includeSupportingDocumentsPagesInfo);
            //Assert.IsInstanceOf<CombinedDocumentPagesInfo> (response, "response is CombinedDocumentPagesInfo");
        }
        
        /// <summary>
        /// Test GetCombinedDocumentUrl
        /// </summary>
        [Test]
        public void GetCombinedDocumentUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string versionId = null;
            //string participantId = null;
            //bool? attachSupportingDocuments = null;
            //bool? attachAuditReport = null;
            //var response = instance.GetCombinedDocumentUrl(authorization, agreementId, xApiUser, xOnBehalfOfUser, versionId, participantId, attachSupportingDocuments, attachAuditReport);
            //Assert.IsInstanceOf<DocumentUrl> (response, "response is DocumentUrl");
        }
        
        /// <summary>
        /// Test GetDocument
        /// </summary>
        [Test]
        public void GetDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string documentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetDocument(authorization, agreementId, documentId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetDocumentImageUrls
        /// </summary>
        [Test]
        public void GetDocumentImageUrlsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string documentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string imageSizes = null;
            //bool? showImageAvailabilityOnly = null;
            //int? startPage = null;
            //int? endPage = null;
            //var response = instance.GetDocumentImageUrls(authorization, agreementId, documentId, xApiUser, xOnBehalfOfUser, imageSizes, showImageAvailabilityOnly, startPage, endPage);
            //Assert.IsInstanceOf<AgreementDocumentImageUrlsInfo> (response, "response is AgreementDocumentImageUrlsInfo");
        }
        
        /// <summary>
        /// Test GetEvents
        /// </summary>
        [Test]
        public void GetEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetEvents(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<AgreementEventList> (response, "response is AgreementEventList");
        }
        
        /// <summary>
        /// Test GetFormData
        /// </summary>
        [Test]
        public void GetFormDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetFormData(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetFormFields
        /// </summary>
        [Test]
        public void GetFormFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //string participantEmail = null;
            //var response = instance.GetFormFields(authorization, agreementId, xApiUser, xOnBehalfOfUser, ifNoneMatch, participantEmail);
            //Assert.IsInstanceOf<AgreementFormFields> (response, "response is AgreementFormFields");
        }
        
        /// <summary>
        /// Test GetMergeInfo
        /// </summary>
        [Test]
        public void GetMergeInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.GetMergeInfo(authorization, agreementId, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<FormFieldMergeInfo> (response, "response is FormFieldMergeInfo");
        }
        
        /// <summary>
        /// Test GetParticipantSet
        /// </summary>
        [Test]
        public void GetParticipantSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string participantSetId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetParticipantSet(authorization, agreementId, participantSetId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<DetailedParticipantSetInfo> (response, "response is DetailedParticipantSetInfo");
        }
        
        /// <summary>
        /// Test GetSigningUrl
        /// </summary>
        [Test]
        public void GetSigningUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string xApiUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetSigningUrl(authorization, agreementId, xApiUser, ifNoneMatch);
            //Assert.IsInstanceOf<SigningUrlResponse> (response, "response is SigningUrlResponse");
        }
        
        /// <summary>
        /// Test RejectAgreementForParticipation
        /// </summary>
        [Test]
        public void RejectAgreementForParticipationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //string participantSetId = null;
            //string participantId = null;
            //AgreementRejectionInfo agreementRejectionInfo = null;
            //string xApiUser = null;
            //instance.RejectAgreementForParticipation(authorization, ifMatch, agreementId, participantSetId, participantId, agreementRejectionInfo, xApiUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreement
        /// </summary>
        [Test]
        public void UpdateAgreementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //AgreementInfo agreementInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateAgreement(authorization, ifMatch, agreementId, agreementInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreementMergeInfo
        /// </summary>
        [Test]
        public void UpdateAgreementMergeInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //FormFieldMergeInfo formFieldMergeInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateAgreementMergeInfo(authorization, ifMatch, agreementId, formFieldMergeInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreementNoteForApiUser
        /// </summary>
        [Test]
        public void UpdateAgreementNoteForApiUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //Note note = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateAgreementNoteForApiUser(authorization, agreementId, note, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreementReminder
        /// </summary>
        [Test]
        public void UpdateAgreementReminderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //string reminderId = null;
            //ReminderInfo reminderInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateAgreementReminder(authorization, agreementId, reminderId, reminderInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreementSecurityOptionsForParticipation
        /// </summary>
        [Test]
        public void UpdateAgreementSecurityOptionsForParticipationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //string participantSetId = null;
            //string participantId = null;
            //ParticipantSecurityOption participantSecurityOption = null;
            //string xApiUser = null;
            //instance.UpdateAgreementSecurityOptionsForParticipation(authorization, ifMatch, agreementId, participantSetId, participantId, participantSecurityOption, xApiUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreementState
        /// </summary>
        [Test]
        public void UpdateAgreementStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //AgreementStateInfo agreementStateInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateAgreementState(authorization, ifMatch, agreementId, agreementStateInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateAgreementVisibility
        /// </summary>
        [Test]
        public void UpdateAgreementVisibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string agreementId = null;
            //VisibilityInfo visibilityInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateAgreementVisibility(authorization, agreementId, visibilityInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateFormFields
        /// </summary>
        [Test]
        public void UpdateFormFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //FormFieldPutInfo formFieldPutInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.UpdateFormFields(authorization, ifMatch, agreementId, formFieldPutInfo, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<AgreementFormFields> (response, "response is AgreementFormFields");
        }
        
        /// <summary>
        /// Test UpdateParticipantSet
        /// </summary>
        [Test]
        public void UpdateParticipantSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string agreementId = null;
            //string participantSetId = null;
            //DetailedParticipantSetInfo detailedParticipantSetInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateParticipantSet(authorization, ifMatch, agreementId, participantSetId, detailedParticipantSetInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
    }

}