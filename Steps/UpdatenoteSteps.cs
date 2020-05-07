using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class UpdatenoteSteps
    {
        IWebDriver currentDriver = new ChromeDriver();

        [Given(@"I have navigated to displaynote Application")]
        public void GivenIHaveNavigatedToDisplaynoteApplication()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo/getnote?page=notes&view=row");
            currentDriver.Manage().Window.Maximize();
        }
        [Given(@"I have update the (.*) and (.*)")]
        public void GivenIHaveUpdateTheAnd(string p0, string p1)
        {
            UpdatenotePage updatenotePage = new UpdatenotePage(currentDriver);
            updatenotePage.Updatenote(p0, p1);
        }

        [When(@"I click updateClose button")]
        public void WhenIClickUpdateCloseButton()
        {
            UpdatenotePage updatenotePage = new UpdatenotePage(currentDriver);
            PropertyCollection.CurrentPage = updatenotePage.ClickClose();
        }
    }
}
