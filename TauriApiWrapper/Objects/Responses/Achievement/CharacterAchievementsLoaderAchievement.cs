using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;


namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementsLoaderAchievement
    {
        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("catid")]
        public int Catid { get; set; }
    }
}
