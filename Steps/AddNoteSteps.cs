using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class AddNoteSteps
    {

        IWebDriver currentDriver = new ChromeDriver();
        // Put an Implicit wait, this means that any search for elements on the page could take the time the implicit wait is set for before throwing exception
      
        [Given(@"I type the data")]
        public void GivenITypeTheData(Table table)
        {


        }

        [Given(@"I should see the Dashborad page")]
        public void GivenIShouldSeeTheDashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        // currentDriver.Manage().Window.Maximize();

        }
        [Then(@"I have click take note")]
        public void ThenIHaveClickTakeNote()
        {
            AddnotePage addnote = new AddnotePage(currentDriver);
            addnote.clicknote();

        }
        [Given(@"I have put (.*) and (.*)")]
        public void GivenIHavePutAnd(string p0, string p1)
        {
            AddnotePage addnote = new AddnotePage(currentDriver);
            addnote.Addnote(p0, p1);
        }
        [When(@"I have click the Reminder icon")]
        public void WhenIHaveClickTheReminderIcon()
        {
            ReminderPage reminderPage = new ReminderPage(currentDriver);
            reminderPage.reminder();
        }

        [Then(@"I have click the Collaborator icon")]
        public void ThenIHaveClickTheCollaboratorIcon()
        {
            CollaboratorPage collaboratorPage = new CollaboratorPage(currentDriver);
            collaboratorPage.clickicon();
        }

        [Then(@"I have click the Color icon")]
        public void ThenIHaveClickTheColorIcon()
        {
            ColorPage colorPage = new ColorPage(currentDriver);
            colorPage.clickicon();
        }
    
    [When(@"I click close button")]
        public void WhenIClickCloseButton()
        {
            AddnotePage addnote = new AddnotePage(currentDriver);
            PropertyCollection.CurrentPage = addnote.ClickClose();
        }
    }
}
