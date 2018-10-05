using System;
using System.Collections.Generic;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class QueueTask
    {
        public string Task { get; set; }
        public string PreviousResource { get; set; }
    }

    public class Permission : EntityId
    {
        public double? Role { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Entity { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Resource { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId EntityType { get; set; }

        public string C_ManagerRole { get; set; }

    }

    public class PermissionToUpdate : EntityId
    {
        public string C_ManagerRole { get; set; }
    }

    public class ManagerResourceLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId WorkItem { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ResourceRole { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ManagerRole { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId EntityType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Resource { get; set; }
    }

    public class ReviewerLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId WorkItem { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId EntityType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Resource { get; set; }

        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId Role { get; set; }
    }


    public class Profile : EntityId
    {
        public string Name { get; set; }
    }


    public class ProfileLink : EntityId
    {
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Container { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId Member { get; set; }

    }


    public class Report : EntityId
    {
        public string Name { get; set; }
    }

    public static class PermissionHelper
    {
        public static string GetPermissionResourceType(PermissionResourceType type, string entityId)
        {
            return $"/{type.ToString()}/{entityId}";
        }

        public static string GetPermissionEntityType(PermissionEntityType type, string entityId)
        {
            return $"/{type.ToString()}/{entityId}";
        }

        public static double GetPermissionRole(PermissionRole role)
        {
            return Convert.ToDouble(role);
        }
    }

    public class Role : EntityId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool? IsDefault { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId EntityType { get; set; }
    }

    public enum PermissionRole
    {
        None = 0,
        Viewer = 16777216,
        Editor = 67108864,
        Owner = 33554432,
        UNKNOWN1 = 134217728,
        UNKNOWN2 = 8388608
    }

    public enum PermissionResourceType
    {
        None = 0,
        AuthorizationGroup,
        UserGroup,
        User,
        Profile,
    }

    public enum PermissionEntityType
    {
        None = 0,
        Report,
        SubsystemView,
        Project,
        Dashboard,
        Customer,
        ObjectDetailsView,
        FolderForReport,
        TimesheetView,
    }

    public class PermissionUpdateResult
    {
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public List<Permission> AddedPermissions { get; set; }
        public List<Permission> UpdatedPermissions { get; set; }
        public List<Permission> DeletedPermissions { get; set; }
        public string DebugLog { get; set; }

        public PermissionUpdateResult()
        {
            AddedPermissions = new List<Permission>();
            UpdatedPermissions = new List<Permission>();
            DeletedPermissions = new List<Permission>();
            DebugLog = string.Empty;
        }
    }

}
