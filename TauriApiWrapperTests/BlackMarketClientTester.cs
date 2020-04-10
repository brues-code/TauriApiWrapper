using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class BlackMarketClientTester
    {
        [TestMethod]
        public void GetBlackMarketAuctions()
        {
            using (BlackMarketClient client = new BlackMarketClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<BlackMarketResponse> data = client.GetBlackMarketAuctions(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.Auctions.Count > 0);
            }
        }

        [TestMethod]
        public void GetBlackMarketInfo()
        {
            using (BlackMarketClient client = new BlackMarketClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<BlackMarketInfoResponse> data = client.GetBlackMarketInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.LastModified > DateTime.MinValue);
            }
        }
    }
}