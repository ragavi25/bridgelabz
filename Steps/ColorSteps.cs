using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class ColorSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I should  the Dashborad page")]
        public void GivenIShouldTheDashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }
        [Given(@"I have click the color icon")]
        public void GivenIHaveClickTheColorIcon()
        {
            ColorPage colorPage = new ColorPage(currentDriver);
            colorPage.clickicon();
        }
        [When(@"I have take the color")]
        public void WhenIHaveTakeTheColor()
        {
            ColorPage colorPage = new ColorPage(currentDriver);
            colorPage.colors();
        }
        
    }
}
