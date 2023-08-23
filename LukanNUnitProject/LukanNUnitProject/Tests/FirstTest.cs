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
    internal class FirstTest
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
        public void Test1()
        {
            // přijetí cookies
            IWebElement cookies = driver.FindElement(By.XPath("//div[2]/span"));
            cookies.Click();
            // odmitnuti xpath=//div[3]/span


            //zkontroluje nadpis webu
            string actualTitle = driver.Title;
            string expectedTitle = "Lukáš bloguje - Blog o všem možném i nemožném";
            Assert.AreEqual(expectedTitle, actualTitle);

            //  přejde na Zásady ochrany osobních údajů
            IWebElement zasady = driver.FindElement(By.Id("menu-item-439"));
            zasady.Click();

             
             // vytvoření screenshotu (blbne s GitHub Actions)
             string fileName = "example_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
             Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
             screenshot.SaveAsFile(@"C:\Users\lukas\Nextcloud\GitHub\.Net_C.Sharp_Test\LukanNUnitProject\LukanNUnitProject\Foto\" + fileName, ScreenshotImageFormat.Png);
            
            Thread.Sleep(3000);

            Console.Write("Test prošel");

        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
