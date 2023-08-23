using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Threading;


namespace Search_Google;

public class Tests
{
    IWebDriver driver = new ChromeDriver();
     

    [SetUp]
    public void Setup()
    {
        
            driver.Navigate()
                  .GoToUrl("https://www.google.com");       
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
           
    }

    [Test]
    public void Test1()
    {
        
            driver.Navigate().GoToUrl("https://www.google.com");

         // odmitne cookie
       IWebElement odmitnout = driver.FindElement(By.Id("W0wltc"));
            odmitnout.Click();

            //zkontroluje nadpis webu
            string actualTitle = driver.Title;
            string expectedTitle = "Google";
            Assert.AreEqual(expectedTitle, actualTitle);
             

             // klikne na test a do vyhledávacího pole zadá test
             IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("test");
            searchBox.Submit();

            Thread.Sleep(3000);

           /* // klikne na rychlé nastavení
            IWebElement nastaveni = driver.FindElement(By.Path(""));
            nastaveni.Click();
            */
         
             IWebElement zpet = driver.FindElement(By.Id("logo"));
            zpet.Click();
            
            //Zápis do console
            Console.Write("Test na vložení slova test do vyhledávacího pole na stránkách google.com");

            Thread.Sleep(2000);
            
            }

     [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
}