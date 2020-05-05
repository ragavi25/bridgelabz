using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class RegisterSteps
    {
        IWebDriver currentDriver = new ChromeDriver();

        [Given(@"I have navigated to Register application")]
        public void GivenIHaveNavigatedToRegisterApplication()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/register");
        }
        
        [Given(@"I type the (.*),(.*),(.*) and (.*)")]
        public void GivenITypeTheAnd(string p0, string p1, string p2, string p3)
        {
            RegisterPage register = new RegisterPage(currentDriver);
            register.Register(p0, p1, p2, p3);
        }
        [When(@"I click Register button")]
        public void WhenIClickRegisterButton()
        {
            RegisterPage register = new RegisterPage(currentDriver);
            PropertyCollection.CurrentPage = register.ClickRegister();
        }
        
        [Then(@"I should see the login page")]
        public void ThenIShouldSeeTheLoginPage()
        {
          
        }
    }
}
