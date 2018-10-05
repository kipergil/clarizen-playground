using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class NonLaborResourceTimePhase : EntityId
    {
        //public string InternalId { get; set; } = null;

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId RelatedLink { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? FiscalMonth { get; set; }

        //public Currency C_USDAmount { get; set; }

        public Currency ActualCost { get; set; }

        public Currency ForecastRevenue { get; set; }

        //public Currency ActualRevenue { get; set; }

        public Currency PlannedBudget { get; set; }

        //public Currency PlannedRevenue { get; set; }

        public Currency ForecastCost { get; set; }

        //public Currency ForecastRevenue { get; set; }

        public double? C_IsLocked { get; set; }
    }
}
