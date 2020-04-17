using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public partial class ChallengeLeaderboardPlayer
    {
        [JsonProperty("specializationid")]
        public int SpecializationId { get; set; }

        [JsonProperty("specializationrole")]
        public SpecializationRole SpecializationRole { get; set; }

        [JsonProperty("specializationname")]
        public string SpecializationName { get; set; }

        [JsonProperty("specializationicon")]
        public string SpecializationIcon { get; set; }

        [JsonProperty("playerinfo")]
        public ChallengeLeaderboardPlayerInfo PlayerInfo { get; set; }
    }
}