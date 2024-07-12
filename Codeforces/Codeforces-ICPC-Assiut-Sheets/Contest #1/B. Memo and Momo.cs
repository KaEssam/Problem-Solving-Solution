using System;
using System.Numerics;
 
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        BigInteger a = BigInteger.Parse(input[0]);
        BigInteger b = BigInteger.Parse(input[1]);
        BigInteger k = BigInteger.Parse(input[2]);
        
        bool aDivideByK = (a%k ==0);
        bool bDivideByK = (b%k ==0);

        if(aDivideByK && bDivideByK){
            Console.WriteLine("Both");
        }else if(aDivideByK){
            Console.WriteLine("Memo");
        }else if(bDivideByK){
            Console.WriteLine("Momo");
        }else{
            Console.WriteLine("No One");
        }
    }
}   
