using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("catid")]
        public long Catid { get; set; }
    }
}