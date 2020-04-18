using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Challenge;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class ChallengeModeTester
    {
        [TestMethod]
        public void GetChallengeIndex()
        {
            using (ChallengeModeClient client = new ChallengeModeClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ChallengeIndex> returnData = client.GetChallengeIndex(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetChallengeLeaderboard()
        {
            using (ChallengeModeClient client = new ChallengeModeClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ChallengeLeaderboard> returnData = client.GetChallengeLeaderboard((int)TauriApiWrapper.Enums.ChallengeMap.TempleOfTheJadeSerpent, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}