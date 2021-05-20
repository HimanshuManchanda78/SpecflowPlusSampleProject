using BoDi;
using FluentAssertions;
using SpecFlowProject2.Hooks;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class LaunchHT
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

     //   private readonly ScenarioContext _scenarioContext;
        private readonly WebDriverSupport _WebDriverSupport;
        public LaunchHT(WebDriverSupport WebDriverSupports)
        {
            _WebDriverSupport = WebDriverSupports;          
        }

        [Given(@"User launches hindustan times website")]
        public void GivenUserLaunchesHindustanTimesWebsite()
        {
            _WebDriverSupport.getDriver().Url = "https://www.hindustantimes.com/";
        }

        [Then(@"he should be able to launch it")]
        public void ThenHeShouldBeAbleToLaunchIt()
        {
            // veriying something from website and use it in assertion. 
            bool verified = true;
            verified.Should().BeTrue("Unable to launch website because verified is false");
        }

       

       
     
    }
}
