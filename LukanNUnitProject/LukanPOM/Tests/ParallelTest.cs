using LukanPOM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukanPOM.Tests
{
    //[Parallelizable(ParallelScope.All)]
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
