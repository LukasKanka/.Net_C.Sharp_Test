using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitProject.Tests
{
    internal class RelativeLocatorsTests
    {
        [Test]
        public void FRelativelLocatorsTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            Assert.That(driver.Title, Is.EqualTo("Selenium"));

            // relativní locatory
            var knownXpath = "//h4[text()='Selenium IDE']";

            var rightOfSample = driver.FindElement(RelativeBy.WithLocator(By.TagName("h4")).RightOf(By.XPath(knownXpath))).Text;
            var leftOfSample = driver.FindElement(RelativeBy.WithLocator(By.TagName("h4")).LeftOf(By.XPath(knownXpath))).Text;
            var belowSample = driver.FindElement(RelativeBy.WithLocator(By.TagName("a")).Below(By.XPath(knownXpath))).Text;
            var aboveSample = driver.FindElement(RelativeBy.WithLocator(By.TagName("h2")).Above(By.XPath(knownXpath))).Text;

            var rh2webElement = driver.FindElement(RelativeBy.WithLocator(By.TagName("h2")).Above(By.XPath(knownXpath)));

            var chainSample = driver
                .FindElement(RelativeBy.WithLocator(By.TagName("h4"))
                .LeftOf(By.XPath(knownXpath))
                .Below(rh2webElement))
                .Text;

            var results = new List<string>()
            {
                "[heading] right 'Selenium IDE': " + rightOfSample,
                "[heading] left 'Selenium IDE': " + leftOfSample,
                "[link] below 'Selenium IDE': " + belowSample,
                "[heading] above 'Selenium IDE': " + aboveSample,
                "[heading] left of 'Selenium IDE' and below 'Getting Started':" + chainSample
        };
            File.WriteAllLines("results", results);

            driver.Quit();

        }
    }
}
