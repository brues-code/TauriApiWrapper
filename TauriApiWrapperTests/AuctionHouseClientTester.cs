using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class AuctionHouseClientTester
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
                ApiResponse<AuctionHouseInfoResponse> data = client.GetBlackMarketInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.LastModified > DateTime.MinValue);
            }
        }

        [TestMethod]
        public void GetAuctionHouseInfo()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<AuctionHouseInfoResponse> data = client.GetAuctionHouseInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.LastModified > DateTime.MinValue);
            }
        }

        [TestMethod]
        public void GetAuctionsData()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAllAuctionsData(TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.LastModified > DateTime.MinValue);
                Assert.IsTrue(data.Response.Auctions != null);
            }
        }

        [TestMethod]
        public void GetAuctionItemPrice()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAuctionsByItemID(25707, TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.LastModified > DateTime.MinValue);
                Assert.IsTrue(data.Response.Auctions != null);
            }
        }
    }
}