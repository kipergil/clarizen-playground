using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class AbsenceRequest : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DataObjectType { get; set; } = new EntityId("/DataObjectType/Absence Request");

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId SourceObject { get; set; }      // Employee

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_AbsenceRequestsfor { get; set; }      // Employee

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_AbsenceEntitlement { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_LeaveType { get; set; }       // /C_DataLeaveType/Annual Leave

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_StartDateTimeOfDay { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_EndDateTimeOfDay { get; set; }

        //[JsonConverter(typeof(DurationConverter))]
        public Duration C_LeaveDuration { get; set; }

        public int? C_EntitlementYear { get; set; }
        public DateTime? C_LeaveStartDate { get; set; }
        public DateTime? C_LeaveEndDate { get; set; }
        public string Name { get; set; }
        public bool? C_PreapprovalGainedfromManager { get; set; }

        public enum DurationType { Unspecified, HalfDay, FullDay }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_AbsenceRequestStatus { get; set; }

        public AbsenceRequest()
        {

        }

        public AbsenceRequest(User user, AbsenceEntitlement entitlement, EntityId leaveType, int year, DateTime startDate, DurationType startDuration, DateTime endDate, DurationType endDuration, double duration)
        {
            if (user != null && entitlement != null && leaveType != null)
            {
                SourceObject = user;
                C_AbsenceRequestsfor = user;
                C_AbsenceEntitlement = entitlement;
                C_LeaveType = leaveType;
                C_EntitlementYear = year;
                C_LeaveStartDate = startDate;
                C_PreapprovalGainedfromManager = true;
                C_AbsenceRequestStatus = new EntityId("/C_DataAbsenceRequestStatus/Approved");
                switch (startDuration)
                {
                    case DurationType.FullDay:
                        C_StartDateTimeOfDay = new EntityId("/C_DataStartDateTimeOfDay/Full Day");
                        break;
                    case DurationType.HalfDay:
                        C_StartDateTimeOfDay = new EntityId("/C_DataStartDateTimeOfDay/PM Only");
                        break;
                }
                C_LeaveEndDate = endDate;
                if (duration == 0.5)
                {
                    C_EndDateTimeOfDay = new EntityId("/C_DataEndDateTimeOfDay/PM Only");
                }
                else
                {
                    switch (endDuration)
                    {
                        case DurationType.FullDay:
                            C_EndDateTimeOfDay = new EntityId("/C_DataEndDateTimeOfDay/Full Day");
                            break;
                        case DurationType.HalfDay:
                            C_EndDateTimeOfDay = new EntityId("/C_DataEndDateTimeOfDay/AM Only");
                            break;
                    }
                }
                C_LeaveDuration = new Duration("Days", duration, null);
                Name = "";
            }
        }

        public bool IsValid()
        {
            return C_AbsenceRequestsfor != null &&
                   C_AbsenceEntitlement != null &&
                   C_LeaveType != null &&
                   C_LeaveStartDate != null &&
                   C_StartDateTimeOfDay != null &&
                   C_LeaveEndDate != null &&
                   C_EndDateTimeOfDay != null &&
                   C_EntitlementYear != null;
        }

    }
}
