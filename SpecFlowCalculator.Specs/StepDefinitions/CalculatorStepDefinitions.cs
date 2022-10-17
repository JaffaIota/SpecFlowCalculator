using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSub()
        {
            _result = _calculator.Sub();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Mult();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenYouAdd(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Add();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation \- is done to the number (.*)")]
        public void WhenYouSubtract(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Sub();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation \* is done to the number (.*)")]
        public void WhenYouMultiply(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Mult();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation \/ is done to the number (.*)")]
        public void WhenYouDivide(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Divide();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation \% is done to the number (.*)")]
        public void WhenYouMod(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Mod();
            _calculator.FirstNumber = _result;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

    }
}