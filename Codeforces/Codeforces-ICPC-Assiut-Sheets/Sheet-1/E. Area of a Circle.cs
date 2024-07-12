using System;
 
class CircleAreaCalculator
{
    static void Main()
    {
        const double PI = 3.141592653;
    
        string input = Console.ReadLine();
        
        double R = double.Parse(input);
        
        double area = PI * R * R;
        
        Console.WriteLine(area.ToString("F9"));
    }
}
