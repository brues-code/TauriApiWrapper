using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class GuildClientTester
    {
        [TestMethod]
        public void GetGuildRoster()
        {
            using (GuildClient client = new GuildClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<GuildRoster> returnData = client.GetGuildRoster("Muzykanci z Gruzji");
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildList.Count > 0);
            }
        }

        [TestMethod]
        public void GetGuildStats()
        {
            using (GuildClient client = new GuildClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<GuildStats> returnData = client.GetGuildStats("Muzykanci z Gruzji");
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildList.Count > 0);
            }
        }

        [TestMethod]
        public void GetGuildBankContent()
        {
            using (GuildClient client = new GuildClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<GuildBankContent> returnData = client.GetGuildBankContents("Muzykanci z Gruzji");
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildBankItemList.Count > 0);
            }
        }

        [TestMethod]
        public void GetGuildLogs()
        {
            using (GuildClient client = new GuildClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<GuildBankLog> returnData = client.GetGuildBankLogs("Muzykanci z Gruzji");
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildBankItemList.Count > 0);
                Assert.IsTrue(returnData.Response.GuildBankTabs.Count > 0);
                Assert.IsTrue(!string.IsNullOrEmpty(returnData.Response.GuildName));
            }
        }
    }
}