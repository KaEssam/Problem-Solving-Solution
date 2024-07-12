using System;
 
class DigitsSummation
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
 
        long M = long.Parse(parts[0]);
        long N = long.Parse(parts[1]);
 
        long lastDigitM = M % 10;
        long lastDigitN = N % 10;
 
        long summation = lastDigitM + lastDigitN;
 
        Console.WriteLine(summation);
    }
}
