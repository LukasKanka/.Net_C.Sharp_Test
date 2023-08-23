using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumNunitProject.Tests
{
    internal class WaitsTests
    {
        [Test]
        public void ImplicitWaitTest()
        {
           
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            // čeká 10 sekund než provede další krok
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var textArea = driver.FindElement(By.Name("my-textarea"));
            textArea.SendKeys(Guid.NewGuid().ToString());

            driver.Quit();

        }
        [Test]
        public void ExplicitWaitTest()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            
            // čas jak browser počká než bude splněn určitý úkon
            // druhý řádek definovaná podmínka
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var condition1 = wait.Until(e => e.Title == "Web form");
            var condition2 = wait.Until(e => e.FindElement(By.Name("my-textarea")));
            var condition3 = wait.Until(e => e.FindElement(By.Name("my-textarea")).Displayed);

            var textArea = driver.FindElement(By.Name("my-textarea"));
            textArea.SendKeys(Guid.NewGuid().ToString());

            driver.Quit();

        }
        [Test]
        public void FluenttWaitTest()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

            // po dobu 10 sekund každou sekundu kontrolujeme jestli je podmínka splněna
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromSeconds(1)
            };
            // vyjímka
            wait.IgnoreExceptionTypes(typeof(HttpRequestException));

            var condition = wait.Until(e => e.Title == "Web form");


            var textArea = driver.FindElement(By.Name("my-textarea"));
            textArea.SendKeys(Guid.NewGuid().ToString());

            driver.Quit();
        }
}
