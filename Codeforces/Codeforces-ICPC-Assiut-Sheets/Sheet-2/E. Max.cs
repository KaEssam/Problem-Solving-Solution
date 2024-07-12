using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int maxNumber = numbers[0];

        for (int i = 1; i < N; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        Console.WriteLine(maxNumber);
    }
}
