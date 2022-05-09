namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        return String.IsNullOrEmpty(numbers) ? 0 : 1;
    }
}