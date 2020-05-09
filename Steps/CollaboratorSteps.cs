using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class CollaboratorSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have navigate to Dashborad page")]
        public void GivenIHaveNavigateToDashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }
        [Given(@"I have click the Collaborator icon")]
        public void GivenIHaveClickTheCollaboratorIcon()
        {
            CollaboratorPage collaboratorPage = new CollaboratorPage(currentDriver);
            collaboratorPage.clickicon();
        }
        
        [When(@"I have fill the (.*)")]
        public void WhenIHaveFillThe(string p0)
        {
            CollaboratorPage collaboratorPage = new CollaboratorPage(currentDriver);
            collaboratorPage.Collaborator(p0);
        }
        
        [Then(@"I click the Save button")]
        public void ThenIClickTheSaveButton()
        {
            CollaboratorPage collaboratorPage = new CollaboratorPage(currentDriver);
            PropertyCollection.CurrentPage = collaboratorPage.ClickSave();
        }
    }
}
