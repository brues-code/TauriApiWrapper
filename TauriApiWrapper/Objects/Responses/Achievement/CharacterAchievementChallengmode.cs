using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementChallengmode
    {
        [JsonProperty("completiontime", NullValueHandling = NullValueHandling.Ignore)]
        public long? Completiontime { get; set; }

        [JsonProperty("completedtime", NullValueHandling = NullValueHandling.Ignore)]
        public long? Completedtime { get; set; }

        [JsonProperty("medal", NullValueHandling = NullValueHandling.Ignore)]
        public long? Medal { get; set; }

        [JsonProperty("playerrank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Playerrank { get; set; }

        [JsonProperty("guildrank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Guildrank { get; set; }

        [JsonProperty("players", NullValueHandling = NullValueHandling.Ignore)]
        public Player[] Players { get; set; }

        [JsonProperty("guildinfo", NullValueHandling = NullValueHandling.Ignore)]
        public Guildinfo Guildinfo { get; set; }
    }
}
