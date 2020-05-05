using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class LogoutPage :BasePage
    {
        IWebDriver driver;
        
        public LogoutPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "btnlogout")]
        private IWebElement btnlogout;

        public LoginPage ClickSignout()
        {
            btnlogout.Click();
            return new LoginPage(driver);
        }


    }
}
