using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class CharacterClientTester
    {
        [TestMethod]
        public void GetCharacterByName()
        {
            using (CharacterClient c = new CharacterClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                var data = c.GetCharacterByName("Querý", TauriApiWrapper.Enums.Realm.Evermoon);
            }
        }
    }
}