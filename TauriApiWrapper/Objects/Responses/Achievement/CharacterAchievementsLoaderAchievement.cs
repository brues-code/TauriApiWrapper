using Newtonsoft.Json;

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