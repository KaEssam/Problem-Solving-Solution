using System;

class Program
{
    static bool IsPrime(int X)
    {
        if (X <= 1)
        {
            return false;
        }
        
        if (X == 2)
        {
            return true;
        }
        
        if (X % 2 == 0)
        {
            return false;
        }
        
        for (int i = 3; i * i <= X; i += 2)
        {
            if (X % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }

    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        
        if (IsPrime(X))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
