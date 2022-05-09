using Xunit;

namespace StringCalculatorKata.Tests;

public class StringCalculatorTest
{
    [Fact]
    public void EmptyString()
    {
        var actual = StringCalculator.Add("");

        Assert.Equal(0, actual);
    }

    [Fact]
    public void OneNumberInString()
    {
        var actual = StringCalculator.Add("1");

        Assert.Equal(1, actual);
    }
}