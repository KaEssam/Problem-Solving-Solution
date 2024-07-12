using System;
 
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int X = int.Parse(input[0]);
        double P = double.Parse(input[1]);
        
        double originalPrice = P / (1 - X / 100.0);
        
        string roundedPrice = originalPrice.ToString("F2");
        
        Console.WriteLine(roundedPrice);
    }
     
}   
