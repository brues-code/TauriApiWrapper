using Newtonsoft.Json;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects
{
    public abstract class BaseRequestObject : IApiParam
    {
        private readonly Realm _realm;

        public BaseRequestObject(Realm realm)
        {
            _realm = realm;
        }

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}