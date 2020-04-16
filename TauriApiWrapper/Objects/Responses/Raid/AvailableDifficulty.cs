using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class AvailableDifficulty
    {
        [JsonProperty("id")]
        public int ID { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }
    }
}