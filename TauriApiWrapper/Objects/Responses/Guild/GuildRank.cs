using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildRank
    {
        [JsonProperty("rights")]
        public long Rights { get; set; }

        [JsonProperty("rname")]
        public string RankName { get; set; }
    }
}