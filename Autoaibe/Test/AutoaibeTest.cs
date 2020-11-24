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
    public class AutoaibeTest :BaseTest
    {
        //public const string TakeFromShop = "Atsiėmimas parduotuvėje";
        //public const string ShopName = "Minijos g. 169E";
        //public const string PayWithCard = "Apmokėjimas atsiėmimo metu (grynaisiais arba kortele)";
        private static IWebDriver _driver;
        private static AutoaibePage _mainpage; // Atstatyk sita jeigu ka
       // private static AutoaibeCarDetailPage _detailPage;



        //private static ChromeDriver _driver;
        public const string ResultTex = "2011 SEAT IBIZA IV (6J5, 6P1) 1.6 TDI 66kW";


       
        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver(); 
            
            _driver.Navigate().GoToUrl("https://www.autoaibe.lt/"); 
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); 
            _driver.Manage().Window.Maximize();
            _mainpage = new AutoaibePage(_driver);
            //_discBrakePage = new DiscBrakePage(_driver);



        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
            _mainpage.CloseBrowser();
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


        // Jei ka patrink viska kas yra zemiaiu

        //[Test, Order(2)]
        //public void AddToBasketBackBrakes()
        //{
        //    System.Threading.Thread.Sleep(4000);
        //    _disckBrakePage.NavigateToFirstAutoAibePage().SelectAlliedNip();
        //    _disckBrakePage.NavigateToFirstAutoAibePage().AddToBasketBackBrakes();
        //    _disckBrakePage.NavigateToFirstAutoAibePage().NumberOfItems("2");
        //    _disckBrakePage.NavigateToFirstAutoAibePage().ContinueShopping();
        //    //disc.GetFrontrakePrice();
        //    //_druver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);



        //}

        //[Test, Order(3)]
        //public void AddToBasketFrontBrakes()
        //{

        //    //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        //    _disckBrakePage.SelectAlliedNip();
        //    _disckBrakePage.AddToBaskeFrontkBrakes();
        //    _disckBrakePage.NumberOfItems("2");
        //    _disckBrakePage.ProceedWithShopping();
        //    // disc.ProceedWithShopping();



        //}

        //[Test, Order(4)]
        //public void ProceedWithPayment()
        //{
        //    // AutoaibeCheckoutPage checkOutPage = new AutoaibeCheckoutPage(driver);
        //    _checkoutPage.EnterUserName("Tadas");
        //    _checkoutPage.EnterEmail("12345@gmail.com");
        //    _checkoutPage.EnterPhoneNumber("862012012");
        //    _checkoutPage.IsPuchasedByCompany(false);
        //    _checkoutPage.DeliveryMethod(TakeFromShop);
        //    _checkoutPage.WhereToDeliver(ShopName);
        //    _checkoutPage.HowToPay(PayWithCard);
        //    _checkoutPage.EnterCustomerComment("You have bugs in your system");
        //    _checkoutPage.RulesAgreement(true);
        //    _checkoutPage.ConfirmOrder();
        //}

        //[TestCase("2011", "SEAT", "IBIZA IV (6J5, 6P1)", "66 kW 1.6 TDI Dyz.", ResultTex, TestName = "2011 SEAT IBIZA IV (6J5, 6P1) 1.6 TDI 66kW")]


        //public void CheckIfCarISFound(string carYear, string carManufacturer, string carModel, string carEngine, string ResultText)
        //{

        //   // AutoaibePage page = new AutoaibePage(driver);
        //    System.Threading.Thread.Sleep(4000);
        //    _mainAutoaibePage.NavigateToFirstAutoAibePage().SelectFromCarYearDropDown(carYear);
        //    _mainAutoaibePage.NavigateToFirstAutoAibePage().SelectFromCarMakeIDrDropDown(carManufacturer);
        //    _mainAutoaibePage.NavigateToFirstAutoAibePage().SelectFromCarModelIDrDropDown(carModel);
        //    _mainAutoaibePage.NavigateToFirstAutoAibePage().SelectFromCarEngineDropDown(carEngine);
        //    _mainAutoaibePage.NavigateToFirstAutoAibePage().VerifyFoundResult(ResultText);
        //}


        //// Jei ka patrink viska kas yra zemiaiu
        
        //[Test, Order(2)]
        //public void AddToBasketBackBrakes()
        //{
        //    System.Threading.Thread.Sleep(4000);
        //    _disckBrakePage.NavigateToFirstAutoAibePage().SelectAlliedNip();
        //    _disckBrakePage.NavigateToFirstAutoAibePage().AddToBasketBackBrakes();
        //    _disckBrakePage.NavigateToFirstAutoAibePage().NumberOfItems("2");
        //    _disckBrakePage.NavigateToFirstAutoAibePage().ContinueShopping();
        //    //disc.GetFrontrakePrice();
        //    //_druver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);



        //}
        
        //[Test, Order(3)]
        //public void AddToBasketFrontBrakes()
        //{

        //    //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        //    _disckBrakePage.NavigateToFirstAutoAibePage().SelectAlliedNip();
        //    _disckBrakePage.NavigateToFirstAutoAibePage().AddToBaskeFrontkBrakes();
        //    _disckBrakePage.NavigateToFirstAutoAibePage().NumberOfItems("2");
        //    _disckBrakePage.NavigateToFirstAutoAibePage().ProceedWithShopping();
        //    // disc.ProceedWithShopping();



        //}
        
        //[Test, Order(4)]
        //public void ProceedWithPayment()
        //{
        //    // AutoaibeCheckoutPage checkOutPage = new AutoaibeCheckoutPage(driver);
        //    _checkoutPage.NavigateToFirstAutoAibePage().EnterUserName("Tadas");
        //    _checkoutPage.NavigateToFirstAutoAibePage().EnterEmail("12345@gmail.com");
        //    _checkoutPage.NavigateToFirstAutoAibePage().EnterPhoneNumber("862012012");
        //    _checkoutPage.NavigateToFirstAutoAibePage().IsPuchasedByCompany(false);
        //    _checkoutPage.NavigateToFirstAutoAibePage().DeliveryMethod(TakeFromShop);
        //    _checkoutPage.NavigateToFirstAutoAibePage().WhereToDeliver(ShopName);
        //    _checkoutPage.NavigateToFirstAutoAibePage().HowToPay(PayWithCard);
        //    _checkoutPage.NavigateToFirstAutoAibePage().EnterCustomerComment("You have bugs in your system");
        //    _checkoutPage.NavigateToFirstAutoAibePage().RulesAgreement(true);
        //    _checkoutPage.NavigateToFirstAutoAibePage().ConfirmOrder();
        //}


    }
}
