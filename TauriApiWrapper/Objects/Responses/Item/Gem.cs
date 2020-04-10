using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class Gem
    {
        [JsonProperty("enchantid")]
        public int Enchantid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("gemcolor")]
        public int Gemcolor { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}