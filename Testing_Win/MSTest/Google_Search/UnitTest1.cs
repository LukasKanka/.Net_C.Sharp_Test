using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Google_Search;

[TestClass]
public class UnitTest1
{
    public IWebDriver driver;

    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com");
        driver.Manage().Window.Maximize();
    }
    [TestMethod]
    public void TestMethod1()
    {
         IWebElement buttonOmne = driver.FindElement(By.Id("W0wltc"));
            buttonOmne.Click();

            Console.WriteLine("Dotestováno");

            Thread.Sleep(2000);

             

    }

    [TestCleanup]
    
        public void TearDown()
        {
            driver.Quit();
        }

    


}