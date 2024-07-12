using System;

class Program
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        
        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Multiples");
        }
        else
        {
            Console.WriteLine("No Multiples");
        }
    }
}
