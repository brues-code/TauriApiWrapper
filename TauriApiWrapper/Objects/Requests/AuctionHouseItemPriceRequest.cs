using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public sealed class AuctionHouseItemPriceRequest : AuctionHouseBaseRequest
    {
        [JsonProperty("item")]
        public int ItemID { get; set; }

        public AuctionHouseItemPriceRequest(int itemID, Realm realm) : base(realm)
        {
            ItemID = itemID;
        }
    }
}