using Newtonsoft.Json;
using System.IO;

namespace TauriApiWrapperTests
{
    internal class ApiCredentials
    {
        [JsonProperty("APIKEY")]
        public string ApiKey { get; set; }

        [JsonProperty("APISECRET")]
        public string ApiSecret { get; set; }

        public static ApiCredentials GetCredentials()
        {
            return JsonConvert.DeserializeObject<ApiCredentials>(File.ReadAllText("../../../settings.json"));
        }
    }
}