using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TauriApiWrapper.Objects;

namespace TauriApiWrapper
{
    public class TauriClient
    {
        private static HttpClient _client = new HttpClient();
        public TauriClient(string apiKey, string apiSecret, bool useStormforgeApi)
        {
            ApiKey = apiKey;
            IsStormforge = useStormforgeApi;
            ApiSecret = apiSecret;
        }

        #region Fields 


        private readonly string ApiKey;
        private readonly bool IsStormforge;
        internal readonly string ApiSecret;


        public static readonly string InvalidExpansion = "This expansion is invalid or not supported for this method.";

        #endregion Fields

        #region Private Properties

        private string Endpoint
        {
            get
            {
                if (IsStormforge)
                {
                    return $"{Uri.UriSchemeHttps}{Uri.SchemeDelimiter}characters-api.stormforge.gg/v1/?apikey={ApiKey}";
                }

                return $"{Uri.UriSchemeHttp}{Uri.SchemeDelimiter}chapi.tauri.hu/apiIndex.php?apikey={ApiKey}";
            }
        }

        #endregion Private Properties

        #region Methods

        internal ApiResponse<T> Communicate<T>(ApiParams data) where T : class
        {
            ApiResponse<T> apiObject = new ApiResponse<T>();
            string response = CallAPI(data);

            if (!string.IsNullOrEmpty(response))
            {
                return apiObject.ToApiResponse(response);
            }

            return apiObject;
        }

        internal async Task<ApiResponse<T>> CommunicateAsync<T>(ApiParams data) where T : class
        {
            ApiResponse<T> apiObject = new ApiResponse<T>();
            string response = await CallAPIAsync(data).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(response))
            {
                return apiObject.ToApiResponse(response);
            }

            return apiObject;
        }

        #endregion Methods

        #region Privates

        private string CallAPI(ApiParams data)
        {
           return CallAPIAsync(data).GetAwaiter().GetResult();
        }

        private async Task<string> CallAPIAsync(ApiParams data)
        {
            using HttpResponseMessage response = await _client.PostAsync(Endpoint, SetRequestData(data)).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            return default;
        }

        private StringContent SetRequestData(ApiParams data)
        {
            return new StringContent(data.ToJson(), Encoding.UTF8, "application/json");
        }

        #endregion Privates
    }
}