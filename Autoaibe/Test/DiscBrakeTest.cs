using Autoaibe.Page;
using Autoaibe.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoaibe.Test
{
    class DiscBrakeTest
    {
        public int sumOfItems;
        public int numOfBrakes = 2;

        private static IWebDriver _driver;
        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https://www.autoaibe.lt/2011-seat-ibizaiv6j56p1-autodalys/detales/stabdziu-sistema/stabdziu-diskai/?subm.td=31600&order_by=");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _driver.Manage().Window.Maximize();
            //_driver.FindElement(By.Id("cookiescript_reject")).Click();
        }
        [TearDown]
        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.MakeScreenshot(_driver);
            }
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Quit();
        }
        [Test]
        public void AddToBasketBackBrakes()
        {
            DiscBrakePage disc = new DiscBrakePage(_driver);
            disc.SelectAlliedNip();
            disc.AddToBasketBackBrakes();
            disc.NumberOfItems("2");
            disc.ContinueShopping();
            //disc.GetFrontrakePrice();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);



        }
        [Test]
        public void AddToBasketFrontBrakes()
        {
            DiscBrakePage disc = new DiscBrakePage(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            disc.SelectAlliedNip();
            disc.AddToBaskeFrontkBrakes();
            disc.NumberOfItems("2");
            disc.ProceedWithShopping();
            // disc.ProceedWithShopping();


        }





    }
}
