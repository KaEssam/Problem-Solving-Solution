using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long k = long.Parse(input[1]);
        long a = long.Parse(input[2]);

        long intermediateResult = n * k;

        if (intermediateResult % a != 0)
        {
            Console.WriteLine("double");
            return;
        }

        long finalResult = intermediateResult / a;

        if (finalResult >= int.MinValue && finalResult <= int.MaxValue)
        {
            Console.WriteLine("int");
        }
        else
        {
            Console.WriteLine("long long");
        }
    }
}
