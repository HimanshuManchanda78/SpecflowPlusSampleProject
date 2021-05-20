using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using System.Diagnostics;
using System.IO;

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
            String currentDirectory = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(currentDirectory, @"..\"));
            var webDriver = new ChromeDriver(@newPath); 
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
