using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses
{
    public abstract class ItemResponseBase
    {
        [JsonProperty("isCata")]
        public bool IsCata { get; set; }

        [JsonProperty("expansion")]
        public long Expansion { get; set; }

        [JsonProperty("dataUrlPrefix")]
        public string DataUrlPrefix { get; set; }
    }
}