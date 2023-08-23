using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitProject.Tests
{
    internal class LocatorsTests
    {
        [Test]
        public void LocatorsTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            Assert.That(driver.Title, Is.EqualTo("Selenium"));

            // Zkontrolujeme na stránce element 
            // class name (search)
            var classNameValidator = driver.FindElement(By.ClassName("DocSearch")).Displayed;
            Assert.That(classNameValidator, Is.EqualTo(true));

            // css selector (search)
            var cssSelectorValidator = driver.FindElement(By.CssSelector(".DocSearch")).Displayed;
            Assert.That(cssSelectorValidator, Is.EqualTo(true));

            // id (zkontrolujeme logo)
            var idValidator = driver.FindElement(By.Id("Layer_1")).Displayed;
            Assert.That(idValidator, Is.EqualTo(true));

            // name (donate)
            var nameValidator = driver.FindElement(By.Name("submit")).Displayed;
            Assert.That(nameValidator, Is.EqualTo(true));

            // link text (documentation)
            var linkTextValidator = driver.FindElement(By.LinkText("Documentation")).Displayed;
            Assert.That(linkTextValidator, Is.EqualTo(true));

            // partial link text (castecny text)
            var partialLinkTextValidator = driver.FindElement(By.PartialLinkText("Doc")).Displayed;
            Assert.That(partialLinkTextValidator, Is.EqualTo(true));

            // tag (menu bar)
            var tagValidator = driver.FindElement(By.TagName("Nav")).Displayed;
            Assert.That(tagValidator, Is.EqualTo(true));

            // xpath (text na hlavní straně h1)
            var xpathVAlidator = driver.FindElement(By.XPath("//h1")).Displayed;
            Assert.That(xpathVAlidator, Is.EqualTo(true));
            Console.WriteLine(xpathVAlidator);

            driver.Quit();

        }
    }
}
