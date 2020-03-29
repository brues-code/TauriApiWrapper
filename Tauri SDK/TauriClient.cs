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
        private readonly string _secret;

        private string _endpoint
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
            _secret = secretKey;
        }

        #endregion Ctor

        #region Methods

        public T Communicate<T>(ApiParams data) where T : ApiResponse<T>, new()
        {
            return CommunicateAsync<T>(data).GetAwaiter().GetResult();
        }

        public async Task<T> CommunicateAsync<T>(ApiParams data) where T : ApiResponse<T>, new()
        {
            T apiObject = new T();
            var response = await CallAPI(data);
            var result = await response.Content.ReadAsStringAsync();
            return (T)apiObject.ToApiResponse(result);
        }

        #endregion Methods

        #region Privates

        private async Task<HttpResponseMessage> CallAPI(ApiParams data)
        {
            StringContent json = new StringContent(data.ToJSON(), Encoding.UTF8, "application/json");
            return await Client.PostAsync(_endpoint, json);
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