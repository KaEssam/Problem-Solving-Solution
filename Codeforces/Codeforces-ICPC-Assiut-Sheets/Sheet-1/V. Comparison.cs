using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        
        int A = int.Parse(input[0]);
        string S = input[1];
        int B = int.Parse(input[2]);
        
        bool result = false;
        if (S == "<")
        {
            result = A < B;
        }
        else if (S == ">")
        {
            result = A > B;
        }
        else if (S == "=")
        {
            result = A == B;
        }

        if (result)
        {
            Console.WriteLine("Right");
        }
        else
        {
            Console.WriteLine("Wrong");
        }
    }
}
