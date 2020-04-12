using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal class TimeLeftConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeLeft) || objectType == typeof(TimeLeft?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "LONG":
                    return TimeLeft.Long;

                case "MEDIUM":
                    return TimeLeft.Medium;

                case "SHORT":
                    return TimeLeft.Short;

                case "VERY_LONG":
                    return TimeLeft.VeryLong;
            }
            throw new Exception("Cannot marshal type TimeLeft");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            TimeLeft castedValue = (TimeLeft)value;
            switch (castedValue)
            {
                case TimeLeft.Long:
                    serializer.Serialize(writer, "LONG");
                    return;

                case TimeLeft.Medium:
                    serializer.Serialize(writer, "MEDIUM");
                    return;

                case TimeLeft.Short:
                    serializer.Serialize(writer, "SHORT");
                    return;

                case TimeLeft.VeryLong:
                    serializer.Serialize(writer, "VERY_LONG");
                    return;
            }
            throw new Exception("Cannot marshal type TimeLeft");
        }
    }
}