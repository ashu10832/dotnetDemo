﻿using System;
using Humanizer;

namespace day5_prj
{
    class Program
    {

        int a,b,c;
        static void Main(string[] args)
        {   

            /*
              convert number into words  
            */
            // var ob = new Program();
            // System.Console.WriteLine("Enter two numbers");
            // ob.a = Convert.ToInt32(Console.ReadLine());
            // ob.b = Convert.ToInt32(Console.ReadLine());
            // ob.c = ob.a + ob.b;
            // // Formatted output
            // System.Console.WriteLine("Sum of {0} and {1} is {2}",ob.a,ob.b,ob.c);

            Console.Write("Enter amount:");
            int amt = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine(amt.ToWords());
            System.Console.WriteLine("Car".Pluralize());


        }



    }
}
