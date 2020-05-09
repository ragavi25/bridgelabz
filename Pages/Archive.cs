using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class Archive
    {
        IWebDriver driver;

        public Archive(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "TxtTakeNote")]
        private IWebElement txtCard;

        [FindsBy(How = How.Id, Using = "archive")]
        private IWebElement btnicon;

        public DashboradPage clickarchive()
        {
            txtCard.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btnicon.Click();
                return new DashboradPage(driver);
        }
    }
}
