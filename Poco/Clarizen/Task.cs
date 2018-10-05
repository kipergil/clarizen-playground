using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    [Serializable]
    public class Task : EntityId
    {
        public string Name { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Parent { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Project { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId State { get; set; }

        public bool? Reportable { get; set; }

        public string EntityType { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? DueDate { get; set; }

        public double? C_ActualDaysBetweenStartDateandDueDate { get; set; }

        public double? C_ActualDaysbetweenStartandToday { get; set; }

        public Currency C_RevenueResourceLink { get; set; }

        public int ChildrenCount { get; set; }
    }
}
