using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        
        long A = long.Parse(input[0]);
        long B = long.Parse(input[1]);
        long C = long.Parse(input[2]);
        long D = long.Parse(input[3]);

        long productModulo100 = (A % 100) * (B % 100) % 100;
        productModulo100 = (productModulo100 * (C % 100)) % 100;
        productModulo100 = (productModulo100 * (D % 100)) % 100;

        Console.WriteLine(productModulo100.ToString("D2"));
    }
}
