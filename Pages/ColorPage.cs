using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class ColorPage
    {
        IWebDriver driver;

        public ColorPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            this.driver = currentDriver;
        }
        [FindsBy(How = How.Id, Using = "TxtTakeNote")]
        private IWebElement txtCard;

        [FindsBy(How = How.Id, Using = "color")]
        private IWebElement btnicon;

        [FindsBy(How = How.XPath, Using = "//div[@class='ng-star-inserted']//div[1]//div[1]//button[1]")]
        private IWebElement changecolor;

        public void clickicon()
        {
            txtCard.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btnicon.Click();
        }
        public void colors()
        {
            //System.Threading.Thread.Sleep(5000);
            changecolor.Click();
        }

        public DashboradPage checkcolor()
        {
            changecolor.Click();
            return new DashboradPage(driver);
        }
    }
}
