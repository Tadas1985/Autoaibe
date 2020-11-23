using Autoaibe.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoaibe.Test
{
    class AutoaibeCarDetailTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https://www.autoaibe.lt/2011-seat-ibizaiv6j56p1-autodalys/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            //_driver.FindElement(By.Id("cookiescript_reject")).Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }
       
        public void C()
        {
            AutoaibeCarDetailPage pageDetails = new AutoaibeCarDetailPage(_driver);
            pageDetails.SelectDiscBrakes();
        }
       
    }
}
