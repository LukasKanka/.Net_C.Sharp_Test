using LukanPOM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukanPOM.Tests
{
    [Parallelizable(ParallelScope.All)] // v mém případě zakomentovaným paraller test, test proběhl rychleji!
    internal class ParallelTest : TestBase
    {
        [Test]
        public void AcceptCookieTest()
        {
            Home.AcceptCookie();
        }

        [Test]
        public void DeclineCookieTest()
        {
            HomeTwo.DeclineCookie2();
        }
    }
}
