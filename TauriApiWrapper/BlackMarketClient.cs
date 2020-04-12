using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapper
{
    public class BlackMarketClient : TauriClient
    {
        private class Endpoints
        {
            public const string AuctionsData = "bmauctions-data";
            public const string AuctionsInfo = "bmauctions-info";
        }

        public BlackMarketClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        #region Sync

        public ApiResponse<BlackMarketResponse> GetBlackMarketAuctions(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new AuctionHouseBaseRequest(realm));
            return Communicate<BlackMarketResponse>(param);
        }

        public ApiResponse<AuctionHouseInfoResponse> GetBlackMarketInfo(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new AuctionHouseBaseRequest(realm));
            return Communicate<AuctionHouseInfoResponse>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<BlackMarketResponse>> GetBlackMarketAuctionsAsync(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new AuctionHouseBaseRequest(realm));
            return await CommunicateAsync<BlackMarketResponse>(param);
        }

        public async Task<ApiResponse<AuctionHouseInfoResponse>> GetBlackMarketInfoAsync(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new AuctionHouseBaseRequest(realm));
            return await CommunicateAsync<AuctionHouseInfoResponse>(param);
        }

        #endregion Async
    }
}