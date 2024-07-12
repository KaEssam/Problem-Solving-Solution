using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        bool hasEvenNumbers = false;

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine(i);
                hasEvenNumbers = true;
            }
        }

        if (!hasEvenNumbers)
        {
            Console.WriteLine("-1");
        }
    }
}
