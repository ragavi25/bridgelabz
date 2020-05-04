using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
     class AddnotePage : BasePage
    {
        IWebDriver driver;
        public AddnotePage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        public AddnotePage()
        {
        }

        [FindsBy(How = How.ClassName, Using = "title")]
        private IWebElement txtTitle;

        [FindsBy(How = How.ClassName, Using = "add-note")]
        private IWebElement txtDescription;

        [FindsBy(How = How.ClassName, Using = "close")]
        private IWebElement btnClose;

        public void Addnote(string Title, string Description)
        {
            System.Threading.Thread.Sleep(5000);
            txtTitle.SendKeys(Title);
            txtDescription.SendKeys(Description);
        }
        public DashboradPage ClickClose()
        {
            btnClose.Submit();
            return new DashboradPage(driver);
        }
    }
}
