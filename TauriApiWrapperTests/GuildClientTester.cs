using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class GuildClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetGuildRoster()
        {
            GuildClient client = new GuildClient(_credentials.ApiKey, _credentials.ApiSecret);
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
            GuildClient client = new GuildClient(_credentials.ApiKey, _credentials.ApiSecret);
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
            GuildClient client = new GuildClient(_credentials.ApiKey, _credentials.ApiSecret);
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
            GuildClient client = new GuildClient(_credentials.ApiKey, _credentials.ApiSecret);
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