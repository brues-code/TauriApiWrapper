using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class RaidLogsResponse
    {
        [JsonProperty("logs")]
        public RaidLog[] Logs { get; set; }
    }
}