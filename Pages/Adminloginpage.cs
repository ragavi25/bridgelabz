using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class Adminloginpage
    {
        IWebDriver driver;
        public Adminloginpage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "mat-input-0")]
        private IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "mat-input-1")]
        private IWebElement txtPassword;

        [FindsBy(How = How.ClassName, Using = "mat-raised-button")]
        private IWebElement btnLogin;

        public void AdminLogin(string Email, string Password)
        {
            System.Threading.Thread.Sleep(5000);
            txtEmail.SendKeys(Email);
            txtPassword.SendKeys(Password);

        }
        public void Clicklogin()
        {
            btnLogin.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.Quit();
            //return new DashboradPage(driver);
        }
    }
}

