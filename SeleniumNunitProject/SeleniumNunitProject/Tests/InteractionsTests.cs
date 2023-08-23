using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumNunitProject.Tests
{
    internal class InteractionsTests
    {
        [Test]
        public void InteractionsTest()
        {
            var results = new List<string>();
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

            // click  default checkbox
            driver.FindElement(By.Id("my-check-2")).Click();

            // click radio button
            driver.FindElement(By.Id("my-radio-2")).Click();

            // right click
            var actions = new Actions(driver);
            var button = driver.FindElement(By.TagName("button"));
            actions.ContextClick(button).Perform();

            // double click
            var checkbox1 = driver.FindElement(By.Id("my-check-1"));
            actions.DoubleClick(checkbox1).Perform();

            // sendkeys input
            driver.FindElement(By.Id("my-text-id")).SendKeys(Guid.NewGuid().ToString());

            // text area
            var textArea = driver.FindElement(By.Name("my-textarea"));
            textArea.SendKeys(Guid.NewGuid().ToString());

            // clear
            //textArea.Clear();



           //driver.Quit();

        }
    }
}
