using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;


namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementsLoaderCache
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("pts")]
        public int Pts { get; set; }

        [JsonProperty("reward")]
        public string Reward { get; set; }

        [JsonProperty("catid")]
        public int Catid { get; set; }

        [JsonProperty("criteria")]
        public Dictionary<string, CharacterAchievementsLoaderCriteria> Criteria { get; set; }
    }
}
