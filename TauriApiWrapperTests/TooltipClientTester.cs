using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class TooltipClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetItemById()
        {
            TooltipClient client = new TooltipClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<ItemResponse> returnData = client.GetItemById(99359);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }

        [TestMethod]
        public void GetItemByIds()
        {
            TooltipClient client = new TooltipClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                ApiResponse<List<ItemResponse>> returnData = client.GetItemsByIds(new List<int> { 104633, 42944 });
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }

        [TestMethod]
        public void GetItemByGuid()
        {
            TooltipClient client = new TooltipClient(_credentials.ApiKey, _credentials.ApiSecret);
            CharacterClient characterClient = new CharacterClient(_credentials.ApiKey, _credentials.ApiSecret);
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterSheet> itemData = characterClient.GetCharacterSheet("Cat", TauriApiWrapper.Enums.Realm.Evermoon);
                foreach (var item in itemData.Response.CharacterItems)
                {
                    ApiResponse<ItemResponse> returnData = client.GetItemByGuid(item.Guid.ToString());

                    Assert.IsNotNull(returnData.Response);
                    Assert.IsTrue(returnData.IsSuccess);

                }

            }
        }
    }
}