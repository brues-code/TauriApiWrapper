using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public partial class ChallengeLeaderboardGuildInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        [JsonProperty("leadername")]
        public string Leadername { get; set; }
    }
}
