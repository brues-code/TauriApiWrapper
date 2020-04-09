using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public sealed class BlackMarketRequest : IApiParam
    {
        private Realm _realm;

        public BlackMarketRequest(Realm realm) => _realm = realm;

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}