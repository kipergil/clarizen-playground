using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class GroupHierarchyLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Member { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Container { get; set; }
    }

   
}
