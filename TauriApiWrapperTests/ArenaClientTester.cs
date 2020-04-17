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
        [TestMethod]
        public void GetArenaLadder()
        {
            using (ArenaClient client = new ArenaClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ArenaLadder> returnData = client.GetArenaLadder(2, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaTeamInfo()
        {
            using (ArenaClient client = new ArenaClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ArenaTeamInfo> returnData = client.GetArenaTeamInfo(2, "teamname", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaTeamGameChart()
        {
            using (ArenaClient client = new ArenaClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ArenaTeamGameChart> returnData = client.GetArenaTeamGameChart(2, "teamname", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaTeamReportOpposingTeams()
        {
            using (ArenaClient client = new ArenaClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ArenaTeamReoprtOpposingTeams> returnData = client.GetArenaTeamReportOpposingTeams(2, "teamname", TauriApiWrapper.Enums.Realm.Evermoon);
                //Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetArenaGame()
        {
            using (ArenaClient client = new ArenaClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ArenaGame> returnData = client.GetArenaGame(6265170, TauriApiWrapper.Enums.Realm.Evermoon);
                //Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}

