using System;
using Newtonsoft.Json;
using TauriApiWrapper.Converters;


namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("catid"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime Catid { get; set; }
    }
}