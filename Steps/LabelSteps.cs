using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class LabelSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have a navigate to Dashborad page")]
        public void GivenIHaveANavigateToDashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }
        [Given(@"I have click the more icon")]
        public void GivenIHaveClickTheMoreIcon()
        {
            LabelPage labelPage = new LabelPage(currentDriver);
            labelPage.more();
        }
        
        [When(@"I have click Addlabel")]
        public void WhenIHaveClickAddlabel()
        {
            LabelPage labelPage = new LabelPage(currentDriver);
            labelPage.Addlabel();
        }
        
        [Then(@"I have create a label name (.*)")]
        public void ThenIHaveCreateALabelName(string p0)
        {
            LabelPage labelPage = new LabelPage(currentDriver);
            labelPage.createlabel(p0);
        }
        
        [Then(@"I click the done button")]
        public void ThenIClickTheDoneButton()
        {
            LabelPage labelPage = new LabelPage(currentDriver);
            PropertyCollection.CurrentPage = labelPage.clickdone();
        }
    }
}
