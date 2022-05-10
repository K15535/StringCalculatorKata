using TechTalk.SpecFlow;
using Xunit;

namespace StringCalculatorKata.Tests.Steps;

[Binding]
public class NumberStep
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public int Result { get; set; }

    [Given(@"the first number is (.*)")]
    public void GivenTheFirstNumberIs(int firstNumber)
    {
        FirstNumber = firstNumber;
    }

    [Given(@"the second number is (.*)")]
    public void GivenTheSecondNumberIs(int secondNumber)
    {
        SecondNumber = secondNumber;
    }

    [When(@"the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        Result = FirstNumber + SecondNumber;
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int expected)
    {
        Assert.Equal(expected, Result);
    }
}