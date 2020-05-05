using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class LogoutSteps
    {
        IWebDriver currentDriver = new ChromeDriver();

        [Given(@"I have navigated to Dashborad Application")]
        public void GivenIHaveNavigatedToDashboradApplication()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
            currentDriver.Manage().Window.FullScreen();
        }
        
        [When(@"I click signout button")]
        public void WhenIClickSignoutButton()
        {
            LogoutPage logout = new LogoutPage(currentDriver);
            PropertyCollection.CurrentPage = logout.ClickSignout();
        }
    }
}
