using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal sealed class TeamTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TeamType) || objectType == typeof(TeamType?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            string value = serializer.Deserialize<string>(reader);

            switch (value)
            {
                case "2v2":
                    return TeamType._2v2;

                case "3v3":
                    return TeamType._3v3;

                case "5v5":
                    return TeamType._5v5;
            }
            throw new Exception("Unexpected team type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            TeamType castedValue = (TeamType)value;
            switch (castedValue)
            {
                case TeamType._2v2:
                    serializer.Serialize(writer, "2v2");
                    return;

                case TeamType._3v3:
                    serializer.Serialize(writer, "3v3");
                    return;

                case TeamType._5v5:
                    serializer.Serialize(writer, "5v5");
                    return;
            }
            throw new Exception("Cannot marshal type TeamType");
        }
    }
}