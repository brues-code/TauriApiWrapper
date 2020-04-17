using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ChallengeModeLeaderboardRequest : ChallengeModeBaseRequest
    {
        public ChallengeModeLeaderboardRequest(int mapId, Realm realm) : base(realm)
        {
            MapId = mapId;
        }

        [JsonProperty("map")]
        public int MapId { get; set; }
    }
}
