using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumFundoo.Pages;
using System;
using TechTalk.SpecFlow;

namespace seleniumFundoo
{
    [Binding]
    public class UploadImageSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        [Given(@"I have navigated to addnote Application")]
        public void GivenIHaveNavigatedToAddnoteApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }
        [Given(@"I have click the UploadImage icon")]
        public void GivenIHaveClickTheUploadImageIcon()
        {
            UploadImagePage uploadImage = new UploadImagePage(currentDriver);
            uploadImage.clickicon();
        }
        
        [When(@"I have click the choose file")]
        public void WhenIHaveClickTheChooseFile()
        {
            UploadImagePage uploadImage = new UploadImagePage(currentDriver);
            uploadImage.choosefile();
        }
        
        [Then(@"I click the AddImg button")]
        public void ThenIClickTheAddImgButton()
        {
            UploadImagePage uploadImage = new UploadImagePage(currentDriver);
           PropertyCollection.CurrentPage= uploadImage.addimg(); 
        }
    }
}
