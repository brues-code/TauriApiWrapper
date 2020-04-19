using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class TooltipClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetItemById()
        {
            using (TooltipClient client = new TooltipClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<ItemResponse> returnData = client.GetItemById(99359);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }

        [TestMethod]
        public void GetItemByIds()
        {
            using (TooltipClient client = new TooltipClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<List<ItemResponse>> returnData = client.GetItemsByIds(new List<int> { 104633, 42944 });
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }
    }
}