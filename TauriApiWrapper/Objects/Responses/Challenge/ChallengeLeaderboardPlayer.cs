using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public partial class ChallengeLeaderboardPlayer
    {
        [JsonProperty("specializationid")]
        public int Specializationid { get; set; }

        [JsonProperty("specializationrole")]
        public SpecializationRole Specializationrole { get; set; }

        [JsonProperty("specializationname")]
        public string Specializationname { get; set; }

        [JsonProperty("specializationicon")]
        public string Specializationicon { get; set; }

        [JsonProperty("playerinfo")]
        public ChallengeLeaderboardPlayerInfo Playerinfo { get; set; }
    }
}
