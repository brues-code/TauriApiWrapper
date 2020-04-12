using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class GuildRequest : BaseRequestObject
    {
        public GuildRequest(string name, Realm realm) : base(realm)
        {
            GuildName = name;
        }

        [JsonProperty("gn")]
        public string GuildName { get; set; }
    }
}