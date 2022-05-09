using System;
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

    [Theory]
    [InlineData("")]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("3")]
    public void Add_Should_Return_Single_Number(string numbers)
    {
        var actual = StringCalculator.Add(numbers);

        Assert.Equal(numbers, actual.ToString());
    }
}
