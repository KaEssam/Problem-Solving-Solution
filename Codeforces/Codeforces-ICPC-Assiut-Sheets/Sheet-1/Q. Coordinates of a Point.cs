using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split();

        double X = double.Parse(parts[0], CultureInfo.InvariantCulture);
        double Y = double.Parse(parts[1], CultureInfo.InvariantCulture);

        if (X == 0 && Y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (X == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (Y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (X > 0 && Y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (X < 0 && Y > 0)
        {
            Console.WriteLine("Q2");
        }
        else if (X < 0 && Y < 0)
        {
            Console.WriteLine("Q3");
        }
        else if (X > 0 && Y < 0)
        {
            Console.WriteLine("Q4");
        }
    }
}
