using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ShadowDOMchromeTests
{
    public class ShadowDOM
    {
        [Test]
        public void DomTest()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();

            IWebElement element = driver.FindElement(By.XPath("//settings-ui")).GetShadowRoot()
                .FindElement(By.CssSelector("settings-main#main")).GetShadowRoot()
                .FindElement(By.CssSelector(""))
                https://www.youtube.com/watch?v=-uMLqBO2x7c&t=724s

        }
    }
}
