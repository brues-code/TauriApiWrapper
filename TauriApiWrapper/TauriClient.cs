using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TauriApiWrapper.Objects;

namespace TauriApiWrapper
{
    public abstract class TauriClient
    {
        #region Fields

        private static readonly HttpClientHandler httpClientHandler = new HttpClientHandler { MaxConnectionsPerServer = 10 };
        private static readonly HttpClient Client = new HttpClient(httpClientHandler) { Timeout = TimeSpan.FromSeconds(15) };
        private readonly string _apiKey;
        protected readonly string Secret;

        protected readonly string InvalidExpansion = "This expansion is invalid or not supported for this method.";

        #endregion Fields

        #region Private Properties

        private string Endpoint
        {
            get
            {
                return $"{Uri.UriSchemeHttp}{Uri.SchemeDelimiter}chapi.tauri.hu/apiIndex.php?apikey={_apiKey}";
            }
        }

        #endregion Private Properties

        #region Ctor

        public TauriClient(string apiKey, string secretKey)
        {
            _apiKey = apiKey;
            Secret = secretKey;
        }

        #endregion Ctor

        #region Methods

        protected ApiResponse<T> Communicate<T>(ApiParams data) where T : class
        {
            return CommunicateAsync<T>(data).GetAwaiter().GetResult();
        }

        protected async Task<ApiResponse<T>> CommunicateAsync<T>(ApiParams data) where T : class
        {
            ApiResponse<T> apiObject = new ApiResponse<T>();
            string response = await CallAPI(data).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(response))
            {
                return apiObject.ToApiResponse(response);
            }

            return apiObject;
        }

        #endregion Methods

        #region Privates

        private async Task<string> CallAPI(ApiParams data)
        {
            StringContent json = new StringContent(data.ToJSON(), Encoding.UTF8, "application/json");
            using var response = await Client.PostAsync(Endpoint, json).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return result;
            }

            return default;
        }

        #endregion Privates
    }
}