using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class RegisterPage : BasePage
    {
        IWebDriver driver;
        public RegisterPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "mat-input-0")]
        private IWebElement txtFirstname;
        [FindsBy(How = How.Id, Using = "mat-input-1")]
        private IWebElement txtLastname;
        [FindsBy(How = How.Id, Using = "mat-input-2")]
        private IWebElement txtEmail;
        [FindsBy(How = How.Id, Using = "mat-input-3")]
        private IWebElement txtPassword;

        [FindsBy(How = How.ClassName, Using = "mat-raised-button")]
        private IWebElement btnLogin;

        public void Register(string FirstName,string LastName,string Email, string Password)
        {
            System.Threading.Thread.Sleep(5000);
            txtFirstname.SendKeys(FirstName);
            txtLastname.SendKeys(LastName);
            txtEmail.SendKeys(Email);
            txtPassword.SendKeys(Password);

        }
        public LoginPage ClickRegister()
        {
            btnLogin.Submit();
            return new LoginPage(driver);
        }
    }
}
