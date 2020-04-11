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
            public const string AuctionsData = "item-tooltip";
            public const string AuctionsInfo = "item-tooltip";
        }

        public BlackMarketClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<BlackMarketResponse> GetBlackMarketAuctions(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, Secret, new BlackMarketRequest(realm));
            return Communicate<BlackMarketResponse>(param);
        }

        public ApiResponse<BlackMarketInfoResponse> GetBlackMarketInfo(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, Secret, new BlackMarketRequest(realm));
            return Communicate<BlackMarketInfoResponse>(param);
        }
    }
}