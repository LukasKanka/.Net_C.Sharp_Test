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

        //  přejde na O_mne
         IWebElement o_mne = driver.FindElement(By.Id(""));
            o_mne.Click();

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