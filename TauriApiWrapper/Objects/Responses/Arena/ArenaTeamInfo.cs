using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaTeamInfo : BaseApiResponse
    {
        [JsonProperty("item")]
        public int ItemID { get; set; }

        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm realm { get; set; }

        [JsonProperty("team")]
        public ArenaTeam Team { get; set; }

        [JsonProperty("teamstats")]
        public ArenaTeamInfoTeamstats Teamstats { get; set; }

        [JsonProperty("teamMembers")]
        public ArenaTeamInfoTeamMembers TeamMembers { get; set; }
    }
}