using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public partial class BattlePet
    {
        [JsonProperty("battlepetdata")]
        public BattlePetData BattlePetData { get; set; }
    }
}