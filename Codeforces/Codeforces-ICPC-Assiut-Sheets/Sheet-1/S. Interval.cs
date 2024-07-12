using System;

class Program
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        
         if (X >= 0 && X <= 25)
        {
            Console.WriteLine("Interval [0,25]");
        }
        else if (X > 25 && X <= 50)
        {
            Console.WriteLine("Interval (25,50]");
        }
        else if (X > 50 && X <= 75)
        {
            Console.WriteLine("Interval (50,75]");
        }
        else if (X > 75 && X <= 100)
        {
            Console.WriteLine("Interval (75,100]");
        }
        else
        {
            Console.WriteLine("Out of Intervals");
        }
    }
}
