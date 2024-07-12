using System;

class Program
{
    static void Main()
    {
        char inputChar = Console.ReadLine()[0];
        
        char nextChar;
        if (inputChar == 'z')
        {
            nextChar = 'a';
        }
        else
        {
            nextChar = (char)(inputChar + 1);
        }
        Console.WriteLine(nextChar);
    }
}
