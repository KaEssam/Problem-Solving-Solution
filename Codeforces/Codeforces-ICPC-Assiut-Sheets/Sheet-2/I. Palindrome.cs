using System;

class Program
{
    static void Main()
    {
        string N = Console.ReadLine();
        
        char[] reversedArray = N.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedString = new string(reversedArray);
        
        long reversedNumber = long.Parse(reversedString);
        
        bool isPalindrome = N == reversedString;
        
        Console.WriteLine(reversedNumber);
        
        if (isPalindrome)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
