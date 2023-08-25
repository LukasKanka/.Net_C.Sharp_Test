using Xunit;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Google_Search_xUnit;

public class UnitTest1
{

    [Fact]
    public void Test1()

    { 
        
            // Otevře stránku google
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            
            // zamítne cookies google (odmítnout vše)
            IWebElement addButton = driver.FindElement(By.Id("W0wltc"));
            addButton.Click();
            
            // napíše slovo test do vyhledávání a potvrdí
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("test");
            searchBox.Submit();

            Thread.Sleep(3000);

            driver.Quit();
            
        }

    
}
