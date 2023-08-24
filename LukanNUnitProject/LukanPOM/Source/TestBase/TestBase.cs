using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using LukanPOM.PageObjects;

namespace LukanPOM.Common
{
    internal class TestBase
    {
        public HomePage home { get; private set; }
        protected IWebDriver Driver { get; private set; }
       

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://lukan.cz");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            home = new HomePage(Driver);
            
        }


        [TearDown]
        public void TearDown()
        {
            
            Driver.Quit();
        }
    }

    
}