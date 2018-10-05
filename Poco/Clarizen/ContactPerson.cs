using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class ContactPerson : EntityId
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
        /// label : Customer
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Customer { get; set; }

        ///<summary>
        /// label : Fax Number
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string FaxNumber { get; set; }

        ///<summary>
        /// label : Main contact
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public bool MainContact { get; set; }

        ///<summary>
        /// label : First Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string FirstName { get; set; }

        ///<summary>
        /// label : SalesForce ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string SfExternalId { get; set; }

        ///<summary>
        /// label : Last Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string LastName { get; set; }

        ///<summary>
        /// label : SalesForce Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string SfExternalName { get; set; }

        ///<summary>
        /// label : Email
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        /// label : Office Phone
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string OfficePhone { get; set; }

        ///<summary>
        /// label : Mobile Phone
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string MobilePhone { get; set; }

        ///<summary>
        /// label : Title
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        /// label : Department
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string Department { get; set; }

        ///<summary>
        /// label : Time Zone
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId TimeZone { get; set; }

        ///<summary>
        /// label : Last date contacted
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        //public Date LastDateContacted { get; set; }

        ///<summary>
        /// label : External profile URL
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string URL { get; set; }

        ///<summary>
        /// label : Level
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Level { get; set; }

        ///<summary>
        /// label : No of Surveys
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_NoofSurveys { get; set; }

        ///<summary>
        /// label : Job Title
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_JobTitle { get; set; }

        ///<summary>
        /// label : Date Last Completed
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_DateLastCompleted { get; set; }

        ///<summary>
        /// label : Is New
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool? C_IsNew { get; set; }

        ///<summary>
        /// label : Is Active
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool? C_IsActive { get; set; }

    }
}


