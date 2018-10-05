using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class NonLaborResourceLinkDirect : EntityId
    {
        //public string InternalId { get; set; } = null;

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId WorkItem { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId NonLaborResource { get; set; }

        /// <summary>
        /// E.g. /CurrencyType/USD
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DefaultCurrency { get; set; }

        /// <summary>
        /// /ExpenseType/Opex or /ExpenseType/Capex
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ExpenseType { get; set; }

        [JsonIgnore]
        public bool IsNewEntity { get; set; } = false;

        /*
        public Currency ActualCost { get; set; }

        public Currency ActualRevenue { get; set; }

        public Currency PlannedBudget { get; set; }

        public Currency PlannedRevenue { get; set; }

        public Currency ForecastCost { get; set; }

        public Currency ForecastRevenue { get; set; }

        public bool? Billable { get; set; }
        */

    }
}
