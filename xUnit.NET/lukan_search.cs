using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Search;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.lukan.cz");
            driver.Manage().Window.Maximize();

            IWebElement searchBox = driver.FindElement(By.Name("s"));
            searchBox.SendKeys("test");
            searchBox.Submit();

            Thread.Sleep(3000);

            driver.Quit();
    }
}
