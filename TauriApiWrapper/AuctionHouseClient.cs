using System.Threading.Tasks;
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

        #region Sync

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

        #endregion Sync

        #region Async

        public async Task<ApiResponse<AuctionHouseInfoResponse>> GetAuctionHouseInfoAsync(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new AuctionHouseBaseRequest(realm));
            return await CommunicateAsync<AuctionHouseInfoResponse>(param);
        }

        public async Task<ApiResponse<AuctionHouseResponse>> GetAllAuctionsDataAsync(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new AuctionHouseBaseRequest(realm));
            return await CommunicateAsync<AuctionHouseResponse>(param);
        }

        public async Task<ApiResponse<AuctionHouseResponse>> GetAuctionsByItemIDAsync(int itemID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionItemData, Secret, new AuctionHouseItemPriceRequest(itemID, realm));
            return await CommunicateAsync<AuctionHouseResponse>(param);
        }

        #endregion Async
    }
}