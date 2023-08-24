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

    [FindsBy(How = How.XPath, Using = "//div[2]/span")]
    private IWebElement _clickcookieaccept;
    public HomePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void AcceptCookie()
    {
        _clickcookieaccept.Click();
    }
   }
}
