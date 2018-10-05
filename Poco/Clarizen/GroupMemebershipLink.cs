using Ekin.Clarizen;
using Newtonsoft.Json;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class GroupMembershipLink : EntityId
    {

        ///<summary>
        /// label : Container
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Container { get; set; }

        ///<summary>
        /// label : Member
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Member { get; set; }

        ///<summary>
        /// label : External ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ExternalID { get; set; }

        ///<summary>
        /// label : Primary
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public bool? Primary { get; set; }

        ///<summary>
        /// label : Notify
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Notify { get; set; }

    }
}


