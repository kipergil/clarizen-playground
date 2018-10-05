using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class ReportedRevenueTypes
    {
        public static string JanRF { get; set; } = "Jan RF";
        public static string FebRF { get; set; } = "Feb RF";
        public static string MarRF { get; set; } = "Mar RF";
        public static string AprRF { get; set; } = "Apr RF";
        public static string MayRF { get; set; } = "May RF";
        public static string JunRF { get; set; } = "Jun RF";
        public static string JulRF { get; set; } = "Jul RF";
        public static string AugRF { get; set; } = "Aug RF";
        public static string SepRF { get; set; } = "Sep RF";
        public static string OctRF { get; set; } = "Oct RF";
        public static string NovRF { get; set; } = "Nov RF";
        public static string DecRF { get; set; } = "Dec RF";
        public static string CommittedRevenue { get; set; } = "Committed Revenue";
        public static string ReportedActualRevenue { get; set; } = "Reported Actual Revenue";
        public static string ReportedForecastRevenue { get; set; } = "Reported Forecast Revenue";
    }

    public class ReportedRevenueModel
    {
        public string CustomerName { get; set; }
        public string ReportedRevenueType { get; set; }
        public int Year { get; set; }
        public double Jan { get; set; }
        public double Feb { get; set; }
        public double Mar { get; set; }
        public double Apr { get; set; }
        public double May { get; set; }
        public double Jun { get; set; }
        public double Jul { get; set; }
        public double Aug { get; set; }
        public double Sep { get; set; }
        public double Oct { get; set; }
        public double Nov { get; set; }
        public double Dec { get; set; }
    }

    public class ReportedRevenue : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DataObjectType { get; set; } = new EntityId("/DataObjectType/Reported Revenue");

        public string Name { get; set; }

        /// <summary>
        /// Holds the revenue report type : Committed Revenue; Reported Forecast Revenue
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ReportedRevenueType { get; set; }  //C_DataReportedRevenueType

        /// <summary>
        /// this field holds the month name as January,February... etc
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_RevenueMonth { get; set; } //C_DataRevenueMonth

        /// <summary>
        /// this field holds the year name as 2017,2018... etc
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_RevenueYear { get; set; } //C_DataRevenueYear

        /// <summary>
        /// this field holds the amount ot the revenue
        /// </summary>
        public Currency C_Revenue { get; set; }

        /// <summary>
        /// this field holds the related Customer for this row
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ReportedRevenue { get; set; }
    }


    public class ReportedRevenueToUpdate : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DataObjectType { get; set; } = new EntityId("/DataObjectType/Reported Revenue");

        public string Name { get; set; }

        /// <summary>
        /// Holds the revenue report type : Committed Revenue; Reported Forecast Revenue
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ReportedRevenueType { get; set; }  //C_DataReportedRevenueType

        /// <summary>
        /// this field holds the month name as January,February... etc
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_RevenueMonth { get; set; } //C_DataRevenueMonth

        /// <summary>
        /// this field holds the year name as 2017,2018... etc
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_RevenueYear { get; set; } //C_DataRevenueYear

        /// <summary>
        /// this field holds the amount ot the revenue
        /// </summary>
        public Currency C_Revenue { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId SourceObject { get; set; }
    }
}
