using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class AuctionHouseResponse : AuctionHouseInfoResponse
    {
        [JsonProperty("auctions")]
        public Auctions Auctions { get; set; }
    }
}