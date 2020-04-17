using System;
using Newtonsoft.Json;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementChallengmode
    {
        [JsonProperty("completiontime"), JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan Completiontime { get; set; }

        [JsonProperty("completedtime"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime Completedtime { get; set; }

        [JsonProperty("medal")]
        public long? Medal { get; set; }

        [JsonProperty("playerrank")]
        public long? Playerrank { get; set; }

        [JsonProperty("guildrank")]
        public long? Guildrank { get; set; }

        [JsonProperty("players")]
        public Player[] Players { get; set; }

        [JsonProperty("guildinfo")]
        public Guildinfo Guildinfo { get; set; }
    }
}