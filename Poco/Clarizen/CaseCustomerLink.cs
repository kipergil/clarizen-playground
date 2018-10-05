using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class CaseCustomerLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Customer { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Entity { get; set; }
    }

}
