using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class ListViewPage
    {
        IWebDriver driver;

        public ListViewPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-toolbar[1]/div[1]/div[3]/div[1]/button[1]/span[1]/mat-icon[1]")]
        private IWebElement txtView;

        public DashboradPage ClickView()
        {
            txtView.Click();
            return new DashboradPage(driver);
        }

    }
}
