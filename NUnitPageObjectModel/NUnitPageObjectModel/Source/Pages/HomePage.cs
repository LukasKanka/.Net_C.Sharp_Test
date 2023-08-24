using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;


namespace NUnitPageObjectModel.Source.Pages
{
    public class HomePage
    {   
        private IWebDriver _driver;
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement _searchtextbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        private IWebElement _searchbtn;
        public HomePage(IWebDriver driver)
            
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Search(string searchText) 
        {
            _searchtextbox.SendKeys(searchText);
            _searchbtn.Click();

        }
    }
}
