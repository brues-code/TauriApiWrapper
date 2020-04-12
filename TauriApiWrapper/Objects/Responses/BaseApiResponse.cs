using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses
{
    public abstract class BaseApiResponse
    {
        [JsonProperty("isCata")]
        public bool IsCata { get; set; }

        [JsonProperty("expansion")]
        public int Expansion { get; set; }

        [JsonProperty("dataUrlPrefix")]
        public string DataUrlPrefix { get; set; }
    }
}