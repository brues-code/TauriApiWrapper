using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public partial class Player
    {
        [JsonProperty("specializationid")]
        public int Specializationid { get; set; }

        [JsonProperty("specializationrole")]
        public int Specializationrole { get; set; }

        [JsonProperty("specializationname")]
        public string Specializationname { get; set; }

        [JsonProperty("specializationicon")]
        public string Specializationicon { get; set; }

        [JsonProperty("playerinfo")]
        public Playerinfo Playerinfo { get; set; }
    }
}