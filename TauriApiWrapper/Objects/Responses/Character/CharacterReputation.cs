using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterReputation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descr")]
        public string Description { get; set; }

        [JsonProperty("standings")]
        public CharacterReputationStandings Standings { get; set; }

        [JsonProperty("standing")]
        public long Standing { get; set; }
    }
}