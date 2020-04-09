using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects.Responses
{
    public class BlackMarketInfoResponse : BaseApiResponse
    {
        [JsonProperty("lastModified")]
        private double _lastModified;

        public DateTime LastModified => _lastModified.FromUnixTimeStamp();
    }
}