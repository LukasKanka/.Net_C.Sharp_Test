using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace zive;

[TestClass]
public class UnitTest1
{
     public IWebDriver driver;

     [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.zive.cz");
        driver.Manage().Window.Maximize();
        Console.WriteLine("Author: Lukáš Kaňka");
    }

    [TestMethod]
    public void TestMethod1()
    {
        // odsouhlasení pravidel
        IWebElement cookies = driver.FindElement(By.XPath("//button[@id='didomi-notice-agree-button']/span"));
            cookies.Click();

            //zkontroluje nadpis webu
            string actualTitle = driver.Title;
            string expectedTitle = "Živě.cz – O počítačích, internetu, vědě a technice";
            Assert.AreEqual(expectedTitle, actualTitle);

            //Klikne na menu
            IWebElement menu = driver.FindElement(By.XPath("//a[contains(text(),'Menu')]"));
            menu.Click();
            

             //vrátí se na hlavní stranu 
             IWebElement zive = driver.FindElement(By.XPath("/html/body/form/nav/div/div[1]/a[1]"));  
            zive.Click();

        Thread.Sleep(1000);

        //klikne na hledat
        IWebElement lupa = driver.FindElement(By.XPath("//a[@onclick='layout.menu.toggle(true)']"));  
            lupa.Click();
             
              // klikne na test a do vyhledávacího pole zadá test
             IWebElement searchBox = driver.FindElement(By.XPath("/html/body/form/nav/div/div[1]/div/input"));
            searchBox.SendKeys("test");
            //searchBox.Submit();

             //klikne na hledat
            IWebElement lupa1 = driver.FindElement(By.XPath("//a[@onclick='layout.search.run()']"));  
            lupa1.Click();

            //vrátí se na hlavní stranu 
             IWebElement zive1 = driver.FindElement(By.XPath("(//a[contains(@href, '/')])[131]"));  
            zive1.Click();

             Thread.Sleep(2000);

            // výstup zobrazí pouze v Visual Studio a ne VS Code
            Console.WriteLine("Test prošel");

    }

     [TestCleanup]
    
        public void TearDown()
        {
            driver.Quit();
        }
}