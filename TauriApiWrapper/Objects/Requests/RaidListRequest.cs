using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class RaidListRequest : BaseRequestObject
    {
        public RaidListRequest(Realm realm, int fromID = 0, int limit = 0) : base(realm)
        {
            From = fromID;
            Limit = limit;
        }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}