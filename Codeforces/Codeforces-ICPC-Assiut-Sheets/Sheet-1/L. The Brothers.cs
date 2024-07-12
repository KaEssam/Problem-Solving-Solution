using System;

class Program
{
    static void Main()
    {
        string[] person1 = Console.ReadLine().Split();
        string firstName1 = person1[0];
        string secondName1 = person1[1];
        
        string[] person2 = Console.ReadLine().Split();
        string firstName2 = person2[0];
        string secondName2 = person2[1];
        
        if (secondName1 == secondName2)
        {
            Console.WriteLine("ARE Brothers");
        }
        else
        {
            Console.WriteLine("NOT");
        }
    }
}
