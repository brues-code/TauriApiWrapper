using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class EncounterRankingRequest : RaidListRequest
    {
        public EncounterRankingRequest(int encounter, int difficulty, Realm realm, int fromID = 0, int limit = 0) : base(realm, fromID: fromID, limit: limit)
        {
            Encounter = encounter;
            Difficulty = difficulty;
        }

        [JsonProperty("encounter")]
        public int Encounter { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }
}