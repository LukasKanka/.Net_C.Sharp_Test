using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ZiveNunitProject.PageObjects;

namespace ZiveNunitProject.Common
{
    internal class TestBase
    {
        public HomePage Home { get; private set; }
      
        protected IWebDriver Driver { get; private set; }


        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://zive.cz");
            Console.WriteLine("Author: Lukáš Kaòka");
            Home = new HomePage(Driver);
            

        }


        [TearDown]
        public void TearDown()
        {

            Driver.Quit();
        }
    }


}