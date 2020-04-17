using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;


namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaTeamGameChart : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm realm { get; set; }

        [JsonProperty("team")]
        public ArenaTeam Team { get; set; }

        [JsonProperty("teamstats")]
        public ArenaTeamGameChartTeamstats Teamstats { get; set; }

        [JsonProperty("Season_start_time")]
        public int SeasonStartTime { get; set; }

        [JsonProperty("historyData")]
        public ArenaTeamGameChartHistoryData HistoryData { get; set; }

    }
}
