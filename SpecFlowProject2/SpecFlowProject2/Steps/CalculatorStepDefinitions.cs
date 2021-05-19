using BoDi;
using SpecFlowProject2.Hooks;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

     //   private readonly ScenarioContext _scenarioContext;
        private readonly WebDriverSupport _WebDriverSupport;
        public CalculatorStepDefinitions(WebDriverSupport WebDriverSupports)
        {
            _WebDriverSupport = WebDriverSupports;          
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _WebDriverSupport.getDriver().Url = "https://www.hindustantimes.com/";
             
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           // Thread.Sleep(5000);
           // _WebDriverSupport.getDriver().Quit(); 
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

           // _scenarioContext.Pending();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            //_scenarioContext.Pending();
        }
    }
}
