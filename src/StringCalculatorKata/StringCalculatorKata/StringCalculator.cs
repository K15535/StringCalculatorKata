namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        if (numbers.Contains(','))
        {
            string[] splittedNumbers = numbers.Split(',');

            if (splittedNumbers.Length == 2)
                return int.Parse(splittedNumbers[0]) + int.Parse(splittedNumbers[1]);
        }

        return String.IsNullOrEmpty(numbers) ? 0 : int.Parse(numbers);
    }
}