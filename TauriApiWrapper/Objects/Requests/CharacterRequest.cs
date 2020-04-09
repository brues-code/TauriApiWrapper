using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class CharacterRequest : BaseRequestObject
    {
        public CharacterRequest(string name, Realm realm) : base(realm)
        {
            CharacterName = name;
        }

        [JsonProperty("cn")]
        public string CharacterName { get; set; }
    }
}