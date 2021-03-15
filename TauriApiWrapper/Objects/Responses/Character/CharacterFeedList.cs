using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterFeedList
    {
        [JsonProperty("characterFeed")]
        public CharacterFeed[] Events { get; set; }
    }
}
