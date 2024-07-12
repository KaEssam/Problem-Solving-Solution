using System;

class Program
{
    static void Main()
    {
        char X = Console.ReadLine()[0];
        
        if (X >= 'a' && X <= 'z')
        {
            char result = (char)(X - 32);
            Console.WriteLine(result);
        }
        else if (X >= 'A' && X <= 'Z')
        {
            char result = (char)(X + 32);
            Console.WriteLine(result);
        }
    }
}
