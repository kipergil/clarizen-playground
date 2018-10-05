using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class C_CRSParticipant : EntityId
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
        /// label : 10. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer10_Rating { get; set; }

        ///<summary>
        /// label : 1. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer01_Rating { get; set; }

        ///<summary>
        /// label : 6. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer06_Rating { get; set; }

        ///<summary>
        /// label : Last Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_LastName { get; set; }

        ///<summary>
        /// label : First Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_FirstName { get; set; }

        ///<summary>
        /// label : Response Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_ResponseDate { get; set; }

        ///<summary>
        /// label : Email
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Email { get; set; }

        ///<summary>
        /// label : 1. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer01_Text { get; set; }

        ///<summary>
        /// label : 13. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer13_Rating { get; set; }

        ///<summary>
        /// label : 3. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer03_Text { get; set; }

        ///<summary>
        /// label : 9. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer09_Rating { get; set; }

        ///<summary>
        /// label : Survey
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Survey { get; set; }

        ///<summary>
        /// label : 7. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer07_Text { get; set; }

        ///<summary>
        /// label : 12. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer12_Text { get; set; }

        ///<summary>
        /// label : 11. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer11_Text { get; set; }

        ///<summary>
        /// label : 2. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer02_Text { get; set; }

        ///<summary>
        /// label : 5. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer05_Rating { get; set; }

        ///<summary>
        /// label : 2. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer02_Rating { get; set; }

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
        /// label : 5. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer05_Text { get; set; }

        ///<summary>
        /// label : 4. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer04_Text { get; set; }

        ///<summary>
        /// label : 15. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer15_Rating { get; set; }

        ///<summary>
        /// label : 8. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer08_Rating { get; set; }

        ///<summary>
        /// label : 7. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer07_Rating { get; set; }

        ///<summary>
        /// label : 10. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer10_Text { get; set; }

        ///<summary>
        /// label : Interview
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool? C_Interview { get; set; }

        ///<summary>
        /// label : 4. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer04_Rating { get; set; }

        ///<summary>
        /// label : Related Entity Id
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_RelatedEntityId { get; set; }

        ///<summary>
        /// label : 6. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer06_Text { get; set; }

        ///<summary>
        /// label : 15. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer15_Text { get; set; }

        ///<summary>
        /// label : 14. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer14_Text { get; set; }

        ///<summary>
        /// label : Interview Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_InterviewDate { get; set; }

        ///<summary>
        /// label : 13. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer13_Text { get; set; }

        ///<summary>
        /// label : 9. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer09_Text { get; set; }

        ///<summary>
        /// label : 8. Comment
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Answer08_Text { get; set; }

        ///<summary>
        /// label : Participant Type
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ParticipantType { get; set; }

        ///<summary>
        /// label : 14. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer14_Rating { get; set; }

        ///<summary>
        /// label : 11. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer11_Rating { get; set; }

        ///<summary>
        /// label : 3. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer03_Rating { get; set; }

        ///<summary>
        /// label : 12. Rating
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double? C_Answer12_Rating { get; set; }

        ///<summary>
        /// label : Contact Person Relationship
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ContactPersonRelationship { get; set; }

        ///<summary>
        /// label : Contact Person Relationship
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_UserRelationship { get; set; }
    }
}


