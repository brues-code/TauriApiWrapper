using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses;
using TauriApiWrapper.Objects.Responses.Arena;

namespace TauriApiWrapperTests
{
    /*
     *
     *  NYI in Tauri API
     *
     */

    [TestClass]
    public class ArenaClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetArenaLadder()
        {
            ArenaClient client = new ArenaClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<ArenaLadder> returnData = client.GetArenaLadder(2, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(!returnData.IsSuccess && returnData.CustomError.HasValue);
                if (returnData.IsSuccess)
                    Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaTeamInfo()
        {
            ArenaClient client = new ArenaClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<ArenaTeamInfo> returnData = client.GetArenaTeamInfo((int)TauriApiWrapper.Enums.TeamType._2v2, "teamname", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(!returnData.IsSuccess && returnData.CustomError.HasValue);
                if (returnData.IsSuccess)
                    Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaTeamGameChart()
        {
            ArenaClient client = new ArenaClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<ArenaTeamGameChart> returnData = client.GetArenaTeamGameChart((int)TauriApiWrapper.Enums.TeamType._2v2, "teamname", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(!returnData.IsSuccess && returnData.CustomError.HasValue);
                if (returnData.IsSuccess)
                    Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaTeamReportOpposingTeams()
        {
            ArenaClient client = new ArenaClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<ArenaTeamReportOpposingTeams> returnData = client.GetArenaTeamReportOpposingTeams((int)TauriApiWrapper.Enums.TeamType._2v2, "teamname", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(!returnData.IsSuccess && returnData.CustomError.HasValue);
                if (returnData.IsSuccess)
                    Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaGame()
        {
            ArenaClient client = new ArenaClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<ArenaGame> returnData = client.GetArenaGame(6265170, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(!returnData.IsSuccess && returnData.CustomError.HasValue);
                if (returnData.IsSuccess)
                    Assert.IsNotNull(returnData.Response);
            }
        }
    }
}