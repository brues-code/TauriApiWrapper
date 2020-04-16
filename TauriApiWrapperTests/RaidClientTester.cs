using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Raid;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class RaidClientTester
    {
        [TestMethod]
        public void GetRaidMapsInfo()
        {
            using (RaidClient client = new RaidClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<RaidMaps> returnData = client.GetRaidMaps();
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsTrue(returnData.Response.ClassicRaids.Length > 0);
                Assert.IsTrue(returnData.Response.BurningCrusadeRaids.Length > 0);
                Assert.IsTrue(returnData.Response.WrathOfTheLichKingRaids.Length > 0);
                Assert.IsTrue(returnData.Response.CataclysmRaids.Length > 0);
                Assert.IsTrue(returnData.Response.MistsOfPandariaRaids.Length > 0);
            }
        }

        [TestMethod]
        public void GetLatestRaidsInfo()
        {
            using (RaidClient client = new RaidClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetLatestRaids(limit: 5);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogInfo()
        {
            using (RaidClient client = new RaidClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetLatestRaids(limit: 5);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);

                ApiResponse<RaidLog> raidlog = client.GetRaidLogFromId(returnData.Response.Logs[0].LogId);
                Assert.IsTrue(raidlog.IsSuccess);
                Assert.IsNotNull(raidlog.Response);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogByPlayerName()
        {
            using (RaidClient client = new RaidClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetRaidLogFromPlayerName("Cat", realm: TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}