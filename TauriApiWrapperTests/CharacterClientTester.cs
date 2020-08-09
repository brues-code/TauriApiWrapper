using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class CharacterClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetCharacterTooltipByName()
        {
            using (CharacterClient c = new CharacterClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterData> data = c.GetCharacterTooltipByName("Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
            }
        }

        [TestMethod]
        public void GetCharacterSheetByName()
        {
            using (CharacterClient c = new CharacterClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterSheet> data = c.GetCharacterSheet("Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
                Assert.IsNotNull(data.Response.CharacterItems);
            }
        }

        [TestMethod]
        public void GetCharacterTalentsByName()
        {
            using (CharacterClient c = new CharacterClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterTalents> data = c.GetCharacterTalents("Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
            }
        }
    }
}