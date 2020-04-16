using Newtonsoft.Json;

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