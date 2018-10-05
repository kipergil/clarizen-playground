using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class AbsenceEntitlement : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DataObjectType { get; set; } = new EntityId("/DataObjectType/Absence Entitlement");

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId SourceObject { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_LeaveEntitlementfor { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_LeaveType { get; set; }

        [JsonConverter(typeof(DurationConverter))]
        public Duration C_DaysBooked { get; set; }

        public int C_EntitlementYear { get; set; }
        public double C_EntitledDays { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public string DisplayName { get; set; }

        [JsonIgnore]
        public double DaysLeft
        {
            get
            {
                if (C_DaysBooked == null)
                {
                    return C_EntitledDays;
                }
                switch (C_DaysBooked.Unit.ToLower())
                {
                    case "days":
                        return C_EntitledDays - C_DaysBooked.Value;
                    case "hours":
                        return C_EntitledDays - (C_DaysBooked.Value / 8);
                    case "weeks":
                        return C_EntitledDays - (C_DaysBooked.Value * 7);
                }
                return 0;
            }
        }

        public AbsenceEntitlement()
        {

        }

        public AbsenceEntitlement(User user, int year, string leaveType, double entitledDays)
        {
            if (user != null)
            {
                SourceObject = user;
                C_LeaveEntitlementfor = user;
                C_LeaveType = new EntityId(leaveType.StartsWith("/C_DataLeaveType/", StringComparison.InvariantCultureIgnoreCase) ? leaveType : "/C_DataLeaveType/" + leaveType);
                C_EntitlementYear = year;
                C_EntitledDays = entitledDays;
                Name = string.Format("{0} - {1}", year, leaveType.StartsWith("/C_DataLeaveType/", StringComparison.InvariantCultureIgnoreCase) ? leaveType.Substring(17) : leaveType);
            }
        }

    }
}
