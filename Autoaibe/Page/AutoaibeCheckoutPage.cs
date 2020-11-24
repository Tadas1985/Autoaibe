using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoaibe.Page
{
    public class AutoaibeCheckoutPage : BasePage
    {
        protected const string pageAddress = "https://www.autoaibe.lt/checkout/create/51556/";


        private IWebElement username => Driver.FindElement(By.Id("id_user_name"));
        private IWebElement emailAdress => Driver.FindElement(By.Id("id_email"));
        private IWebElement phoneNumber => Driver.FindElement(By.Id("id_phone_num"));
        private IWebElement purchasedBycompany => Driver.FindElement(By.Id("id_is_company"));
        private SelectElement deliveryMethod => new SelectElement(Driver.FindElement(By.Id("id_shipping_method")));
        private SelectElement deliveryShop => new SelectElement(Driver.FindElement(By.Id("shipping_store")));
        private SelectElement methodOfPayment => new SelectElement(Driver.FindElement(By.Id("id_payment_method")));
        private IWebElement customerComment => Driver.FindElement(By.Id("id_customer_comment"));
        private IWebElement rulesAgreement => Driver.FindElement(By.Id("id_agree_with_rules"));
        private IWebElement confirmPurchase => Driver.FindElement(By.CssSelector("#checkout-form > div.rules-discount-container.clearfix > button"));




        public AutoaibeCheckoutPage(IWebDriver webDriver) : base(webDriver)
        {
            //Driver.Url = pageAdress;
        }
        public AutoaibeCheckoutPage NavigateToFirstAutoAibePage()
        {
            if (Driver.Url != pageAddress)
                Driver.Url = pageAddress;


            return this;
        }

        public AutoaibeCheckoutPage EnterUserName(string userName)
        {
            username.Clear();
            username.SendKeys(userName);
            return this;
        }
        public AutoaibeCheckoutPage EnterEmail(string email)
        {
            emailAdress.Clear();
            emailAdress.SendKeys(email);
            return this;
        }
        public AutoaibeCheckoutPage EnterPhoneNumber(string _phoneNumber)
        {
            phoneNumber.Clear();
            phoneNumber.SendKeys(_phoneNumber);
            return this;
        }
        public AutoaibeCheckoutPage IsPuchasedByCompany(bool _purchasedByCompany)
        {
            if (_purchasedByCompany != purchasedBycompany.Selected)
                purchasedBycompany.Click();
            return this;
        }
        public AutoaibeCheckoutPage DeliveryMethod(string _deliveryMethod)
        {

            deliveryMethod.SelectByText(_deliveryMethod);
            return this;
        }
        public AutoaibeCheckoutPage WhereToDeliver(string _whereToDeliver)
        {
            deliveryShop.SelectByText(_whereToDeliver);
            return this;
        }
        public AutoaibeCheckoutPage HowToPay(string _howToPay)
        {
            methodOfPayment.SelectByText(_howToPay);
            return this;
        }
        public AutoaibeCheckoutPage EnterCustomerComment(string _customerComment)
        {
            customerComment.Clear();
            customerComment.SendKeys(_customerComment);
            return this;
        }
        public AutoaibeCheckoutPage RulesAgreement(bool _rulesAgreement)
        {
            if (_rulesAgreement != rulesAgreement.Selected)
                purchasedBycompany.Click();
            return this;
        }
        public AutoaibeCheckoutPage ConfirmOrder()
        {
            confirmPurchase.Click();
            return this;
        }

    }
}
