using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class GuildRaidLogRequest : RaidListRequest
    {
        public GuildRaidLogRequest(string name, Realm realm, int fromID = 0, int limit = 0) : base(realm, fromID: fromID, limit: limit)
        {
            GuildName = name;
        }

        [JsonProperty("gn")]
        public string GuildName { get; set; }
    }
}