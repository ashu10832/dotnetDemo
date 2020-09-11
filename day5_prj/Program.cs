using System;

namespace day5_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            // Formatted output
            System.Console.WriteLine("Sum of {0} and {1} is {2}",a,b,c);
        }
    }
}
