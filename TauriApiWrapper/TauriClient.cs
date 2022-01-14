using RestSharp;
using System;
using System.Threading.Tasks;
using TauriApiWrapper.Objects;

namespace TauriApiWrapper
{
    public class TauriClient
    {
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
            SetRequestData(data, out RestClient client, out RestRequest request);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            return default;
        }

        private async Task<string> CallAPIAsync(ApiParams data)
        {
            SetRequestData(data, out RestClient client, out RestRequest request);
            IRestResponse response = await client.ExecuteAsync(request).ConfigureAwait(false);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            return default;
        }

        private void SetRequestData(ApiParams data, out RestClient client, out RestRequest request)
        {
            client = new RestClient(Endpoint);
            client.Timeout = -1;
            request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string requestData = data.ToJson();
            request.AddParameter("application/json", requestData, ParameterType.RequestBody);
        }

        #endregion Privates
    }
}