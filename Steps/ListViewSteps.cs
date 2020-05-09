using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class ListViewSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have navigate Dashborad page")]
        public void GivenIHaveNavigateDashboradPage()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo/getnote?page=notes&view=row");
            currentDriver.Manage().Window.Maximize();
        }
        
        [When(@"I click the listview")]
        public void WhenIClickTheListview()
        {
            ListViewPage listView = new ListViewPage(currentDriver);
            PropertyCollection.CurrentPage = listView.ClickView();
        }
    }
}
