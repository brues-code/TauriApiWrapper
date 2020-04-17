using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class ArenaGameRequest : ArenaBaseRequest
    {
        public ArenaGameRequest(int matchId, Realm realm) : base(realm)
        {
            MatchId = matchId;
        }

        [JsonProperty("gid")]
        public int MatchId { get; set; }
    }
}