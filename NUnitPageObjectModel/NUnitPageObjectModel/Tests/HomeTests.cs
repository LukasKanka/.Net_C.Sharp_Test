using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using NUnitPageObjectModel.Source.Pages;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;



namespace NUnitPageObjectModel.Tests
{
    public class HomeTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [Test]
        public void SearchBook()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("http://amazon.com");
            hp.Search("webdriver book");
            Assert.True(_driver.Title.Contains("webdriver book"));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}