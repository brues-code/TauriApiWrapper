using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementsSkindata
    {
        [JsonProperty("skinstyle")]
        public int Skinstyle { get; set; }

        [JsonProperty("facecolor")]
        public int Facecolor { get; set; }

        [JsonProperty("hairstyle")]
        public int Hairstyle { get; set; }

        [JsonProperty("haircolor")]
        public int Haircolor { get; set; }

        [JsonProperty("facialhair")]
        public int Facialhair { get; set; }
    }
}
