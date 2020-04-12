using Newtonsoft.Json;
using System;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal class RealmNameConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Realm) || objectType == typeof(Realm?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            string value = serializer.Deserialize<string>(reader);

            switch (value)
            {
                case "[EN] Evermoon":
                    return Realm.Evermoon;

                case "[HU] Tauri WoW Server":
                    return Realm.Tauri;

                case "[HU] Warriors of Darkness":
                    return Realm.WoD;

                default:
                    return Realm.Evermoon;
            }

            throw new NotImplementedException("Unexpected realm name");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            Realm realm = (Realm)value;

            serializer.Serialize(writer, realm.ToName());

            return;
        }
    }
}