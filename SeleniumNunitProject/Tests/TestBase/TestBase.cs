using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects.PageObjects;

namespace Tests.Common
{
    internal class TestBase
    {
        public WebFormPage WebForm { get; private set; }
        protected IWebDriver Driver { get; private set; }
       

        [SetUp]
        public void Setup()
        {
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            WebForm = new WebFormPage(Driver);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
