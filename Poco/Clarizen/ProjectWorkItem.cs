using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class ProjectWorkItem : EntityId
    {
        public string Name { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Project { get; set; }
        public DateTime C_Today { get; set; }
        public string EntityType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId RevenueCurrencyType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId CostCurrencyType { get; set; }
    }
}
