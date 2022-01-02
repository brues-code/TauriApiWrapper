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

        private static HttpClient Client = new HttpClient();
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
            var response = await CallAPI(data).ConfigureAwait(false);
            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return apiObject.ToApiResponse(result);
        }

        #endregion Methods

        #region Privates

        private async Task<HttpResponseMessage> CallAPI(ApiParams data)
        {
            StringContent json = new StringContent(data.ToJSON(), Encoding.UTF8, "application/json");
            return await Client.PostAsync(Endpoint, json);
        }

        #endregion Privates
    }
}