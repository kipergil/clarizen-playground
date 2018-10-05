using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class C_CRS : EntityId
    {
        ///<summary>
        /// label : Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// label : Description
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// label : External ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ExternalID { get; set; }

        ///<summary>
        /// label : Owner
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId EntityOwner { get; set; }

        ///<summary>
        /// label : Question 3
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question3 { get; set; }

        ///<summary>
        /// label : Question Category 1
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory1 { get; set; }

        ///<summary>
        /// label : Reminder Email
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_ReminderEmail { get; set; }

        ///<summary>
        /// label : Invitation Email External New & Interviewed
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_InvitationEmailExternalNewInterview { get; set; }

        ///<summary>
        /// label : Start Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_StartDate { get; set; }

        ///<summary>
        /// label : Question 2
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question2 { get; set; }

        ///<summary>
        /// label : Question 8 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question8Subtitle { get; set; }

        ///<summary>
        /// label : Question 3 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question3Subtitle { get; set; }

        ///<summary>
        /// label : SurveyActions
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_SurveyActions { get; set; }

        ///<summary>
        /// label : Question Category 2
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory2 { get; set; }

        ///<summary>
        /// label : Question Category 8
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory8 { get; set; }

        ///<summary>
        /// label : Question Category 5
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory5 { get; set; }

        ///<summary>
        /// label : Question Category 14
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory14 { get; set; }

        ///<summary>
        /// label : Question Category 12
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory12 { get; set; }

        ///<summary>
        /// label : Question Category 9
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory9 { get; set; }

        ///<summary>
        /// label : Question 1 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question1Subtitle { get; set; }

        ///<summary>
        /// label : Question Category 7
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory7 { get; set; }

        ///<summary>
        /// label : Question 14 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question14Subtitle { get; set; }

        ///<summary>
        /// label : Question 4 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question4Subtitle { get; set; }

        ///<summary>
        /// label : 2nd Reminder Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_2ndReminderDate { get; set; }

        ///<summary>
        /// label : State
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_State { get; set; }

        ///<summary>
        /// label : Question 6 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question6Subtitle { get; set; }

        ///<summary>
        /// label : Question 15 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question15Subtitle { get; set; }

        ///<summary>
        /// label : Question 13 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question13Subtitle { get; set; }

        ///<summary>
        /// label : Question 9 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question9Subtitle { get; set; }

        ///<summary>
        /// label : Question 5 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question5Subtitle { get; set; }

        ///<summary>
        /// label : Invitation Email External New & Not Interviewed
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_InvitationEmailExternalNewNotInterviewed { get; set; }

        ///<summary>
        /// label : Invitation Email External Not New & Interviewed
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_InvitationEmailExternalNotNewInterviewed { get; set; }

        ///<summary>
        /// label : Question 6
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question6 { get; set; }

        ///<summary>
        /// label : Question 15
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question15 { get; set; }

        ///<summary>
        /// label : Question 14
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question14 { get; set; }

        ///<summary>
        /// label : Question 13
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question13 { get; set; }

        ///<summary>
        /// label : Question 12
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question12 { get; set; }

        ///<summary>
        /// label : Question 7
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question7 { get; set; }

        ///<summary>
        /// label : Question 5
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question5 { get; set; }

        ///<summary>
        /// label : Question Category 3
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory3 { get; set; }

        ///<summary>
        /// label : Question Category 4
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory4 { get; set; }

        ///<summary>
        /// label : Question Category 15
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory15 { get; set; }

        ///<summary>
        /// label : Invitation Email Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_InvitationEmailInternal { get; set; }

        ///<summary>
        /// label : Question 11 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question11Subtitle { get; set; }

        ///<summary>
        /// label : Question 10 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question10Subtitle { get; set; }

        ///<summary>
        /// label : Question 7 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question7Subtitle { get; set; }

        ///<summary>
        /// label : Due Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_DueDate { get; set; }

        ///<summary>
        /// label : 3rd Reminder Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_3rdReminderDate { get; set; }

        ///<summary>
        /// label : Question Category 13
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory13 { get; set; }

        ///<summary>
        /// label : Question Category 6
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory6 { get; set; }

        ///<summary>
        /// label : 1st Reminder Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_1stReminderDate { get; set; }

        ///<summary>
        /// label : Question Category 11
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory11 { get; set; }

        ///<summary>
        /// label : Question Category 10
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_QuestionCategory10 { get; set; }

        ///<summary>
        /// label : Question 12 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question12Subtitle { get; set; }

        ///<summary>
        /// label : Question 2 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question2Subtitle { get; set; }

        ///<summary>
        /// label : Question 4
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question4 { get; set; }

        ///<summary>
        /// label : Question 1
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question1 { get; set; }

        ///<summary>
        /// label : Question 11
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question11 { get; set; }

        ///<summary>
        /// label : Question 8
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question8 { get; set; }

        ///<summary>
        /// label : Question 10
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question10 { get; set; }

        ///<summary>
        /// label : Question 9
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question9 { get; set; }

        ///<summary>
        /// label : Invitation Email External Not New & Not Interviewed
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_InvitationEmailExternalNotNewNotInterviewed { get; set; }

        ///<summary>
        /// label : Survey Customer
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_SurveyCustomer { get; set; }

        ///<summary>
        /// label : CRS Business Lead
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CRSBusinessLead { get; set; }

        ///<summary>
        /// label : Email CC User	
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_EmailCCUser { get; set; }

        ///<summary>
        /// label : Email Reply To User	
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_EmailReplyToUser { get; set; }

        ///<summary>
        /// label : Email Submit User
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_EmailSubmitUser { get; set; }

        ///<summary>
        /// label : Email Template For Survey Completion
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_EmailTemplateForSurveyCompletion { get; set; }

        ///<summary>
        /// label : Survey Customer Name
        /// calculated : False
        /// system : False
        /// updatable : false 
        /// custom : True
        ///</summary>
        public string C_SurveyCustomerName { get; set; }

        ///<summary>
        /// label : Email Subject
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_EmailSubject { get; set; }
    }


    public class C_CRSInternal : EntityId {

        ///<summary>
        /// label : Question 1 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question1Internal { get; set; }

        ///<summary>
        /// label : Question 2 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question2Internal { get; set; }

        ///<summary>
        /// label : Question 3 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question3Internal { get; set; }

        ///<summary>
        /// label : Question 4 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question4Internal { get; set; }

        ///<summary>
        /// label : Question 5 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question5Internal { get; set; }

        ///<summary>
        /// label : Question 6 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question6Internal { get; set; }

        ///<summary>
        /// label : Question 7 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question7Internal { get; set; }

        ///<summary>
        /// label : Question 8 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question8Internal { get; set; }

        ///<summary>
        /// label : Question 9 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question9Internal { get; set; }

        ///<summary>
        /// label : Question 10 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question10Internal { get; set; }

        ///<summary>
        /// label : Question 11 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question11Internal { get; set; }

        ///<summary>
        /// label : Question 12 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question12Internal { get; set; }

        ///<summary>
        /// label : Question 13 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question13Internal { get; set; }

        ///<summary>
        /// label : Question 14 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question14Internal { get; set; }

        ///<summary>
        /// label : Question 15 Internal
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question15Internal { get; set; }


        ///<summary>
        /// label : Question 1 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question1SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 2 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question2SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 3 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question3SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 4 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question4SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 5 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question5SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 6 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question6SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 7 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question7SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 8 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question8SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 9 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question9SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 10 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question10SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 11 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question11SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 12 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question12SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 13 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question13SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 14 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question14SubtitleInternal { get; set; }


        ///<summary>
        /// label : Question 15 Subtitle
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Question15SubtitleInternal { get; set; }
    }
}


