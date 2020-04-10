using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapper
{
    public class BlackMarketClient : TauriClient
    {
        private const string _dataUrl = "bmauctions-data";
        private const string _infoUrl = "bmauctions-info";

        public BlackMarketClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<BlackMarketResponse> GetBlackMarketAuctions(Realm realm)
        {
            ApiParams param = new ApiParams(_dataUrl, Secret, new BlackMarketRequest(realm));
            return Communicate<BlackMarketResponse>(param);
        }

        public ApiResponse<BlackMarketInfoResponse> GetBlackMarketInfo(Realm realm)
        {
            ApiParams param = new ApiParams(_infoUrl, Secret, new BlackMarketRequest(realm));
            return Communicate<BlackMarketInfoResponse>(param);
        }
    }
}