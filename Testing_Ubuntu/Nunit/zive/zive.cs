using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Threading;

namespace zive;

public class Tests
{
    IWebDriver driver = new ChromeDriver();

    [SetUp]
    public void Setup()
    {
        driver.Navigate()
                  .GoToUrl("https://zive.cz");       
            //Maximalizuje prohlížeč 
            driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {
        // odsouhlasení pravidel
        IWebElement cookies = driver.FindElement(By.XPath("//button[@id='didomi-notice-agree-button']/span"));
            cookies.Click();

            Thread.Sleep(1000);

            //Klikne na menu
            IWebElement menu = driver.FindElement(By.XPath("//a[contains(text(),'Menu')]"));
            menu.Click();
            
             Thread.Sleep(1000);

             //vrátí se na hlavní stranu 
             IWebElement zive = driver.FindElement(By.XPath("/html/body/form/nav/div/div[1]/a[1]"));  
            zive.Click();

            Thread.Sleep(1000);

            //klikne na hledat
            IWebElement lupa = driver.FindElement(By.XPath("//a[@onclick='layout.menu.toggle(true)']"));  
            lupa.Click();

             Thread.Sleep(1000);
             
              // klikne na test a do vyhledávacího pole zadá test
             IWebElement searchBox = driver.FindElement(By.XPath("/html/body/form/nav/div/div[1]/div/input"));
            searchBox.SendKeys("test");
            //searchBox.Submit();

             Thread.Sleep(1000);

             //klikne na hledat
            IWebElement lupa1 = driver.FindElement(By.XPath("//a[@onclick='layout.search.run()']"));  
            lupa1.Click();

            Thread.Sleep(1000);

            //vrátí se na hlavní stranu 
            // IWebElement zive1 = driver.FindElement(By.XPath("/html/body/form/nav/div/div[1]/a[1]"));  
            //zive1.Click();
            
             Thread.Sleep(3000);

            Console.Write("Test prošel");
           
              }
    
    [TearDown]
        public void EndTest()
        {
            //zavře prohližeč 
            driver.Close();
        }
}