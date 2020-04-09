using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses;

namespace TauriApiWrapperTester
{
    [TestClass]
    public class TooltipClientTester
    {
        [TestMethod]
        public void GetItemById()
        {
            using (TooltipClient client = new TooltipClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ItemResponse> returnData = client.GetItemById(104633);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetItemByIds()
        {
            using (TooltipClient client = new TooltipClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                var returnData = client.GetItemsByIds(new List<int> { 104633, 42944 });
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}