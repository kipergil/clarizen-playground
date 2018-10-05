using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class Document : EntityId
    {
        public byte[] Content { get; set; }
        public int ContentLength { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId StorageType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DocumentType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId FileType { get; set; }
    }
}