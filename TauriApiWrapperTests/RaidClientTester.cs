using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Raid;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class RaidClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetRaidMapsInfo()
        {
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
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
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetLatestRaids(limit: 5);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogInfo()
        {
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetLatestRaids(limit: 5);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);

                ApiResponse<RaidLog> raidlog = client.GetRaidLogFromId(returnData.Response.Logs[0].LogId);
                Assert.IsTrue(raidlog.IsSuccess);
                Assert.IsNotNull(raidlog.Response);
                Assert.IsNotNull(raidlog.Response.Encounter);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogByPlayerName()
        {
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetRaidLogFromPlayerName("Cat", realm: TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetRaidLogFromGuildName()
        {
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<RaidLogsResponse> returnData = client.GetRaidLogFromGuildName("Muzykanci z Gruzji", realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetRaidEncounterRanking()
        {
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<RaidEncounterRankingResponse> returnData = client.GetRaidEncounterRanking(1623, 5, realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetRaidGuildEncounterRanking()
        {
            using (RaidClient client = new RaidClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<RaidEncounterRankingResponse> returnData = client.GetRaidGuildEncounterRanking(1623, 5, realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }
    }
}