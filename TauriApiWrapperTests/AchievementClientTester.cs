using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Achievement;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class AchievementClientTester
    {
        [TestMethod]
        public void GetAchievementFrist()
        {
            using (AchievementClient client = new AchievementClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<AchievementFirst> returnData = client.GetAchievementFirsts(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.AchievementFirstArray.Count > 0);
            }
        }

        [TestMethod]
        public void GetCharacterAchievements()
        {
            using (AchievementClient client = new AchievementClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<CharacterAchievements> returnData = client.GetCharacterAchievements("Rdzio", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetCharacterAchievementsLoader()
        {
            using (AchievementClient client = new AchievementClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<CharacterAchievementsLoader> returnData = client.GetCharacterAchievementsLoader("Rdzio", 97, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}