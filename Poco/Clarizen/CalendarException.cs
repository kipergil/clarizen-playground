using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class CalendarException: EntityId
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether this day is a working day
        /// </summary>
        public bool? WorkingDay { get; set; }

        /// <summary>
        /// Indicates whether this is an all day exception
        /// </summary>
        public bool? AllDay { get; set; }

        /// <summary>
        /// The type of the exception
        /// </summary>
        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId ExceptionType { get; set; }

        /// <summary>
        /// The date when the exception starts
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date when the exception ends
        /// </summary>
        public DateTime? EndDate { get; set; }

        public CalendarException() { }

        /// <summary>
        /// The type of the exception
        /// </summary>
        //[JsonConverter(typeof(EntityIdConverter))]
        //public EntityId EventCalendar { get; set; }

    }
}
