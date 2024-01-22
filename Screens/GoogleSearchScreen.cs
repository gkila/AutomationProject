using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

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

         public void Open()
        {   driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://google.com");
            
        }

         public void SearchFor(string searchValue)
        {
            IWebElement searchBox = wait.Until(driver => driver.FindElement(By.Id("APjFqb")));   
            searchBox.Clear();    
            searchBox.SendKeys(searchValue);           
            searchBox.Submit();
            List<IWebElement> secondLink = wait.Until(driver => driver.FindElements(By.XPath("//h3[@class='LC20lb MBeuO DKV0Md']"))).ToList();
            AssertionResult.Equals("Home Care Software Designed By Nurses for Nurses- HCHB", secondLink[1].Text);
            secondLink[1].Click();
            List<IWebElement> ele = wait.Until(driver => driver.FindElements(By.XPath("//span[@class='elementor-icon-list-text']"))).ToList();
            AssertionResult.Equals("866-535-4242", ele[1].Text);

            System.Threading.Thread.Sleep(5000);
        }



    }
}