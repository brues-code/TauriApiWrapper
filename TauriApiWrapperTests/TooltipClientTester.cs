using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class TooltipClientTester
    {
        [TestMethod]
        public void GetItemById()
        {
            using (TooltipClient client = new TooltipClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<ItemResponse> returnData = client.GetItemById(99359);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }

        [TestMethod]
        public void GetItemByIds()
        {
            using (TooltipClient client = new TooltipClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<List<ItemResponse>> returnData = client.GetItemsByIds(new List<int> { 104633, 42944 });
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }
    }
}