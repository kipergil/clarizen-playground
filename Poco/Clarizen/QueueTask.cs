using Ekin.Clarizen;
using Newtonsoft.Json;
using System;
using EntityIdConverter = BBHPro.Playground.Poco.Clarizen.EntityIdConverter;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace BBHPro.POCO.Clarizen
{
    public class C_QueueTask : EntityId
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
        /// label : OperationType
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_OperationType { get; set; }

        ///<summary>
        /// label : RetryCount
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public Double C_RetryCount { get; set; }

        ///<summary>
        /// label : OperationStatus
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_OperationStatus { get; set; }

        ///<summary>
        /// label : NotificationEmails
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_NotificationEmails { get; set; }

        ///<summary>
        /// label : SendNotification
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public bool C_SendNotification { get; set; }

        ///<summary>
        /// label : LastErrorMessage
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_LastErrorMessage { get; set; }

        ///<summary>
        /// label : FileToProcess
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_FileToProcess { get; set; }

        ///<summary>
        /// label : OperationParameters
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_OperationParameters { get; set; }


        ///<summary>
        /// label : EntityType
        /// calculated : False
        /// system : False
        /// updatable : True 
        /// custom : True
        ///</summary>
        public string C_EntityType { get; set; }

    }
}


