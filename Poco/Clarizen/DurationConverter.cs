using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class DurationConverter : JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Duration)
            {
                Duration val = (Duration)value;
                writer.WriteValue(string.Format(@"""unit"" : ""{0}"", ""value"" : ""{1}""", val.Unit, val.Value));
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(Duration))
            {
                return serializer.Deserialize<Duration>(reader);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
