//using OpenQA.Selenium.Support.PageObjects;
using System;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace seleniumFundoo.Pages
{
    class LoginPage : BasePage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "mat-input-0")]
        private IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "mat-input-1")]
        private  IWebElement txtPassword;

        [FindsBy(How =How.ClassName,Using = "mat-raised-button")]
        private IWebElement btnLogin;

        public void Login(string Email, string Password)
        {
            System.Threading.Thread.Sleep(5000);
            txtEmail.SendKeys(Email);
            txtPassword.SendKeys( Password);
            
        }
        public DashboradPage Clicklogin()
        {
            btnLogin.Submit();
            return new DashboradPage(driver);
        }
    }
}
