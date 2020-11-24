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
    class AutoAibeCheckOutTest
    {
        private static IWebDriver _driver;
        public const string TakeFromShop = "Atsiėmimas parduotuvėje";
        public const string ShopName = "Minijos g. 169E";
        public const string PayWithCard = "Apmokėjimas atsiėmimo metu (grynaisiais arba kortele)";

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https://www.autoaibe.lt/checkout/create/51556/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _driver.Manage().Window.Maximize();
            //_driver.FindElement(By.Id("cookiescript_reject")).Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Quit();
        }
        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.MakeScreenshot(_driver);
            }
        }
        [Test]
        public void ProceedWithPayment()
        {
            AutoaibeCheckoutPage checkOutPage = new AutoaibeCheckoutPage(_driver);
            checkOutPage.EnterUserName("Tadas");
            checkOutPage.EnterEmail("12345@gmail.com");
            checkOutPage.EnterPhoneNumber("862012012");
            checkOutPage.IsPuchasedByCompany(false);
            checkOutPage.DeliveryMethod(TakeFromShop);
            checkOutPage.WhereToDeliver(ShopName);
            checkOutPage.HowToPay(PayWithCard);
            checkOutPage.EnterCustomerComment("You have bugs in your system");
            checkOutPage.RulesAgreement(true);
            checkOutPage.ConfirmOrder();
        }
    }
}
