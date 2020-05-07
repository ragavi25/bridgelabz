using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class UpdatenotePage
    {
        IWebDriver driver;

        public UpdatenotePage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;

        }
        [FindsBy(How = How.Id, Using = "ntitle")]
        private IWebElement txtTitle;

        [FindsBy(How = How.Id, Using = "titles")]
        private IWebElement txtDescription;

        [FindsBy(How = How.Id, Using = "updatesave")]
        private IWebElement btnClose;

        public void Updatenote(string Title, string Description)
        {
            System.Threading.Thread.Sleep(5000);
            txtTitle.SendKeys(Title);
            txtDescription.SendKeys(Description);
        }
        public DashboradPage ClickClose()
        {
            btnClose.Click();
            return new DashboradPage(driver);
        }
    }
}
