using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        char firstDigitChar = input[0];
        
        int firstDigit = firstDigitChar - '0'; 
        
        if (firstDigit % 2 == 0)
        {
            Console.WriteLine("EVEN");
        }
        else
        {
            Console.WriteLine("ODD");
        }
    }
}
