using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int operatorPos = -1;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            {
                operatorPos = i;
                break;
            }
        }

        int A = int.Parse(input.Substring(0, operatorPos));
        char S = input[operatorPos];
        int B = int.Parse(input.Substring(operatorPos + 1));

        switch (S)
        {
            case '+':
                Console.WriteLine(A + B);
                break;
            case '-':
                Console.WriteLine(A - B);
                break;
            case '*':
                Console.WriteLine(A * B);
                break;
            case '/':
                Console.WriteLine(A / B);
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
