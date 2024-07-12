using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        
        int minValue = Math.Min(A, Math.Min(B, C));
        int maxValue = Math.Max(A, Math.Max(B, C));
        
        Console.WriteLine($"{minValue} {maxValue}");
    }
}
