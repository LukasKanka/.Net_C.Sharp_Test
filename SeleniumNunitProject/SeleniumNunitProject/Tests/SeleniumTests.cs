using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumNunitProject.Tests
{
    internal class SeleniumTests
    {
        [Test]

        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");

            // Zkontrolujeme název Titulku
            Assert.That(driver.Title, Is.EqualTo("Selenium"));

            driver.Quit();

        }
    }
}
