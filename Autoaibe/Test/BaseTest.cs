using Autoaibe.Drivers;
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
    public class BaseTest
    {
        public static IWebDriver driver;
        public static AutoaibePage _mainAutoaibePage;
        public static AutoaibeCarDetailPage _carDetailPage;
        public static DiscBrakePage _disckBrakePage;
        public static AutoaibeCheckoutPage _checkoutPage;
        [OneTimeSetUp]
        public static void SetUp()
        {
            
             driver = CustomDriver.GetChromeDriver();
            _mainAutoaibePage = new AutoaibePage(driver);
            _carDetailPage = new AutoaibeCarDetailPage(driver);
            _disckBrakePage = new DiscBrakePage(driver);
            _checkoutPage = new AutoaibeCheckoutPage(driver);



        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
            //_mainpage.CloseBrowser();
        }
    }
}
