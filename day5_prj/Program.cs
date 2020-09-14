using System;
using Humanizer;
using p1;

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

            // Console.Write("Enter amount:");
            // int amt = Convert.ToInt32(Console.ReadLine());

            // System.Console.WriteLine(amt.ToWords());
            // System.Console.WriteLine("Car".Pluralize());

            // Accept a number a print mathematical table

            // Console.Write("Enter number:");
            // int n = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i <= 10; i++)
            // {
            //      System.Console.WriteLine("{0}x{1}={2}",n,i,(n*i));
            // }

            // System.Console.WriteLine("{0} is minimum value {1} is maximum value",int.MinValue,int.MaxValue);
            // System.Console.WriteLine("{0} is the integer value",int.Parse("45"));
            // byte b1 = 10;

            // int a1 = b1; 
            // string s1 = String.Format("This is an example of implicit conversion {0} to {1} which is a integer type",b1,a1);
            // System.Console.WriteLine(s1);

            // String s2 = s1 + " ok";
            // System.Console.WriteLine(s2);

            // s2 = s1 + s2;
            // System.Console.WriteLine(s2);

            // System.Console.WriteLine(s2[5]);
            // {
            //     int x = 0;
            //     System.Console.WriteLine(x);
            //     Add ob = new Add();
            //     ob.read();
            //     ob.cal();
            //     ob.display();
            //     ob.dispose();

            //     Add ob2 = new Add(40,50);
            //     System.Console.WriteLine("{0} {1}",ob.num1,ob2.num1);
            //     System.Console.WriteLine("{0} {1}",Add.num3,Add.num3);
            // }


            // {
            //     Subtract ob = new Subtract(4,5);
            //     Subtract ob1 = new Subtract(ob);
            //     System.Console.WriteLine("{0} {1}",ob.a,ob1.a);



            // }

            Access obj = new Access();
            //obj.f1();
            //obj.f3();
            obj.f2();
            obj.f4();
            obj.f5();
           

            


            System.GC.Collect();
            
        }



    }
}
