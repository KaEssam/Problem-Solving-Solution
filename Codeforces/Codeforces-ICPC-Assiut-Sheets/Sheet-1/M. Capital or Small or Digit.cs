using System;

class Program
{
    static void Main()
    {
        char X = Console.ReadLine()[0];
        
        if (X >= '0' && X <= '9')
        {
            Console.WriteLine("IS DIGIT");
        }
        else if ((X >= 'A' && X <= 'Z') || (X >= 'a' && X <= 'z'))
        {
            Console.WriteLine("ALPHA");
            if (X >= 'A' && X <= 'Z')
            {
                Console.WriteLine("IS CAPITAL");
            }
            else
            {
                Console.WriteLine("IS SMALL");
            }
        }
    }
}
