using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoaibe.Page
{
    class AutoaibeCarDetailPage
    {
        private const string ResultTex = "2011 SEAT IBIZA IV (6J5, 6P1) 1.6 TDI 66kW ";
        public static IWebDriver _driver;

        private IWebElement _brakeDiscs => _driver.FindElement(By.XPath("/html/body/div[5]/ul/li[1]/ul/li[7]/a"));
        private IWebElement findResultText => _driver.FindElement(By.CssSelector("body > div.category-page > div.container.clearfix > div.product-list-wrapper.product-list-results > div.car-fit-alert > span"));
        public AutoaibeCarDetailPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }



        
        public AutoaibeCarDetailPage SelectDiscBrakes()
        {
            _brakeDiscs.Click();
            return this;
        }
    }
}
