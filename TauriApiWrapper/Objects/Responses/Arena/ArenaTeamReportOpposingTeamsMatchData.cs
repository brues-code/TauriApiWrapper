using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public partial class ArenaTeamReportOpposingTeamsMatchData
    {
        [JsonProperty("EnemyTeamId")]
        public int EnemyTeamId { get; set; }

        [JsonProperty("EnemyTeamName")]
        public string EnemyTeamName { get; set; }

        [JsonProperty("EnemyRating")]
        public int EnemyRating { get; set; }

        [JsonProperty("EnemyRatingChange")]
        public int EnemyRatingChange { get; set; }

        [JsonProperty("TeamRating")]
        public int TeamRating { get; set; }

        [JsonProperty("TeamRatingChange")]
        public int TeamRatingChange { get; set; }

        [JsonProperty("MatchLength")]
        public int MatchLength { get; set; }

        [JsonProperty("realm")]
        public Realm Realm { get; set; }

        [JsonProperty("matchId")]
        public int MatchId { get; set; }

        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("matchs")]
        public int Matchs { get; set; }
    }
}