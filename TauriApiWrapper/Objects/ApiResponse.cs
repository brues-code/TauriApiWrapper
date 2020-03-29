using Newtonsoft.Json;

namespace TauriApiWrapper.Objects
{
    public abstract class ApiResponse<T>
    {
        [JsonProperty(PropertyName = "success")]
        public bool IsSuccess { get; set; }

        [JsonProperty(PropertyName = "errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty(PropertyName = "errorstring")]
        public string ErrorMessage { get; set; }

        [JsonProperty(PropertyName = "response")]
        public virtual T Response { get; set; }

        public virtual string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual ApiResponse<T> ToApiResponse(string response)
        {
            return JsonConvert.DeserializeObject<ApiResponse<T>>(response);
        }
    }
}