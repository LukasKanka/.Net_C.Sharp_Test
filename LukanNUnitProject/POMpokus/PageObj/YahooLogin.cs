using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumExtras.PageObjects;


namespace POMpokus.PageObj

{
    public class YahooLogin : BasePage
    {
       
       public YahooLogin(IWebDriver driver){
        YahooLogin.driver = driver;
       }


    }
}