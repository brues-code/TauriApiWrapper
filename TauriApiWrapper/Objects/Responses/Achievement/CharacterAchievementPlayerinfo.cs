using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class Playerinfo
    {
        [JsonProperty("charname")]
        public string Charname { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("guildname")]
        public string Guildname { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }
    }
}