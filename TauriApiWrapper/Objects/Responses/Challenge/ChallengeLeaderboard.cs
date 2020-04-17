using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public class ChallengeLeaderboard : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm realm { get; set; }

        [JsonProperty("mapdata")]
        public ChallengeIndexChallengeModeMaps Mapdata { get; set; }

        [JsonProperty("challengesdata")]
        public ChallengeLeaderboardChallengesData[] Challengesdata { get; set; }
    }
}
