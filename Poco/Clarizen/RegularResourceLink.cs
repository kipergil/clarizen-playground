using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class RegularResourceLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId WorkItem { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Resource { get; set; }

        public Duration C_SoldHours { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId ResourceRole { get; set; }

        public Duration C_TotalSoldHours { get; set; }

        public string EntityType { get; set; }

        public Duration C_ActualHours { get; set; }

        public Duration C_ForecastHours { get; set; }

        public Duration ActualRegularEffort { get; set; }

        public Duration Work { get; set; }

        public Currency C_ActualCostRatewithOH { get; set; }

        public Currency C_CostRate { get; set; }

        public string C_ResourceCurrency { get; set; }
    }


    public class RegularResourceLinkToUpdate : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId WorkItem { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Resource { get; set; }
    }
}
