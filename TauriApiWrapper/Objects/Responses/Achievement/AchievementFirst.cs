using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public class AchievementFirst : BaseApiResponse
    {
        [JsonProperty("achievementFirsts")]
        public Dictionary<string, AchievementFirstArray[]> AchievementFirstArray { get; set; }

        [JsonProperty("realmName"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }
    }
}