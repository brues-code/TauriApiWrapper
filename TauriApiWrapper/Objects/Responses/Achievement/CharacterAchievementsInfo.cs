using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementsInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("pid")]
        public long Pid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }
    }
}