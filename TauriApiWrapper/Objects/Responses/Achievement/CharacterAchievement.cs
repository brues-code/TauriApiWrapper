using System;
using Newtonsoft.Json;
using TauriApiWrapper.Converters;


namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("catid")]
        public int Catid { get; set; }
    }
}