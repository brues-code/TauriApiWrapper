using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses
{
    public class BlackMarketResponse : BaseApiResponse
    {
        [JsonProperty("auctions")]
        public List<ItemResponse> Auctions { get; set; }
    }
}