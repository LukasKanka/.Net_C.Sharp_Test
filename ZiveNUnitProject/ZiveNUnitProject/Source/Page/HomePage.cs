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


namespace ZiveNunitProject.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;



        
        IWebElement cookiesAccept => driver.FindElement(By.XPath("//button[@id='didomi-notice-agree-button']/span"));

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        

        public HomePage Titulek()
        {
            string actualTitle = driver.Title;
            string expectedTitle = "�iv�.cz � O po��ta��ch, internetu, v�d� a technice";
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

        public void AcceptCoockies()
        {
            cookiesAccept.Click();
        }
    }



}
