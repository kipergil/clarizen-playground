using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class UserGroup : EntityId
    {
        public string Name { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_PTalentType { get; set; }

        public bool? ResourcingGroup { get; set; }
    }

    public class ResourceManagerLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Member { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Container { get; set; }
    }


    public class UserGroupClarizen : EntityId
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
        /// label : Default Members Availability(%) for New Project
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public Double? Availability { get; set; }

        ///<summary>
        /// label : Alias
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string ObjectAlias { get; set; }

        ///<summary>
        /// label : Direct Manager
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DirectManager { get; set; }

        ///<summary>
        /// label : Custom CSS
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string CustomCss { get; set; }

        ///<summary>
        /// label : Organizational Unit
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public bool? OrganizationUnit { get; set; }

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
        /// label : Language
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Language { get; set; }

        ///<summary>
        /// label : # of Posts
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        public Double? PostsCount { get; set; }

        ///<summary>
        /// label : Notify me
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId EmailNotifications { get; set; }

        ///<summary>
        /// label : Public
        /// calculated : False
        /// system : False
        /// updatable : False 
        /// custom : False
        ///</summary>
        public bool? Public { get; set; }

        ///<summary>
        /// label : Profile
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Profile { get; set; }

        ///<summary>
        /// label : Mobile Profile
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId MobileProfile { get; set; }

        ///<summary>
        /// label : User Sync ID
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string UserSyncId { get; set; }

        ///<summary>
        /// label : User Sync Notes
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public string UserSyncNotes { get; set; }

        ///<summary>
        /// label : User Sync Updated
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public DateTime? UserSyncUpdated { get; set; }

        ///<summary>
        /// label : Staffing Request Required
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public bool? StaffingRequestRequired { get; set; }

        ///<summary>
        /// label : Staffing Request Required Manually Set
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public bool? StaffingRequestRequiredManSet { get; set; }

        ///<summary>
        /// label : Resourcing Group
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : False
        ///</summary>
        public bool? ResourcingGroup { get; set; }

    }
}
