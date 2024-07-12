using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine());

            long factorial = Factorial(N);

            Console.WriteLine(factorial);
        }
    }
}
