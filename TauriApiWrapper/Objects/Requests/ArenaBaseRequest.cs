using Newtonsoft.Json;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class ArenaBaseRequest : IApiParam
    {
        private Realm _realm;

        public ArenaBaseRequest(Realm realm)
        {
            _realm = realm;
        }

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}