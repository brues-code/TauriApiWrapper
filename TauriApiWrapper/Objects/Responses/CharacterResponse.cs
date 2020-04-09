using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses
{
    public class CharacterResponse : BaseApiResponse
    {
        [JsonProperty("charname")]
        public string Charname { get; set; }

        [JsonProperty("race")]
        public long Race { get; set; }

        [JsonProperty("class")]
        public long Class { get; set; }

        [JsonProperty("gender")]
        public long Gender { get; set; }

        [JsonProperty("guildname")]
        public string Guildname { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("faction")]
        public long Faction { get; set; }

        [JsonProperty("isCharacter")]
        public bool IsCharacter { get; set; }
    }
}