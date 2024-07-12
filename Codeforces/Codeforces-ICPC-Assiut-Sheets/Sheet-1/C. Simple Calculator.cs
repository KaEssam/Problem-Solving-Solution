using System;
 
class SimpleCalculator
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        long X = long.Parse(parts[0]);
        long Y = long.Parse(parts[1]);
        
 
        long sum = X + Y;
        long product = X * Y;
        long difference = X - Y;
        
        Console.WriteLine($"{X} + {Y} = {sum}");
        Console.WriteLine($"{X} * {Y} = {product}");
        Console.WriteLine($"{X} - {Y} = {difference}");
    }
}
