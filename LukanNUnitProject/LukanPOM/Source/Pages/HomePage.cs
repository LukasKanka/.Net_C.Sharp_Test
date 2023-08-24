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
    private IWebDriver _driver;
    
    [FindsBy(How = How.ClassName, Using = "eu-cookies-bar-tick")]
    
    private IWebElement _clickcookieaccept;

    [FindsBy(How = How.Id, Using = "menu-item-439")]
    private IWebElement _clickzasadyochrany;
    
    public HomePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void AcceptCookie()
    {
        _clickcookieaccept.Click();

    }
    public void ZasadyOchrany()
    {
        _clickzasadyochrany.Click();
        
    }
   }
}
