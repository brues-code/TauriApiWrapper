using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class Player
    {
        [JsonProperty("specializationid")]
        public int Specializationid { get; set; }

        [JsonProperty("specializationrole")]
        public int Specializationrole { get; set; }

        [JsonProperty("specializationname")]
        public string Specializationname { get; set; }

        [JsonProperty("specializationicon")]
        public string Specializationicon { get; set; }

        [JsonProperty("playerinfo")]
        public PlayerInfo Playerinfo { get; set; }
    }

    public sealed class PlayerInfo
    {
        [JsonProperty("charname")]
        public string Charname { get; set; }

        [JsonProperty("race")]
        public int Race { get; set; }

        [JsonProperty("class")]
        public int Class { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("guildname")]
        public string Guildname { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("faction")]
        public int Faction { get; set; }
    }
}