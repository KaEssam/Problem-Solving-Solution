using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int tens = N / 10;
        int units = N % 10;

        if (units == 0 || tens == 0 || (tens % units == 0 || units % tens == 0))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
