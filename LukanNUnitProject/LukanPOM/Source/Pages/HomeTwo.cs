using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Net;


namespace LukanPOM.PageObjects
{
    public class HomeTwo 
    {
        private IWebDriver driver;

        IWebElement ClickDeclineCookie2 => driver.FindElement(By.XPath("//div[3]/span"));


        public HomeTwo(IWebDriver driver)
        {
            this.driver = driver;
        }
        

        public void DeclineCookie2()
       {
        ClickDeclineCookie2.Click();
       }
       public void Hledani()
    {
            IWebElement searchBox = driver.FindElement(By.Name("s"));
            searchBox.SendKeys("test");
            searchBox.Submit();
    }
    
    }
}