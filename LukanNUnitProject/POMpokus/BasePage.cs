using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace POMpokus

{
    public class BasePage
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Console.WriteLine("Author: Lukáš Kaňka");
        }


       [Test]
        public void Initialize(){
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://login.yahoo.com/");
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }


    }
}