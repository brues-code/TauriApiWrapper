using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    public class RaidDifficultyConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RaidDifficulty) || objectType == typeof(RaidDifficulty?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "10 Player":
                    return RaidDifficulty._10Player;

                case "10 Player (Heroic)":
                    return RaidDifficulty._10PlayerHeroic;

                case "25 Player":
                    return RaidDifficulty._25Player;

                case "25 Player (Heroic)":
                    return RaidDifficulty._25PlayerHeroic;

                case "40 Player":
                    return RaidDifficulty._40Player;

                case "Flexible":
                    return RaidDifficulty._Flexible;

                case "Looking For Raid":
                    return RaidDifficulty._LookingForRaid;
            }
            throw new Exception("Cannot marshal type RaidDifficulty");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            RaidDifficulty castedValue = (RaidDifficulty)value;
            switch (castedValue)
            {
                case RaidDifficulty._10Player:
                    serializer.Serialize(writer, "10 Player");
                    return;

                case RaidDifficulty._10PlayerHeroic:
                    serializer.Serialize(writer, "10 Player (Heroic)");
                    return;

                case RaidDifficulty._25Player:
                    serializer.Serialize(writer, "25 Player");
                    return;

                case RaidDifficulty._25PlayerHeroic:
                    serializer.Serialize(writer, "25 Player (Heroic)");
                    return;

                case RaidDifficulty._40Player:
                    serializer.Serialize(writer, "40 Player");
                    return;

                case RaidDifficulty._Flexible:
                    serializer.Serialize(writer, "Flexible");
                    return;

                case RaidDifficulty._LookingForRaid:
                    serializer.Serialize(writer, "Looking For Raid");
                    return;
            }
            throw new Exception("Cannot marshal type TimeLeft");
        }
    }
}