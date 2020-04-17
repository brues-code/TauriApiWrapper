﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaLadder : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm realm { get; set; }

        [JsonProperty("teamType")]
        public TeamType TeamType{ get; set; }

        [JsonProperty("teamNum")]
        public int TeamNum { get; set; }

        [JsonProperty("teamList ")]
        public Dictionary<string, ArenaLadderTeamList> TeamList{ get; set; }
    }
}