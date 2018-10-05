using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class NonLaborResource : EntityId
    {
        //public string InternalId { get; set; } = null;

        public string Name { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ExpenseType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId NLRCategory { get; set; }

        public bool? Billable { get; set; }

        [JsonIgnore]
        public bool IsNewEntity { get; set; } = false;
    }
}
