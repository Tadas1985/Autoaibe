using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoaibe.Page
{
    class AutoaibePage : BasePage
    {
        public static IWebDriver _driver;

        private SelectElement _carYearDropdown => new SelectElement(_driver.FindElement(By.Name("year")));
        private SelectElement _carMakeID => new SelectElement(_driver.FindElement(By.Name("make_id")));// Cia yra naudojamas naujas tipas, nebe  IwebElement
        private SelectElement _carModelID => new SelectElement(_driver.FindElement(By.Name("model_id")));// Cia yra naudojamas naujas tipas, nebe  IwebElement
        private SelectElement _carEngineID => new SelectElement(_driver.FindElement(By.Name("submodel_id")));// Cia yra naudojamas naujas tipas, nebe  IwebElement
        private IWebElement _brakeDiscs => _driver.FindElement(By.XPath("/html/body/div[5]/ul/li[1]/ul/li[7]/a"));// Cia yra naudojamas naujas tipas, nebe  IwebElement

        private IWebElement findResultText => _driver.FindElement(By.CssSelector("body > div.category-page > div:nth-child(4) > div > h1 > strong"));
        public AutoaibePage(IWebDriver webdriver) : base (webdriver)
        {}

        public AutoaibePage SelectFromCarYearDropDown(string carYear)
        {

            _carYearDropdown.SelectByText(carYear);
            return this;
        }
        public AutoaibePage SelectFromCarMakeIDrDropDown(string carManufacturer)
        {

            _carMakeID.SelectByText(carManufacturer);
            return this;
        }
        public AutoaibePage SelectFromCarModelIDrDropDown(string carModel)
        {
            _carModelID.SelectByText(carModel);
            return this;
        }
        public AutoaibePage SelectFromCarEngineDropDown(string carEngine)
        {
            _carEngineID.SelectByText(carEngine);
            return this;
        }
        private void WaitForResult()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => findResultText.Displayed);
        }


        public AutoaibePage VerifyFoundResult(string ResultText)
        {
            WaitForResult();
            Assert.AreEqual(ResultText, findResultText.Text, "Result does not match");
            return this;
        }
    }
}
