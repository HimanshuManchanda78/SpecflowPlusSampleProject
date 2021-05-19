using SpecFlowProject2.Hooks;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class LaunchGoogleSteps
    {
        private readonly WebDriverSupport _WebDriverSupport;
        public LaunchGoogleSteps(WebDriverSupport WebDriverSupports)
        {
            _WebDriverSupport = WebDriverSupports;
        }
        
        [Given(@"User launches google\.com")]
        public void GivenUserLaunchesGoogle_Com()
        {
            _WebDriverSupport.getDriver().Url = "http://www.google.com";
        }
        
        [Then(@"he should be able to launch")]
        public void ThenHeShouldBeAbleToLaunch()
        {
           // Thread.Sleep(5000);
           // _WebDriverSupport.getDriver().Quit(); 
        }
    }
}
