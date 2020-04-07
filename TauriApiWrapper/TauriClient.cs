using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TauriApiWrapper.Objects;

namespace TauriApiWrapper
{
    public abstract class TauriClient : IDisposable
    {
        #region Fields

        private Lazy<HttpClient> _client = new Lazy<HttpClient>(() => new HttpClient(), LazyThreadSafetyMode.ExecutionAndPublication);

        private HttpClient Client => _client.Value;

        private readonly string _apiKey;
        protected readonly string Secret;

        private string Endpoint
        {
            get
            {
                return $"{Uri.UriSchemeHttp}{Uri.SchemeDelimiter}chapi.tauri.hu/apiIndex.php?apikey={_apiKey}";
            }
        }

        #endregion Fields

        #region Ctor

        public TauriClient(string apiKey, string secretKey)
        {
            _apiKey = apiKey;
            Secret = secretKey;
        }

        #endregion Ctor

        #region Methods

        protected ApiResponse<T> Communicate<T>(ApiParams data)
        {
            return CommunicateAsync<T>(data).GetAwaiter().GetResult();
        }

        protected async Task<ApiResponse<T>> CommunicateAsync<T>(ApiParams data)
        {
            ApiResponse<T> apiObject = new ApiResponse<T>();
            var response = await CallAPI(data);
            var result = await response.Content.ReadAsStringAsync();
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

        #region Dispose

        public void Dispose()
        {
            if (_client.IsValueCreated)
            {
                _client.Value.Dispose();
            }
        }

        #endregion Dispose
    }
}