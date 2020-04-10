using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class CharacterClientTester
    {
        [TestMethod]
        public void GetCharacterTooltipByName()
        {
            using (CharacterClient c = new CharacterClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterResponse> data = c.GetCharacterTooltipByName("Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
            }
        }

        [TestMethod]
        public void GetCharacterSheetByName()
        {
            using (CharacterClient c = new CharacterClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterSheetResponse> data = c.GetCharacterSheet("Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
            }
        }
    }
}