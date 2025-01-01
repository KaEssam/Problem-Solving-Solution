using System;
 
class Program
{
    static void Main()
    {
        int input =int.Parse(Console.ReadLine());
        string result = "";
 
        for (int i = 1; i <= input; i++)
        {
            if (i % 2 == 1)
            {
                result += "I hate";
            }
            else
            {
                result += "I love";
            }
 
            if (i < input)
            {
                result += " that ";
            }
            else
            {
                result += " it";
            }
        }
        Console.WriteLine(result);
    }
}
