using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        
        double result = (double)A / B;
        
        int floorResult = (int)Math.Floor(result);
        int ceilResult = (int)Math.Ceiling(result);
        int roundResult = (int)Math.Round(result, MidpointRounding.AwayFromZero);
        
        Console.WriteLine($"floor {A} / {B} = {floorResult}");
        Console.WriteLine($"ceil {A} / {B} = {ceilResult}");
        Console.WriteLine($"round {A} / {B} = {roundResult}");
    }
}
