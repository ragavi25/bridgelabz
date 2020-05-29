using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTDD.Page;
using System;
using TechTalk.SpecFlow;

namespace SeleniumTDD
{
    [Binding]
    public class FundooAppSteps
    {
        IWebDriver currentDriver = new ChromeDriver();
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void Extentstart()
        {
            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\vanchi\source\repos\seleniumtdd\Extentreports\FundooAppSteps.html");
            extent.AttachReporter(htmlreporter);
            
        }
        [OneTimeTearDown]
        public void Extentclose()
        {
            extent.Flush();
        }
        ExtentTest test = null;
       [Given(@"I have navigated to my application")]
        public void GivenIHaveNavigatedToMyApplication()
        {
          // test= extent.CreateTest("GivenIHaveNavigatedToMyApplication").Info("Test Start");
            currentDriver.Manage().Window.Maximize();
            //test.Log(Status.Info,"Chrome Browser Lauched");
            // Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            currentDriver.Navigate().GoToUrl("http://localhost:4200/login");
            //test.Log(Status.Pass, "GivenIHaveNavigatedToMyApplication passed");
        }

        [Given(@"I type the (.*)and(.*)")]
        public void GivenITypeTheAnd(string p0, string p1)
        {
            login loginpage = new login(currentDriver);
            ///ScenarioContext.Current.Pending();
            loginpage.Login(p0, p1);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            login loginpage = new login(currentDriver);
            PropertyCollection.CurrentPage = loginpage.Clicklogin();
           // currentDriver.Quit();
        }
        [Given(@"I have navigated to Register application")]
        public void GivenIHaveNavigatedToRegisterApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/register");
        }

        [Given(@"I have fill the details")]
        public void GivenIHaveFillTheDetails()
        {
            RegisterPage register = new RegisterPage(currentDriver);
            register.Register();
        }

        [When(@"I click Register button")]
        public void WhenIClickRegisterButton()
        {
            RegisterPage register = new RegisterPage(currentDriver);
             register.ClickRegister();
            // currentDriver.Quit();
           // test.Log(Status.Pass, "GivenIHaveNavigatedToMyApplication passed");
        }

        [Then(@"I should see the login page")]
        public void ThenIShouldSeeTheLoginPage()
        {
           
        }
        [Given(@"I have put (.*) and (.*)")]
        public void GivenIHavePutAnd(string p0, string p1)
        {
            AddNotePage addnote = new AddNotePage(currentDriver);
            addnote.Addnote(p0, p1);
        }
        [When(@"I click close button")]
        public void WhenIClickCloseButton()
        {
            AddNotePage addnote = new AddNotePage(currentDriver);
            PropertyCollection.CurrentPage = addnote.ClickClose();
            //currentDriver.Quit();
        }

        [Given(@"I have navigated to displaynote Application")]
        public void GivenIHaveNavigatedToDisplaynoteApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo/getnote?page=notes&view=row");
            
        }

        [Given(@"I have update the (.*) and (.*)")]
        public void GivenIHaveUpdateTheAnd(string p0, string p1)
        {
            UpdateNotePage updatenotePage = new UpdateNotePage(currentDriver);
            updatenotePage.Updatenote(p0, p1);
        }

        [Given(@"I have navigate a Dashborad page")]
        public void GivenIHaveNavigateADashboradPage()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo");
        }

        [Given(@"I have click the Bin")]
        public void GivenIHaveClickTheBin()
        {
            BinPage bin = new BinPage(currentDriver);
            bin.clickbin();
        }

        [When(@"I click updateClose button")]
        public void WhenIClickUpdateCloseButton()
        {
            UpdateNotePage updatenotePage = new UpdateNotePage(currentDriver);
            updatenotePage.ClickClose();
           // currentDriver.Quit();
        }

        [When(@"I have click the Deleteall")]
        public void WhenIHaveClickTheDeleteall()
        {
            BinPage bin = new BinPage(currentDriver);
            bin.delete();
        }

        [Then(@"I have navigate Bin")]
        public void ThenIHaveNavigateBin()
        {
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo/Bin?page=Bin&view=row");
        }

        [Then(@"I have click the Restore")]
        public void ThenIHaveClickTheRestore()
        {
            BinPage bin = new BinPage(currentDriver);
            bin.restor();
        }
        [Given(@"I have navigated to AdminRegister application")]
        public void GivenIHaveNavigatedToAdminRegisterApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/Adminregister");
        }

        [Given(@"I have navigated to Adminlogin application")]
        public void GivenIHaveNavigatedToAdminloginApplication()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/Adminlogin");
        }

        [Given(@"I have take data")]
        public void GivenIHaveTakeData()
        {
            AdminRegisterPage admin = new AdminRegisterPage(currentDriver);
            admin.ClickAdminRegister();
        }


        [When(@"I click AdminRegister button")]
        public void WhenIClickAdminRegisterButton()
        {
            AdminRegisterPage admin = new AdminRegisterPage(currentDriver);
            admin.Register();
        }
        [Given(@"I have take data(.*)and(.*)")]
        public void GivenIHaveTakeDataand(string p0, string p1)
        {
            AdminloginPage adminloginpage = new AdminloginPage(currentDriver);
            adminloginpage.AdminLogin(p0,p1);
        }

        [When(@"I click Adminlogin button")]
        public void WhenIClickAdminloginButton()
        {
            AdminloginPage adminloginpage = new AdminloginPage(currentDriver);
            adminloginpage.Clicklogin();
           // test.Log(Status.Pass, "GivenIHaveNavigatedToMyApplication passed");
        }
        [Given(@"I have take a ScreenShot")]
        public void GivenIHaveTakeAScreenShot()
        {
            currentDriver.Manage().Window.Maximize();
            currentDriver.Navigate().GoToUrl("http://localhost:4200/fundoo/getnote?page=notes&view=row");
            Screenshot screenshot = ((ITakesScreenshot)currentDriver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\vanchi\Desktop\screenshots/sample.png", ScreenshotImageFormat.Png);
        }
    }

}
