using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class Timesheet : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ReportedBy { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId WorkItem { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Project { get; set; }

        public DateTime ReportedDate { get; set; }

        public Duration Duration { get; set; }

        [JsonIgnore]
        public string ReportedByName { get; set; }

        [JsonIgnore]
        public string WorkItemName { get; set; }

        #region Unused fields

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId ApprovedBy { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId CreatedBy { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId CreatorType { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId LastUpdatedBy { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId State { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId Project { get; set; }

        //public string EntityType { get; set; }
        //public DateTime? ApprovalDate { get; set; }
        //public DateTime? LastUpdatedBySystemOn { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public DateTime? LastUpdatedOn { get; set; }
        //public Currency BillingRate { get; set; }
        //public Currency Cost { get; set; }
        //public Currency CostRate { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId AssignedApprover { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId HumanResource { get; set; }

        //public bool Charged { get; set; }
        //public string Comment { get; set; }
        //public bool? DisableReportingTimeLimit { get; set; }
        //public string ExternalID { get; set; }
        //public bool Overtime { get; set; }
        //public Currency Price { get; set; }
        //public bool RegularHours { get; set; }

        //// Custom fields
        //public Currency C_ActualCost { get; set; }
        //public Currency C_BlendedCost { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId C_Category { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId C_JobTitle { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId C_TimesheetCategories { get; set; }

        #endregion

    }

    public class TimesheetGroupResult
    {
        public TimesheetGroupResult()
        {

        }
        public string ReportedDate { get; set; }
        public double TotalTime { get; set; }
    }

}
