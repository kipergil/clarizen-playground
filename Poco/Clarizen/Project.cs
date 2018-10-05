using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public enum ProjectTypes
    {
        None,
        admin,
        awards,
        billable,
        intercompany,
        internalprojects,
        newbizgeneral,
        pitch,
        probono,
        training,
    }

    public enum ProjectTypesOfOpportunity
    {
        None,
        newbiz,
        organic
    }

    public class ProjectToUpdate : EntityId
    {
        public bool C_UnsellInProgress { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId RevenueCurrencyType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId CostCurrencyType { get; set; }
    }

    public class ProjectToUpdateForFinancials : EntityId
    {
        public int? FinancialStart { get; set; }
        public int? FinancialEnd { get; set; }
    }


    public class Project : EntityId
    {
        public string Name { get; set; }
        public bool? C_UnsellInProgress { get; set; }
        public Duration Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public Currency C_Revenue { get; set; }
        public Currency C_SoldRevenue { get; set; }
        public Currency C_BurntFeeResourceLink { get; set; }
        public Currency C_TotalRevenue { get; set; }
        public Currency C_DiscountRebate { get; set; }
        public Currency C_ExchangeRateDifference { get; set; }
        public Currency C_Bonus { get; set; }

        public object C_Burnt { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ProjectPhase { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BBHPrimaryCustomer { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BBHRequest { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ParentProject { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ProjectType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_TypeofOpportunity { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId State { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Discipline { get; set; }

        public string C_PONumber { get; set; }

        public string InternalId { get; set; }

        public Currency C_ForecastBurntFeeResourceLink { get; set; }

        public double? C_SoldProfitMargin { get; set; }

        public double? C_TotalSoldProfitMargin { get; set; }

        public double? C_ActualMargin { get; set; }

        public double? C_ForecastProfitMarginWI { get; set; }

        public double? C_TotalForecastProfitMargin { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BudgetStatusWI { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_TotalFinancialStatus { get; set; }

        public Currency C_SoldRevnueResourceLink { get; set; }

        public Currency C_SoldCostResourceLink { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ProjectManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId TrackStatus { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BillableProjectType { get; set; }

        public Currency C_ActualCostResourceLink { get; set; }

        public Currency C_ActualRevenue2 { get; set; }

        public Currency C_ForecastresourceCost { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId RevenueCurrencyType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId CostCurrencyType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Manager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_CreatedbyRegion { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId CreatedBy { get; set; }

        public int? FinancialStart { get; set; }
        public int? FinancialEnd { get; set; }

        public bool? C_RateCardClient { get; set; }
        public bool? C_RateCardAdded { get; set; }
    }


}
