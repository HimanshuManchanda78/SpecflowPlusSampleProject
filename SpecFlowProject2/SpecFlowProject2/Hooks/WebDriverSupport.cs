using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using System.Diagnostics;

namespace SpecFlowProject2.Hooks
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        public IWebDriver getDriver()
        {
            return objectContainer.Resolve<IWebDriver>(); 
        }
        [BeforeScenario]
        public void InitializeWebDriver()
        {            
            var webDriver = new ChromeDriver(@"C:\Users\himan\Himanshu\Projects\SpecFlowProject2\SpecFlowProject2\bin\Debug\netcoreapp3.1"); 
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);          
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            objectContainer.Resolve<IWebDriver>().Quit();
        }
        static string backgroundsetting;
        
    }
}
