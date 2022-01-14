using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            ApiResponse<RaidMaps> returnData = RaidClient.GetRaidMaps(client);
            Assert.IsNotNull(returnData.Response);
            Assert.IsTrue(returnData.IsSuccess);
            Assert.IsTrue(returnData.Response.ClassicRaids.Length > 0);
            Assert.IsTrue(returnData.Response.BurningCrusadeRaids.Length > 0);
            Assert.IsTrue(returnData.Response.WrathOfTheLichKingRaids.Length > 0);
            Assert.IsTrue(returnData.Response.CataclysmRaids.Length > 0);
            Assert.IsTrue(returnData.Response.MistsOfPandariaRaids.Length > 0);
        }

        [TestMethod]
        public void GetLatestRaidsInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidLogsResponse> returnData = RaidClient.GetLatestRaids(client, limit: 5);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidLogsResponse> returnData = RaidClient.GetLatestRaids(client, limit: 5);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);

                ApiResponse<RaidLog> raidlog = RaidClient.GetRaidLogFromID(client, returnData.Response.Logs[0].LogID);
                Assert.IsTrue(raidlog.IsSuccess);
                Assert.IsNotNull(raidlog.Response);
                Assert.IsNotNull(raidlog.Response.Encounter);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogByPlayerName()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidLogsResponse> returnData = RaidClient.GetRaidLogFromPlayerName(client, "Cat", realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetRaidLogFromGuildName()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidLogsResponse> returnData = RaidClient.GetRaidLogFromGuildName(client, "Muzykanci z Gruzji", realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetRaidEncounterRanking()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidEncounterRankingResponse> returnData = RaidClient.GetRaidEncounterRanking(client, 1623, 5, realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetRaidGuildEncounterRanking()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidEncounterRankingResponse> returnData = RaidClient.GetRaidGuildEncounterRanking(client, 1623, 5, realm: TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }
    }
}