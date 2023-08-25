using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Net;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using LukanPOM.PageObjects;
using LukanPOM.Common;

namespace LukanPOM.Tests

    {
    
        
        internal class TitleTest : TestBase
        {
            [Test]
        public void TitleVerifiTest()
        {
             Home
            .Titulek()
            .TestProsel();
        }
        }
    }