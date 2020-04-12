using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class Auctions
    {
        [JsonProperty("auctioner_2")]
        public Auctioneer[] AllianceAuctions { get; set; }

        [JsonProperty("auctioner_6")]
        public Auctioneer[] HordeAuctions { get; set; }

        [JsonProperty("auctioner_7")]
        public Auctioneer[] BlackwaterAuctions { get; set; }
    }
}