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
        [Given(@"I have put (.*) and (.*)")]
        public void GivenIHavePutAnd(string p0, string p1)
        {
            AddnotePage addnote = new AddnotePage(currentDriver);
            addnote.Addnote(p0, p1);
        }
        [When(@"I click close button")]
        public void WhenIClickCloseButton()
        {
            AddnotePage addnote = new AddnotePage(currentDriver);
            PropertyCollection.CurrentPage = addnote.ClickClose();
        }
    }
}
