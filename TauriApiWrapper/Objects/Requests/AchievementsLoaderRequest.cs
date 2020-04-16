using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class AchievementsLoaderRequest : AchievementBaseRequest
    {
        public AchievementsLoaderRequest(string name, int id, Realm realm) : base(realm)
        {
            CharacterName = name;
            CategoryId = id;
        }

        [JsonProperty("n")]
        public string CharacterName { get; set; }

        [JsonProperty("c")]
        public int CategoryId { get; set; }
    }
}