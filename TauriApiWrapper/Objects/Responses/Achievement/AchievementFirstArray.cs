using System;
using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class AchievementFirstArray
    {
        [JsonProperty("charname")]
        public string Name { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("guildname")]
        public string GuildName { get; set; }

        [JsonProperty("name")]
        public string AchievementName { get; set; }

        [JsonProperty("description")]
        public string AchievementDescription { get; set; }

        [JsonProperty("point")]
        public int AchievementPoint { get; set; }

        [JsonProperty("reward")]
        public string AchievementReward { get; set; }

        [JsonProperty("timestamp"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime AchievementTimestamp { get; set; }
    }
}