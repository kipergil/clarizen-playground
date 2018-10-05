using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class C_CRSEmail : EntityId
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
        /// label : Email Type
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_EmailType { get; set; }

        ///<summary>
        /// label : Participant
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Participant { get; set; }

        ///<summary>
        /// label : Token
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_Token { get; set; }

        ///<summary>
        /// label : Clicked
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool C_Clicked { get; set; }

        ///<summary>
        /// label : Last Clicked Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_LastClickedDate { get; set; }

        ///<summary>
        /// label : Viewed
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool C_Viewed { get; set; }

        ///<summary>
        /// label : First Viewed Date
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime C_FirstViewedDate { get; set; }

    }
}


