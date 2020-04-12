using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal class BattlePetTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(BattlePetType) || objectType == typeof(BattlePetType?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Aquatic":
                    return BattlePetType.Aquatic;

                case "Beast":
                    return BattlePetType.Beast;

                case "Critter":
                    return BattlePetType.Critter;

                case "Dragonkin":
                    return BattlePetType.Dragonkin;

                case "Elemental":
                    return BattlePetType.Elemental;

                case "Flying":
                    return BattlePetType.Flying;

                case "Humanoid":
                    return BattlePetType.Humanoid;

                case "Magic":
                    return BattlePetType.Magic;

                case "Mechanical":
                    return BattlePetType.Mechanical;

                case "Undead":
                    return BattlePetType.Undead;
            }
            throw new Exception("Cannot unmarshal type PettypeName");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            BattlePetType realm = (BattlePetType)value;

            serializer.Serialize(writer, realm.ToString());

            return;
        }
    }
}