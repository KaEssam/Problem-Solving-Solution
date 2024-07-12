using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            int result = N * i;
            Console.WriteLine($"{N} * {i} = {result}");
        }
    }
}
