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
    IWebElement ClickDeclineCookie => driver.FindElement(By.XPath("//div[3]/span"));

    IWebElement ClickZasady => driver.FindElement(By.Id("menu-item-439"));

        
    
    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void AcceptCookie()
    {
        ClickAcceptCookie.Click();

    }
      public void DeclineCookie()
    {
        ClickDeclineCookie.Click();
    }
    public void ZasadyOchrany()
    {
        
        ClickZasady.Click();
    }

    public HomePage  Titulek()
    {
        string actualTitle = driver.Title;
        string expectedTitle = "Lukáš bloguje - Blog o všem možném i nemožném";
        Assert.AreEqual(expectedTitle, actualTitle);
        return this;
    }
    public HomePage Screnshot()
    {
        string fileName = "example_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
             Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
             screenshot.SaveAsFile(@"C:\Users\lukas\Nextcloud\GitHub\.Net_C.Sharp_Test\LukanNUnitProject\LukanNUnitProject\Foto\" + fileName, ScreenshotImageFormat.Png);
             return this;
    }

    public HomePage TestProsel()
    {
        Console.WriteLine("Test prošel");
        return this;
    }
    
        
    }

        
    
}
