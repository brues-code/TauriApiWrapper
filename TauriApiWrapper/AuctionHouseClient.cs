using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapper
{
    public class AuctionHouseClient : TauriClient
    {
        private class Endpoints
        {
            public const string AuctionsInfo = "auctions-info";
            public const string AuctionsData = "auctions-data";
            public const string AuctionItemData = "auctions-item-prices";
        }

        public AuctionHouseClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<AuctionHouseInfoResponse> GetAuctionHouseInfo(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new AuctionHouseBaseRequest(realm));
            return Communicate<AuctionHouseInfoResponse>(param);
        }

        public ApiResponse<AuctionHouseResponse> GetAllAuctionsData(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new AuctionHouseBaseRequest(realm));
            return Communicate<AuctionHouseResponse>(param);
        }

        public ApiResponse<AuctionHouseResponse> GetAuctionsByItemID(int itemID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionItemData, Secret, new AuctionHouseItemPriceRequest(itemID, realm));
            return Communicate<AuctionHouseResponse>(param);
        }
    }
}