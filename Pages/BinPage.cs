using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class BinPage
    {
        IWebDriver driver;
        public BinPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-toolbar[1]/div[1]/button[1]/span[1]/mat-icon[1]")]
        private IWebElement txtmenu;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/div[1]/mat-drawer-container[1]/mat-drawer[1]/div[1]/div[1]/mat-nav-list[1]/a[4]/div[1]")]
        private IWebElement txtBin;

        [FindsBy(How = How.XPath, Using = "//mat-icon[contains(text(),'delete')]")]
        private IWebElement txtdeleteall;

        [FindsBy(How = How.XPath, Using = "//mat-icon[contains(text(),'restore')]")]
        private IWebElement txtrestore;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/div[1]/mat-drawer-container[1]/mat-drawer-content[1]/mat-drawer-container[1]/mat-drawer-content[1]/div[1]/app-bin[1]/div[1]/div[2]/div[1]/div[1]/mat-card[1]/mat-card-content[1]/mat-card-footer[1]")]
        private IWebElement txtcard;
        public void clickbin()
        {
            txtmenu.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
           // txtBin.Click();
        }
        public void delete()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/fundoo/Bin?page=Bin&view=row");
            txtcard.Click();
            txtdeleteall.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public void restor()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            txtcard.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            txtrestore.Click();
           // driver.Quit();

        }


    }
}
