using System;
 
class SummationFrom
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        int n = int.Parse(input);
 
        long sum =(long) n*(n+1)/2;
 
        Console.WriteLine(sum);
    }
}
