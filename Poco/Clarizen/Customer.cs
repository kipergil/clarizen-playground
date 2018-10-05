using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class Customer : EntityId
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BusinessOwner { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CommercialManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CreatedbyWhichRegion { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CustomerLocation { get; set; }

        public bool? C_BLPackActive { get; set; }
        public bool? C_RateCard { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ProgramManager { get; set; }


    }

    public class CustomerSimplified : EntityId
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BusinessOwner { get; set; }
    }
}
