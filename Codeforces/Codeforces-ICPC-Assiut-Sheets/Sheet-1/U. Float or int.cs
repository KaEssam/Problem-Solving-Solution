using System;
 
class Program
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        
         if (N == (int)N)
        {
            Console.WriteLine($"int {N}");
        }
        else
        {
            int integerPart = (int)N;
            double decimalPart = N - integerPart;
            Console.WriteLine($"float {integerPart} {decimalPart:F3}"); 
        }
    }
}
