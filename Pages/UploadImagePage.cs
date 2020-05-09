using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using AutoItX3Lib;

namespace seleniumFundoo.Pages
{
    class UploadImagePage
    {
        IWebDriver driver;
        public UploadImagePage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }

        [FindsBy(How = How.Id, Using = "TxtTakeNote")]
        private IWebElement txtCard;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/div[1]/mat-drawer-container[1]/mat-drawer-content[1]/mat-drawer-container[1]/mat-drawer-content[1]/div[1]/app-getnote[1]/div[1]/div[2]/mat-card[1]/div[3]/mat-card-footer[1]/app-newicon[1]/div[1]/div[1]/div[1]/a[1]/button[4]/span[1]/mat-icon[1]/img[1]")]
        private IWebElement txtimgicon;

        [FindsBy(How = How.Name, Using = "file")]
        private IWebElement txtchoosefile;

        [FindsBy(How = How.Id, Using = "btn")]
        private IWebElement txtaddimg;

        [FindsBy(How=How.XPath,Using = "/html[1]/body[1]/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-imageupload[1]/form[1]/div[1]/div[1]")]
        private IWebElement txtcancel;

        public void clickicon()
        {
            txtCard.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            txtimgicon.Click();
        }
        //approach 1.sendkey method
        public void choosefile()
        {
             txtchoosefile.SendKeys(@"C:\Users\vanchi\Downloads\nathure.jpg");
            //.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
           // txtchoosefile.Click();
            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");//Activate-so that next set of actions happen on this window
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            auto.Send(@"C:\Users\vanchi\Downloads\nathure.jpg");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            System.Threading.Thread.Sleep(1000);
            auto.Send("(Enter)");
            
        }    
        public DashboradPage addimg()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            txtaddimg.Click();
            System.Threading.Thread.Sleep(6000);
            txtcancel.Click();
            return new DashboradPage(driver);
        }
    }
}
