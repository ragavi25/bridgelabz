using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumFundoo.Pages
{
    class DashboradPage : BasePage
    {
        public DashboradPage(IWebDriver currentDriver)
        {
            PageFactory.InitElements(currentDriver, this);
            
        }


    }
}
