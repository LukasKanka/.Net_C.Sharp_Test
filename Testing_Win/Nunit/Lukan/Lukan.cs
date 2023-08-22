using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Threading;

namespace Lukan;

public class Tests
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

           /* 
            // vytvoření screenshotu (blbne s GitHub Actions)
            string fileName = "example_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@"c:\Testing.Net\GitHub\Testing\Nunit\Lukan\Foto\" + fileName, ScreenshotImageFormat.Png);
           */
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