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
    class AutoaibeTest
    {
        private static IWebDriver _driver;
        public const string ResultTex = "2011 SEAT IBIZA IV (6J5, 6P1) 1.6 TDI 66kW";

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https://www.autoaibe.lt/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            //_driver.FindElement(By.Id("cookiescript_reject")).Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Quit();
        }
        [TestCase("2011", "SEAT", "IBIZA IV (6J5, 6P1)", "66 kW 1.6 TDI Dyz.", ResultTex, TestName = "2011 SEAT IBIZA IV (6J5, 6P1) 1.6 TDI 66kW")]


        public void CheckIfCarISFound(string carYear, string carManufacturer, string carModel, string carEngine, string ResultText)
        {
            AutoaibePage page = new AutoaibePage(_driver);

            System.Threading.Thread.Sleep(4000);
            page.SelectFromCarYearDropDown(carYear);
            page.SelectFromCarMakeIDrDropDown(carManufacturer);
            page.SelectFromCarModelIDrDropDown(carModel);
            page.SelectFromCarEngineDropDown(carEngine);
            page.VerifyFoundResult(ResultText);
        }
    }
}
