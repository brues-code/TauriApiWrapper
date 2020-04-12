using Newtonsoft.Json;

namespace TauriApiWrapper.Objects
{
    public class ApiParams
    {
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; private set; }

        [JsonProperty(PropertyName = "params")]
        public IApiParam Params { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; }

        #region Ctor

        public ApiParams()
        {
        }

        public ApiParams(string url, string secret, IApiParam apiParams)
        {
            Url = url;
            Secret = secret;
            Params = apiParams;
        }

        #endregion Ctor

        #region Public Methods

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion Public Methods
    }
}