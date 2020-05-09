using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class BinSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have navigate a Dashborad page")]
        public void GivenIHaveNavigateADashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }
        [Given(@"I have click the Bin")]
        public void GivenIHaveClickTheBin()
        {
            BinPage bin = new BinPage(currentDriver);
            bin.clickbin();
        }
        
        [When(@"I have click the Deleteall")]
        public void WhenIHaveClickTheDeleteall()
        {
            BinPage bin = new BinPage(currentDriver);
            bin.delete();
            //currentDriver.Quit();
        }
        
        [Then(@"I have navigate Bin")]
        public void ThenIHaveNavigateBin()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo/Bin?page=Bin&view=row");
        }
        
        [Then(@"I have click the Restore")]
        public void ThenIHaveClickTheRestore()
        {
            BinPage bin = new BinPage(currentDriver);
            bin.restor();
        }
    }
}
