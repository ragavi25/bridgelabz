using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class AdminRegisterSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have navigated to AdminRegister application")]
        public void GivenIHaveNavigatedToAdminRegisterApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/Adminregister");
        }
        [Given(@"I have fill the details")]
        public void GivenIHaveFillTheDetails(Table table)
        {
           // ScenarioContext.Current.Pending();
        }
        [When(@"I click AdminRegister button")]
        public void WhenIClickAdminRegisterButton()
        {
            AdminRegisterPage admin = new AdminRegisterPage(currentDriver);
            admin.ClickAdminRegister();


        }
    }
}
