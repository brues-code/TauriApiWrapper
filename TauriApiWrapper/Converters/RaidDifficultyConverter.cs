using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal sealed class RaidDifficultyConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RaidDifficulty) || objectType == typeof(RaidDifficulty?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            return value switch
            {
                "10 Player" => RaidDifficulty._10Player,
                "10 Player (Heroic)" => RaidDifficulty._10PlayerHeroic,
                "25 Player" => RaidDifficulty._25Player,
                "25 Player (Heroic)" => RaidDifficulty._25PlayerHeroic,
                "40 Player" => RaidDifficulty._40Player,
                "Flexible" => RaidDifficulty._Flexible,
                "Looking For Raid" => RaidDifficulty._LookingForRaid,
                _ => throw new Exception("Cannot marshal type RaidDifficulty"),
            };
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

                default:
                    throw new Exception("Cannot marshal type TimeLeft");
            }
        }
    }
}