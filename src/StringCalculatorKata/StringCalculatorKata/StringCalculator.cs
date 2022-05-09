namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        numbers = numbers.Replace("\n", ",");

        if (numbers.Contains(','))
        {
            string[] splittedNumbers = numbers.Split(',');

            if (splittedNumbers.Length > 0)
            {
                int sum = 0;

                foreach (string number in splittedNumbers)
                {
                    sum += int.Parse(number);
                }

                return sum;
            }
        }

        return String.IsNullOrEmpty(numbers) ? 0 : int.Parse(numbers);
    }
}