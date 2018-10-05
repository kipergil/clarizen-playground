using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class Request : EntityId
    {

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BBHCustomer { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId AssignedTo { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BusinessOwner { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Discipline { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ProbabilityofConversion { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_TypeofOpportunity { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId State { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ProjectType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_MainProjectType { get; set; }

        public string Title { get; set; }
        public Currency C_EstimatedFee { get; set; }
        public DateTime? C_ProjectConversionDate { get; set; }
        public DateTime? C_ProjectStartDate { get; set; }
        public DateTime? C_ProjectEndDate { get; set; }
        public DateTime? C_ActualStartDate { get; set; }
        public DateTime? C_ActualEndDate { get; set; }
        public string Comment { get; set; }
        public bool? C_IsRetainerDrawdownProject { get; set; }

        public string C_RelatedWorkItemID { get; set; }
        public string C_RelatedWorkItemName { get; set; }

        
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_RevenueCategory { get; set; }

        public Currency C_TotalProjectRevenue { get; set; }

        public Currency C_Pre2017Revenue { get; set; }

        public Currency C_2017Revenue { get; set; }

        public Currency C_2018Revenue { get; set; }

        public Currency C_2019Revenue { get; set; }

        public Currency C_SoldFee2 { get; set; }

        public double? C_ProbabilityofConversionpercent { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId PlannedFor { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CreatedbyRegion { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId CreatedBy { get; set; }
    }
}
