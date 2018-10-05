using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class TopicLink : EntityId
    {

        ///<summary>
        /// label : Topic
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Topic { get; set; }

        ///<summary>
        /// label : Entity
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Entity { get; set; }

        ///<summary>
        /// label : External ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ExternalID { get; set; }

        ///<summary>
        /// label : Effective From
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_EffectiveFrom { get; set; }

        ///<summary>
        /// label : Customer Rate Card
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CustomerRateCard { get; set; }

        ///<summary>
        /// label : Role
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Role { get; set; }

        ///<summary>
        /// label : Effective To
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_EffectiveTo { get; set; }

        ///<summary>
        /// label : Role Rate
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Currency C_RoleRate { get; set; }

    }
}


