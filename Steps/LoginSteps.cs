
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TechTalk.SpecFlow;

namespace seleniumFundoo.Steps
{
    [Binding]
  public class LoginSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        
        [Given(@"I have navigated to my application")]
        public void GivenIhaveNavigatedToMyApplication()
        {
            // Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            currentDriver.Navigate().GoToUrl("http://localhost:4200/login");
        }

        [Given(@"I type the raghavimr(.*)@gmail\.com and (.*)")]
        public void GivenITypeTheRaghavimrGmail_ComAnd(string p, string R)
        {
            LoginPage loginpage = new LoginPage(currentDriver);
            ///ScenarioContext.Current.Pending();
            loginpage.Login(p, R);
        }
     
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            LoginPage loginpage = new LoginPage(currentDriver);
            PropertyCollection.CurrentPage = loginpage.Clicklogin();
        }
        [Then(@"I should see the Dashborad page")]
        public void ThenIShouldSeeTheDashboradPage()
        {

        }
    }
}
