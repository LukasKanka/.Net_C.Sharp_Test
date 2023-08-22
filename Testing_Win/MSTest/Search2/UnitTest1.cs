using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

[TestClass]
public class TestGoogleSearch
{
    private IWebDriver driver;

    [TestInitialize]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.google.com/");

        // potvrzení přijetí všech požadavků
        IAlert alert = driver.SwitchTo().Alert();
        alert.Accept();
    }

    [TestMethod]
    public void TestSearch()
    {
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("test");
        searchInput.Submit();

        Assert.AreEqual(driver.Url, "https://www.google.com/search?q=test");
    }

    [TestCleanup]
    public void TearDown()
    {
        driver.Quit();
    }
}
