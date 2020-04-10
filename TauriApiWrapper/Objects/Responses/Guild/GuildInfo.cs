using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("faction")]
        public int Faction { get; set; }

        [JsonProperty("leadername")]
        public string LeaderName { get; set; }
    }
}