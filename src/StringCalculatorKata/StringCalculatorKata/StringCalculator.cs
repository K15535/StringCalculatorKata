namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        string delimiter = ",";

        if (string.IsNullOrEmpty(numbers))
            return 0;

        if (!numbers.Contains(delimiter) && !numbers.Contains("\n"))
            return int.Parse(numbers);

        List<string>? lines = null;
        if (numbers.Contains("\n"))
            lines = numbers.Split('\n').ToList();

        if (lines != null && lines.Any())
        {
            int sum = 0;
            
            foreach (string line in lines)
            {
                if (line.StartsWith("//"))
                    delimiter = line.Substring(2);
                else
                    sum += GetSumFromString(line, delimiter);
            }

            return sum;
        }
        
        return GetSumFromString(numbers, delimiter);
    }

    private static int GetSumFromString(string line, string delimiter)
    {
        string[] splittedNumbers = line.Split(delimiter);

        if (splittedNumbers.Length > 0)
        {
            int sum = 0;

            foreach (string number in splittedNumbers)
            {
                sum += int.Parse(number);
            }

            return sum;
        }

        return int.Parse(line);
    }
}