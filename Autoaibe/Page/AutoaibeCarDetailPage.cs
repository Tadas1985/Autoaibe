using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoaibe.Page
{
    public class AutoaibeCarDetailPage : BasePage
    {
        private const string ResultTex = "2011 SEAT IBIZA IV (6J5, 6P1) 1.6 TDI 66kW ";
        private const string PageAddress = "https://www.autoaibe.lt/2011-seat-ibizaiv6j56p1-autodalys/";


        private IWebElement _brakeDiscs => Driver.FindElement(By.XPath("/html/body/div[5]/ul/li[1]/ul/li[7]/a"));
        //private IWebElement findResultText => _driver.FindElement(By.CssSelector("body > div.category-page > div.container.clearfix > div.product-list-wrapper.product-list-results > div.car-fit-alert > span"));
        public AutoaibeCarDetailPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
        //public AutoaibeCarDetailPage NavigateToFirstAutoAibePage()
        //{
        //    if (Driver.Url != PageAddress)
        //        Driver.Url = PageAddress;


        //    return this;
        //}
        //public AutoaibeCarDetailPage




        public AutoaibeCarDetailPage SelectDiscBrakes()
        {
            _brakeDiscs.Click();
            return this;
        }
    }
}
