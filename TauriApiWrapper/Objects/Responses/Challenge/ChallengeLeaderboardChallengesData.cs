using System;
using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public partial class ChallengeLeaderboardChallengesData
    {
        [JsonProperty("completiontime"), JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan Completiontime { get; set; }

        [JsonProperty("completedtime"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime Completedtime { get; set; }

        [JsonProperty("medal")]
        public Medal Medal { get; set; }

        [JsonProperty("playerrank")]
        public int Playerrank { get; set; }

        [JsonProperty("guildrank")]
        public int Guildrank { get; set; }

        [JsonProperty("players")]
        public ChallengeLeaderboardPlayer[] Players { get; set; }

        [JsonProperty("guildinfo")]
        public ChallengeLeaderboardGuildInfo Guildinfo { get; set; }
    }
}
