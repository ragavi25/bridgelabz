using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class AdminloginSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have navigated to Adminlogin application")]
        public void GivenIHaveNavigatedToAdminloginApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/Adminlogin");

        }
        [Given(@"I have take data")]
        public void GivenIHaveTakeData(Table table)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I click Adminlogin button")]
        public void WhenIClickAdminloginButton()
        {
            Adminloginpage adminloginpage = new Adminloginpage(currentDriver);
            adminloginpage.Clicklogin();
        }
    }
}
