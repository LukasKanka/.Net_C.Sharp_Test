using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LukanNUnitProject.Tests
{
    internal class AcceptCookie
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate()
                      .GoToUrl("https://lukan.cz");
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Console.WriteLine("Author: Lukáš Kaňka");
        }

        [Test]
        public void ClickAcceptCookie()
        {
            // přijetí cookies
            IWebElement cookies = driver.FindElement(By.XPath("//div[2]/span"));
            cookies.Click();
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
