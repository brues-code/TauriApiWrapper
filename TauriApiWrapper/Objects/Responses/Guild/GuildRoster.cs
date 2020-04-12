using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public class GuildRoster : BaseGuildInfo
    {
        [JsonProperty("guildList")]
        public Dictionary<string, GuildPlayer> GuildList { get; set; }

        [JsonProperty("gRanks")]
        public Dictionary<string, GuildRank> GuildRanks { get; set; }
    }
}