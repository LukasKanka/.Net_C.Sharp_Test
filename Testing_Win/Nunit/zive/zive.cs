using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Threading;

namespace zive;

public class Test
{
    IWebDriver driver = new ChromeDriver();

    [SetUp]
    public void Setup()
    {    
        //Odkaz na testovaný web
        driver.Navigate()
                  .GoToUrl("https://zive.cz");       
            //Maximalizuje prohlížeč 
            driver.Manage().Window.Maximize();
            //Přidá autora testu do logu
            Console.WriteLine("Author: Lukáš Kaňka");
        }

    [Test]
    public void Test1()
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

            Console.Write("Test prošel");
            }

    [TearDown]
    public void EndTest()
    {
        //zavře prohližeč 
        driver.Close();
    }

   
         
}



        


