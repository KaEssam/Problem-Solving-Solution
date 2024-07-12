class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        string[] tokens = input.Split(' ');
        
        int num1 = int.Parse(tokens[0]); // int
        long num2 = long.Parse(tokens[1]); // long long
        char letter = char.Parse(tokens[2]); // char
        float num3 = float.Parse(tokens[3]); // float
        double num4 = double.Parse(tokens[4]); // double
        
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(letter);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
    }
}
