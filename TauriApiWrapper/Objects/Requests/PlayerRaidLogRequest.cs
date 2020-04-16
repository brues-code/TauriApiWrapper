using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class PlayerRaidLogRequest : RaidListRequest
    {
        public PlayerRaidLogRequest(string name, Realm realm, int fromID = 0, int limit = 0) : base(realm, fromID: fromID, limit: limit)
        {
            Name = name;
        }

        [JsonProperty("cn")]
        public string Name { get; set; }
    }
}