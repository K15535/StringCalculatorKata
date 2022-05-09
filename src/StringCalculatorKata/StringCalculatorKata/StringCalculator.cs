namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            if (int.TryParse(number.ToString(), out var num))
            {
                sum += num;
            }
        }

        return sum;
    }
}