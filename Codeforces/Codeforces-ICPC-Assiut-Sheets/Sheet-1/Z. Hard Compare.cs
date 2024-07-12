using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        long A = long.Parse(input[0]);
        long B = long.Parse(input[1]);
        long C = long.Parse(input[2]);
        long D = long.Parse(input[3]);

        double logA = Math.Log(A);
        double logC = Math.Log(C);

        double lhs = B * logA;
        double rhs = D * logC;

        if (lhs > rhs)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
