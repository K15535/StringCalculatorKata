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
    [InlineData("0")]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("3")]
    public void Add_Should_Return_Single_Number(string numbers)
    {
        var actual = StringCalculator.Add(numbers);

        Assert.Equal(numbers, actual.ToString());
    }

    [Fact]
    public void Add_Should_AddTwoNumbers()
    {
        var actual = StringCalculator.Add("1,2");

        Assert.Equal(3, actual);
    }

    [Fact]
    public void Add_Should_Return_4()
    {
        var actual = StringCalculator.Add("2,2");

        Assert.Equal(4, actual);
    }

    [Fact]
    public void Add_Should_AddMultipleNumbers()
    {
        var actual = StringCalculator.Add("2,2,2");

        Assert.Equal(6, actual);
    }

    [Fact]
    public void AddMultipleNumbers_Should_Return_Sum()
    {
        var actual = StringCalculator.Add("2,2,3");

        Assert.Equal(7, actual);
    }

    [Fact]
    public void AddMultipleNumbersWithCarriageReturn_Should_Return_Sum()
    {
        var actual = StringCalculator.Add("2\n2,3");

        Assert.Equal(7, actual);
    }

    [Fact]
    public void AddMultipleNumbersWithCarriageReturn_Should_Return_Sum_Bis()
    {
        var actual = StringCalculator.Add("3\n2,3");

        Assert.Equal(8, actual);
    }

    [Fact]
    public void AddMultipleNumbersByChangingDelimiter_Should_Return_Sum()
    {
        var actual = StringCalculator.Add("//|\n3\n2|3");

        Assert.Equal(8, actual);
    }

    [Fact]
    public void AddMultipleNumbersByChangingDelimiter_Should_Return_Sum_Bis()
    {
        var actual = StringCalculator.Add("//|\n3\n3|3");

        Assert.Equal(9, actual);
    }
}
