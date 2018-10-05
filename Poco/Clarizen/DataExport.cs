using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class DataExport : EntityId
    {
        public string Name { get; set; }

        // 2000 chars max
        public string C_Export_Results { get; set; }

        // Values:
        // /C_DataImport_Status/Import Request Created
        // /C_DataImport_Status/Sent to API
        // /C_DataImport_Status/API Completed
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Export_Status { get; set; }

        public bool? C_Export_Successful { get; set; }

        public DateTime? C_Export_Start_Date { get; set; }

        public DateTime? C_Export_End_Date { get; set; }
    }
}
