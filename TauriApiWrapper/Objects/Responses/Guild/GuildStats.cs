using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildStats : GuildRoster
    {
        [JsonProperty("statList")]
        public new Dictionary<string, GuildPlayer> GuildList { get; set; }
    }
}