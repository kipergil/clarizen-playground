using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class DataImport : EntityId
    {
        public string Name { get; set; }

        // 2000 chars max
        public string C_Import_Results { get; set; }

        // Values:
        // /C_DataImport_Status/Import Request Created
        // /C_DataImport_Status/Sent to API
        // /C_DataImport_Status/API Completed
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Import_Status { get; set; }

        public bool? C_Import_Successful { get; set; }

        public DateTime? C_Import_Start_Date { get; set; }

        public DateTime? C_Import_End_Date { get; set; }
    }
}
