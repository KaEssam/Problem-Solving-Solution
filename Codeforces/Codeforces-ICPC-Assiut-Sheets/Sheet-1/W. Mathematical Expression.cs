using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        
        int A = int.Parse(input[0]);
        char S = char.Parse(input[1]);
        int B = int.Parse(input[2]);
        char Q = char.Parse(input[3]);
        int C = int.Parse(input[4]);
        
        int computedResult = 0;
        
        if (S == '+')
        {
            computedResult = A + B;
        }
        else if (S == '-')
        {
            computedResult = A - B;
        }
        else if (S == '*')
        {
            computedResult = A * B;
        }
        
        if (computedResult == C)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine(computedResult);
        }
    }
}
