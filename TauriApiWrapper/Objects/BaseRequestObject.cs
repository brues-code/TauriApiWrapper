using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;

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