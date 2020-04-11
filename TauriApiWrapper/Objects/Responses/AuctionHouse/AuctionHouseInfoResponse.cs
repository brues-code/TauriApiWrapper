using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public class AuctionHouseInfoResponse : BaseApiResponse
    {
        [JsonProperty("lastModified"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime LastModified { get; set; }
    }
}