using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class AuctionHouseClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetBlackMarketAuctions()
        {
            using (BlackMarketClient client = new BlackMarketClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<BlackMarketResponse> data = client.GetBlackMarketAuctions(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
            }
        }

        [TestMethod]
        public void GetBlackMarketInfo()
        {
            using (BlackMarketClient client = new BlackMarketClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseInfoResponse> data = client.GetBlackMarketInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
            }
        }

        [TestMethod]
        public void GetAuctionHouseInfo()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseInfoResponse> data = client.GetAuctionHouseInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
            }
        }

        [TestMethod]
        public void GetAuctionsData()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAllAuctionsData(TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
            }
        }

        [TestMethod]
        public void GetAuctionItemPrice()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAuctionsByItemID(25707, TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
            }
        }
    }
}