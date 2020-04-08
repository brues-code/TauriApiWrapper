using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapperTester
{
    internal class TestingCredentials
    {
#if DEBUG
        public const string ApiKey = "e26c8d840d406f0004badcf70f207a23";
        public const string Secret = "fcf1b92f000c99d61685f9629a4645218e746083";
#endif
    }
}