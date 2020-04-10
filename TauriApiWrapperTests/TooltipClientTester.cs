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
                Assert.IsTrue(returnData.Response.ID > 0);
            }
        }

        [TestMethod]
        public void GetItemByIds()
        {
            using (TooltipClient client = new TooltipClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<List<ItemResponse>> returnData = client.GetItemsByIds(new List<int> { 104633, 42944 });
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.Any(x => x.ID > 0));
            }
        }

        [TestMethod]
        public void GetItemByGuid()
        {
            using (TooltipClient client = new TooltipClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                //This will fail. need to get an actual GUID from the API First...
                ApiResponse<ItemResponse> returnData = client.GetItemByGuid(Guid.Empty.ToString());
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.ID > 0);
            }
        }
    }
}