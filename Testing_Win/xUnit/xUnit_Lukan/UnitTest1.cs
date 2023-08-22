
using Xunit;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit.Abstractions;
using Xunit.Sdk;




namespace xUnit.NET
{
    
    
    public class UnitTest1
    {
        String test_url = "https://lukan.cz/";
        String itemName = "Lukáš Bloguje";

       
        [Fact]
        public void Test1()
        {
           /*
            Logger.Info("Running test MyTest");
            logger.Info("Test method 1 started");
            logger.Info("Test method 1 completed");
           */


            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();

            Console.Write("Začátek testu");

            // Zkkontroluje nadpis webu
            Assert.Equal("Lukáš bloguje - Blog o všem možném i nemožném", driver.Title);

            // Clikne na tlačítko
            IWebElement addButton = driver.FindElement(By.Id("menu-item-79"));
            addButton.Click();

            Assert.Equal("O mně - Lukáš bloguje", driver.Title);

             Thread.Sleep(1000);
            
            // vrátí mě na hlavní stránku
            IWebElement hlavniButton = driver.FindElement(By.Id("menu-item-75"));

            // Počká tři sekundy na další akci
            Thread.Sleep(3000); 

            Console.Write("Dotestováno");
            
             driver.Quit();

             

        }
    }
    
}