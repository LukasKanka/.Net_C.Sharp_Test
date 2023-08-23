using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
    public class WebFormPage
    {
        // locators
        IWebElement TextArea => driver.FindElement(By.Name("my-textarea"));


        IWebDriver driver;

        public WebFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // methods
        public WebFormPage WriteTextToTextArea(string text)
        {
            TextArea.SendKeys(text);
            return this;
        }
    }
}
