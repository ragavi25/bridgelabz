using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class ReminderPage
    {
        IWebDriver driver;
        public ReminderPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        [FindsBy(How = How.Id, Using = "reminder")]
        private IWebElement txtreminder;

        [FindsBy(How = How.Id, Using = "select")]
        private IWebElement txtselect;
        [FindsBy(How = How.ClassName, Using = "date")]
        private IWebElement txtdate;
        [FindsBy(How = How.ClassName, Using = "btnsave")]
        private IWebElement btndatesave;

        public void reminder()
        {
            txtreminder.Click();
        }
        public void select()
        {
            txtselect.Click();
        }
        public void date(string Date)
        {
           
           
            System.Threading.Thread.Sleep(5000);
            txtdate.SendKeys(Date);
        }
        public DashboradPage clicksave()
        {
            btndatesave.Submit();
            return new DashboradPage(driver);
        }





    }
}
