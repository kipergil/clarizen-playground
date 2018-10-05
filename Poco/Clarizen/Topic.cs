using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class Topic : EntityId
    {

        ///<summary>
        /// label : External ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ExternalID { get; set; }

        ///<summary>
        /// label : Name
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// label : Alias
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ObjectAlias { get; set; }

        ///<summary>
        /// label : Rate
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Currency C_Rate { get; set; }

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
        /// label : Topic Type
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_TopicType { get; set; }

        ///<summary>
        /// label : Customer
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Customer { get; set; }

        ///<summary>
        /// label : Import Rate Card
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool C_ImportRateCard { get; set; }

        ///<summary>
        /// label : Effective To
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_EffectiveTo { get; set; }

        ///<summary>
        /// label : Effective From
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public DateTime? C_EffectiveFrom { get; set; }

    }
}


