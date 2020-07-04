using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapper
{
    public sealed class BlackMarketClient : TauriClient
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
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<BlackMarketResponse>() { ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new AuctionHouseBaseRequest(realm));
            return Communicate<BlackMarketResponse>(param);
        }

        public ApiResponse<AuctionHouseInfoResponse> GetBlackMarketInfo(Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<AuctionHouseInfoResponse>() { ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new AuctionHouseBaseRequest(realm));
            return Communicate<AuctionHouseInfoResponse>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<BlackMarketResponse>> GetBlackMarketAuctionsAsync(Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<BlackMarketResponse>() { ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new AuctionHouseBaseRequest(realm));
            return await CommunicateAsync<BlackMarketResponse>(param);
        }

        public async Task<ApiResponse<AuctionHouseInfoResponse>> GetBlackMarketInfoAsync(Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<AuctionHouseInfoResponse>() { ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new AuctionHouseBaseRequest(realm));
            return await CommunicateAsync<AuctionHouseInfoResponse>(param);
        }

        #endregion Async
    }
}