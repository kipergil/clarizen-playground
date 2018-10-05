using Ekin.Clarizen;
using Newtonsoft.Json;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class C_CRSCustomerLink : EntityId
    {

        ///<summary>
        /// label : Related Entity 1
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CRS { get; set; }

        ///<summary>
        /// label : Related Entity 2
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Customer { get; set; }

        ///<summary>
        /// label : External ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ExternalID { get; set; }

    }
}


