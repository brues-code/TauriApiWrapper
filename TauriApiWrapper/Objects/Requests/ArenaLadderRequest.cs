using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class ArenaLadderRequest : ArenaBaseRequest
    {
        public ArenaLadderRequest(int teamSize, Realm realm) : base(realm)
        {
            TeamSize = teamSize;
        }

        [JsonProperty("ts")]
        public int TeamSize { get; set; }
    }
}
