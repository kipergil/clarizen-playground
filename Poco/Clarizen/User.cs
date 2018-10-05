using System;
using System.Collections.Generic;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class User : EntityId
    {
        // Built in Clarizen fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId JobTitle { get; set; }

        // Account fields
        public bool? SendInvitationMail { get; set; }
        public bool? Admin { get; set; }
        public bool? SuperUser { get; set; }
        public bool? Financial { get; set; }
        public bool? C_Placeholder { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId LicenseType { get; set; }

        // Custom fields
        public DateTime? C_TimesheetsCompletedUntil { get; set; }
        public string C_AltairCode { get; set; }            // Used for syncing
        public bool? C_IsActive { get; set; }
        public DateTime? C_ActualLeavingDate { get; set; }
        public DateTime? C_ExpectedLeaveDate { get; set; }
        public DateTime? C_SeniorityDate { get; set; }
        public bool? C_Temporary { get; set; }
        public Duration C_ContractHours { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ContractStatus { get; set; }
        public string C_PositionTitle { get; set; }
        public bool? C_IsExpert { get; set; }
        public bool? C_DontSyncDisplayName { get; set; }
        public bool? C_DontSyncAbsence { get; set; }
        public bool? C_DontSyncLicenseType { get; set; }
        public double? C_ContractFTEEquiv { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Gender { get; set; }
        public string C_Ethnicity { get; set; }

        public bool? C_ExemptFromTimePrompt { get; set; }

        // Direct manager
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DirectManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_AbsenceManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_AbsenceManager2 { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_TimesheetingPA { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_TimesheetingPA2 { get; set; }

        // Org structure
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BBHRegion { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Discipline { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BBHDepartment { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_1ResourceManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_2ResourceManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_3ResourceManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_4ResourceManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_5ResourceManager { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Profile { get; set; }

        public string EntityType { get; set; }

        public string C_SalaryCurrency { get; set; }

        public double? TargetUtilization { get; set; }

        public DateTime? C_LatestTimepromptRequestDate { get; set; }

        [JsonIgnore]
        private List<EntityId> _managerList;

        public DateTime? C_TimesheetingActivationDate;

        public bool? AllowEmails { get; set; }

        [JsonIgnore]
        public List<EntityId> ManagerList
        {
            get
            {
                _managerList = new List<EntityId>
                {
                    this.DirectManager,
                    this.C_AbsenceManager,
                    this.C_AbsenceManager2,
                    this.C_1ResourceManager,
                    this.C_2ResourceManager,
                    this.C_3ResourceManager,
                    this.C_4ResourceManager,
                    this.C_5ResourceManager,
                    this.C_TimesheetingPA,
                    this.C_TimesheetingPA2
                };
                return _managerList;
            }
        }

        public string Location { get; set; }
        public string C_Country { get; set; }


        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId State { get; set; }

        public DateTime? C_InactivatedDate { get; set; }
        public DateTime? C_DateLastCompleted { get; set; }
    }



    public class UserSimple : EntityId
    {
        // Built in Clarizen fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }

        // Org structure
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Discipline { get; set; }
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_BBHDepartment { get; set; }

        public string EntityType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId JobTitle { get; set; }

        public DateTime? C_DateLastCompleted { get; set; }
    }

    public class UserSimplified : EntityId
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? C_DateLastCompleted { get; set; }
    }

}
