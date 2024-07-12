using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int years = N / 365;
        int remainingDaysAfterYears = N % 365;
        int months = remainingDaysAfterYears / 30;
        int days = remainingDaysAfterYears % 30;

        Console.WriteLine($"{years} years");
        Console.WriteLine($"{months} months");
        Console.WriteLine($"{days} days");
    }
}
