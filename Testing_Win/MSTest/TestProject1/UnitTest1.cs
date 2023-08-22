using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;





namespace TestProject2

{

    [TestClass]

    public class UnitTest1

    {

        String test_url = "https://lukan.cz/";



        String itemName = "Lukáš Bloguje";



        [TestMethod]

        public void TestMethod1()

        {

            IWebDriver driver;



            // Local Selenium WebDriver 



            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(test_url);

            driver.Manage().Window.Maximize();


            // Kontrola titulku
            string expectedTitle = "Lukáš bloguje - Blog o všem možném i nemožném";

            string actualTitle = driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");




            // Clikne na tlačítko 

            IWebElement addButton = driver.FindElement(By.Id("menu-item-79"));

            addButton.Click();

            // Kontrola titulku
            expectedTitle = "O mně - Lukáš bloguje";

            actualTitle = driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");



            // Počká tři sekundy na další akci 

            Thread.Sleep(3000);



            Console.Write("Dotestováno");



            // zavře prohlížeč 

            driver.Quit();

        }

    }

}