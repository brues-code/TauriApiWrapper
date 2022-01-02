using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Achievement;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class AchievementClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetAchievementFirst()
        {
            AchievementClient client = new AchievementClient(_credentials.ApiKey, _credentials.ApiSecret);

            ApiResponse<AchievementFirst> returnData = client.GetAchievementFirsts(TauriApiWrapper.Enums.Realm.Evermoon);
            Assert.IsTrue(returnData.IsSuccess);
            Assert.IsNotNull(returnData.Response);
            Assert.IsTrue(returnData.Response.AchievementFirstArray.Count > 0);

        }

        [TestMethod]
        public void GetCharacterAchievements()
        {
            AchievementClient client = new AchievementClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<CharacterAchievements> returnData = client.GetCharacterAchievements("Rdzio", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetCharacterAchievementsLoader()
        {
            AchievementClient client = new AchievementClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<CharacterAchievementsLoader> returnData = client.GetCharacterAchievementsLoader("Rdzio", (int)TauriApiWrapper.Enums.AchievementCategory.Guild, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}