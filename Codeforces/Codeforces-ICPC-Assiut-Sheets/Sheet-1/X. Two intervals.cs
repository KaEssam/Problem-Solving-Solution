using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { '[', ']', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int l1 = int.Parse(input[0]);
        int r1 = int.Parse(input[1]);
        int l2 = int.Parse(input[2]);
        int r2 = int.Parse(input[3]);

        int intersectionStart = Math.Max(l1, l2);
        int intersectionEnd = Math.Min(r1, r2);

        if (intersectionStart <= intersectionEnd)
        {
            Console.WriteLine($"{intersectionStart} {intersectionEnd}");
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}
