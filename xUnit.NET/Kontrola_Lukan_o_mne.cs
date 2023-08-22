using Xunit;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace xUnit.NET
{
    public class UnitTest1
    {
        String test_url = "https://lukan.cz/";
        String itemName = "Lukáš Bloguje";

        [Fact]
        public void Test1()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();

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

            // zavře prohlížeč
            driver.Quit();

        }
    }
}
