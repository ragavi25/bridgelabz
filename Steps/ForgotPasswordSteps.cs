using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class ForgotPasswordSteps
    {
        IWebDriver currentDriver = new ChromeDriver();

        [Given(@"I have navigated to ForgotPassword application")]
        public void GivenIHaveNavigatedToForgotPasswordApplication()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/forgot");
        }
        
        [Given(@"I type the (.*)")]
        public void GivenITypeThe(string p0)
        {
            ForgotPage forgot = new ForgotPage(currentDriver);
            forgot.Forgot(p0);
        }
        
        [When(@"I click Forgot button")]
        public void WhenIClickForgotButton()
        {
            ForgotPage forgot = new ForgotPage(currentDriver);
            PropertyCollection.CurrentPage = forgot.ClickForgot();
        }
    }
}
