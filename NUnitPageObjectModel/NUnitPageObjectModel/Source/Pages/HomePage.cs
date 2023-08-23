using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPageObjectModel.Source.Pages
{
    public class HomePage
    {   
        private IWebDriver _driver;
        [FindsBy]
        private IWebElement _searchtextbox;
        public HomePage(IWebDriver driver)
            
        {
            _driver = driver;
        }

        public void Search(string searchText) 
        {
            _driver.FindElement(By.Id("twoabsearchtextbox"));

        }
    }
}
