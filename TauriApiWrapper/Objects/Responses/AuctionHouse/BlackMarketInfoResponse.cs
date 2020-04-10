using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public class BlackMarketInfoResponse : BaseApiResponse
    {
        [JsonProperty("lastModified"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime LastModified { get; set; }
    }
}