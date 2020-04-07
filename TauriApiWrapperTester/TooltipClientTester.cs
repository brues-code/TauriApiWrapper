using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;

namespace TauriApiWrapperTester
{
    [TestClass]
    public class TooltipClientTester
    {
        [TestMethod]
        public void GetItemById()
        {
            using TooltipClient client = new TooltipClient("e26c8d840d406f0004badcf70f207a23", "fcf1b92f000c99d61685f9629a4645218e746083");
            var returnData = client.GetItemById(104633);

            Assert.IsNotNull(returnData.Response);
        }
    }
}