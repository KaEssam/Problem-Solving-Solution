using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int evenCount = 0;
        int oddCount = 0;
        int positiveCount = 0;
        int negativeCount = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }

            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Even: " + evenCount);
        Console.WriteLine("Odd: " + oddCount);
        Console.WriteLine("Positive: " + positiveCount);
        Console.WriteLine("Negative: " + negativeCount);
    }
}
