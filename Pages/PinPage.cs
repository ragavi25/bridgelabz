using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class PinPage
    {
        IWebDriver driver;

        public PinPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        [FindsBy(How = How.Id, Using = "TxtTakeNote")]
        private IWebElement txtCard;

        [FindsBy(How = How.Id, Using = "takepin")]
        private IWebElement btnicon;

        [FindsBy(How = How.Id, Using = "takeunpin")]
        private IWebElement btnunpin;


        public void clickPin()
        {
            txtCard.Click();
            System.Threading.Thread.Sleep(2000);
            btnicon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btnunpin.Click();
            //return new DashboradPage(driver);
        }
    }
}
