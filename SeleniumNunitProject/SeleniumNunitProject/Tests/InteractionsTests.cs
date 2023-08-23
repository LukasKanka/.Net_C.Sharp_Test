using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

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
            Thread.Sleep(2000);

            // click radio button
            driver.FindElement(By.Id("my-radio-2")).Click();
            Thread.Sleep(2000);

            // right click
            var actions = new Actions(driver);
            var button = driver.FindElement(By.TagName("button"));
            actions.ContextClick(button).Perform();
            Thread.Sleep(2000);

            // double click
            var checkbox1 = driver.FindElement(By.Id("my-check-1"));
            actions.DoubleClick(checkbox1).Perform();
            Thread.Sleep(2000);

            // sendkeys input
            driver.FindElement(By.Id("my-text-id")).SendKeys(Guid.NewGuid().ToString());
            Thread.Sleep(2000);

            // text area
            var textArea = driver.FindElement(By.Name("my-textarea"));
            textArea.SendKeys(Guid.NewGuid().ToString());
            Thread.Sleep(2000);

            // clear
            textArea.Clear();
            Thread.Sleep(2000);

            // select Dropdown (select)
            // rozbalovací menu
            var selectElement = driver.FindElement(By.Name("my-select"));
            var select = new SelectElement(selectElement);

            select.SelectByText("One");
            select.SelectByValue("2");
            select.SelectByIndex(3);
            Thread.Sleep(2000);

            // upload
            var filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            File.WriteAllText(filePath, Guid.NewGuid().ToString());
            driver.FindElement(By.Name("my-file")).SendKeys(filePath);
            Thread.Sleep(2000);





            driver.Quit();

        }
    }
}
