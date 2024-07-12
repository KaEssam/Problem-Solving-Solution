using System;
 
class Differnce
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        long A = long.Parse(parts[0]);
        long B = long.Parse(parts[1]);
        long C = long.Parse(parts[2]);
        long D = long.Parse(parts[3]);
        
        long Difference = (A * B) - (C * D);
        
        Console.WriteLine($"Difference = {Difference}");
 
    }
}
