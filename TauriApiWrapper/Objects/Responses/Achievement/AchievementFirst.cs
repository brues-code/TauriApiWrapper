using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public class AchievementFirst : BaseApiResponse
    {
        [JsonProperty("achievementFirsts")]
        public Dictionary<string, AchievementFirstArray[]> AchievementFirstArray { get; set; }

        [JsonProperty("realmName"), JsonConverter(typeof(RealmNameConverter))]
        public Realm realm { get; set; }
    }
}