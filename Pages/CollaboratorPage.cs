using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class CollaboratorPage
    {

        IWebDriver driver;
        public CollaboratorPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "TxtTakeNote")]
        private IWebElement txtCard;
        [FindsBy(How = How.ClassName, Using = "totalperson")]
        private IWebElement txtemail;
        [FindsBy(How = How.Id, Using = "colla")]
        private IWebElement iconcoll;
        [FindsBy(How = How.Id, Using = "Savecoll")]
        private IWebElement btnSave;
         
        public void clickicon()
        {
            txtCard.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            iconcoll.Click();
        }
        public void Collaborator(string email)
        {
            System.Threading.Thread.Sleep(5000);
            txtemail.SendKeys(email);
        }
        public DashboradPage ClickSave()
        {
            btnSave.Submit();
            return new DashboradPage(driver);
        }
    }
}
