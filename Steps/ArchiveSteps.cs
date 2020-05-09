using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class ArchiveSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I m see the Dashborad page")]
        public void GivenIMSeeTheDashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }

        [When(@"I click the Archive")]
        public void WhenIClickTheArchive()
        {
            Archive archive = new Archive(currentDriver);
            PropertyCollection.CurrentPage = archive.clickarchive();
            currentDriver.Quit();
        }
    }
}
