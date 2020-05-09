using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class LabelPage
    {
        IWebDriver driver;
        public LabelPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        [FindsBy(How = How.Id, Using = "TxtTakeNote")]
        private IWebElement txtCard;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/div[1]/mat-drawer-container[1]/mat-drawer-content[1]/mat-drawer-container[1]/mat-drawer-content[1]/div[1]/app-getnote[1]/div[1]/div[2]/mat-card[1]/div[3]/mat-card-footer[1]/app-newicon[1]/div[1]/div[1]/div[1]/a[1]/button[6]/span[1]/mat-icon[1]")]
        private IWebElement txtmore;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[2]/div[1]/div[1]/div[1]/button[2]")]
        private IWebElement txtaddlabel;

        [FindsBy(How = How.ClassName, Using = "mat-form-field-autofill-control")]
        private IWebElement txtcreatelabel;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-editlabel[1]/div[1]/div[3]/button[1]/span[1]")]
        private IWebElement btndone;

        public void more()
        {
            txtCard.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            txtmore.Click();
            //System.Threading.Thread.Sleep(2000);
        }
        public void Addlabel()
        {
            //WebDriverWait wait = new WebDriverWait(ngdriver, TimeSpan.FromSeconds(30));
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*@id='btnSubmit']"));
            //btnsave.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            txtaddlabel.Click();

        }
        public void createlabel(string labelname)
        {

            System.Threading.Thread.Sleep(5000);
            txtcreatelabel.SendKeys(labelname);
        }
        public DashboradPage clickdone()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btndone.Click();
            return new DashboradPage(driver);
        }

    }
}
