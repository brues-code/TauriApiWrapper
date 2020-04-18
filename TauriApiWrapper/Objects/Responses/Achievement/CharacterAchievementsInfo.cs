using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class CharacterAchievementsInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }
}