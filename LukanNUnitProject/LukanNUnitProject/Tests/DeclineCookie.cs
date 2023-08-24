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
    internal class DeclineCookie
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate()
                      .GoToUrl("https://lukan.cz"); 
            driver.Manage().Window.Maximize();
            Console.WriteLine("Author: Lukáš Kaňka");
        }

        [Test]
        public void ClickDeclineCookie()
        {
            // přijetí cookies
            IWebElement cookies = driver.FindElement(By.XPath("//div[3]/span"));
            cookies.Click();
        }

        [TearDown]
        public void EndTest()
        {
            
            driver.Close();
        }
    }
}
