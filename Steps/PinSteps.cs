using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class PinSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have see Dashborad page")]
        public void GivenIHaveSeeDashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");

        }
        [When(@"I click the pin")]
        public void WhenIClickThePin()
        {
            PinPage pin = new PinPage(currentDriver);
            pin.clickPin();
        }
    }
}
