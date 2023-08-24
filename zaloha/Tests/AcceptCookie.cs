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

namespace LukanPOM.Tests
{
    public class AcceptCookie
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }
        [Test]
        public void TestCookie()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("http://lukan.cz");
            hp.AcceptCookie();


        }

    }
}