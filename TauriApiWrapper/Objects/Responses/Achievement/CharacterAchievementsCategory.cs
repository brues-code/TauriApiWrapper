using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementsCategory
    {
        [JsonProperty("info")]
        public CharacterAchievementsInfo Info { get; set; }

        [JsonProperty("subcat", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, CharacterAchievementsInfo> Subcat { get; set; }
    }
}