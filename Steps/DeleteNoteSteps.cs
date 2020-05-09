using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class DeleteNoteSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have a navigate to display page")]
        public void GivenIHaveANavigateToDisplayPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }
        [Given(@"I have click the more icons")]
        public void GivenIHaveClickTheMoreIcons()
        {
            DeleteNotePage deleteNote = new DeleteNotePage(currentDriver);
            deleteNote.more();
        }

        [When(@"I have click DeleteNote")]
        public void WhenIHaveClickDeleteNote()
        {
            DeleteNotePage deleteNote = new DeleteNotePage(currentDriver);
            deleteNote.DeleteNote();
        }
    }
}
