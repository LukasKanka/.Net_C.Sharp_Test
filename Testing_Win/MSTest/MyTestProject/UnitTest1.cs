using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private String test_url = "https://lukan.cz/";
        private String itemName = "Lukáš Bloguje";
        

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            Console.WriteLine("Author: Lukáš Kaňka");

            // Kontrola titulku
            string expectedTitle = "Lukáš bloguje - Blog o všem možném i nemožném";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");

            // Clikne na tlačítko 
            IWebElement buttonOmne = driver.FindElement(By.Id("menu-item-79"));
            buttonOmne.Click();

            // Kontrola titulku
            expectedTitle = "O mně - Lukáš bloguje";
            actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");

            // Vrátí žpět na hlavní stranu
            IWebElement buttonHlavniStrana = driver.FindElement(By.Id("menu-item-75"));
            buttonHlavniStrana.Click();

            // Počká tři sekundy na další akci 
            Thread.Sleep(3000);

            Console.Write("Dotestováno");

            // zavře prohlížeč 
            driver.Quit();
        }
    }
}
