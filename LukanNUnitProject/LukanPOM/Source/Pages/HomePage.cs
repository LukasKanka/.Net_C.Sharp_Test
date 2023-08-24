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
   public class HomePage
   {
    private IWebDriver driver;
    
    

    IWebElement ClickAcceptCookie => driver.FindElement(By.XPath("//div[2]/span"));
    IWebElement ClickZasady => driver.FindElement(By.Id("menu-item-439"));

        
    
    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void AcceptCookie()
    {
        ClickAcceptCookie.Click();

    }
    public void ZasadyOchrany()
    {
        
        ClickZasady.Click();
    }

    public void  TitleTest()
    {
     
    }
    
        
    }

        
    
}
