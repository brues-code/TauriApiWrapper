using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class Socket
    {
        [JsonProperty("Color")]
        public int Color { get; set; }

        [JsonProperty("Content")]
        public int Content { get; set; }
    }
}