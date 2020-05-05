using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class ForgotPage
    {
        IWebDriver driver;

        public ForgotPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        [FindsBy(How = How.Id, Using = "mat-input-0")]
        private IWebElement txtEmail;

        [FindsBy(How = How.ClassName, Using = "mat-raised-button")]
        private IWebElement btnLogin;

        public void Forgot(string Email)
        {
            System.Threading.Thread.Sleep(5000);
            txtEmail.SendKeys(Email);
        }
        public LoginPage ClickForgot()
        {
            btnLogin.Submit();
            return new LoginPage(driver);
        }

    }
}
