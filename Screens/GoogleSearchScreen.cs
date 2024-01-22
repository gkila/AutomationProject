using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Screens
{
    public class GoogleSearchScreen
    {
        private  IWebDriver driver;
         private  WebDriverWait wait;

        public GoogleSearchScreen(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }        



    }
}