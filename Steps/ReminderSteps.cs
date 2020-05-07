using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class ReminderSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
       
        
        [Given(@"I have click the Reminder icon")]
        public void GivenIHaveClickTheReminderIcon()
        {
            ReminderPage reminderPage = new ReminderPage(currentDriver);
            reminderPage.reminder();
        }

        [When(@"I have the Select date and time")]
        public void WhenIHaveTheSelectDateAndTime()
        {
            ReminderPage reminderPage = new ReminderPage(currentDriver);
            reminderPage.select();
        }
        [Then(@"I have fill the date(.*)")]
        public void ThenIHaveFillTheDate(string p0)
        {
            ReminderPage reminderPage = new ReminderPage(currentDriver);
            reminderPage.date(p0);
        }
        [Then(@"I click the save button")]
        public void ThenIClickTheSaveButton()
        {
            ReminderPage reminderPage = new ReminderPage(currentDriver);
            PropertyCollection.CurrentPage = reminderPage.clicksave();
        }
    }
}
