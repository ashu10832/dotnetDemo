using System;
using p4;

namespace day8_prj
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Program obj = new Program();
            // obj.f1();
            // obj.f2();

            // string s = "this is a string";
            // System.Console.WriteLine(s.toProperCase()); 

            // DelegateDemo demo = new DelegateDemo();
            // d1 n1 = new d1(demo.f3);
            // d2 n2 = new d2(demo.f4);

            // d1 n3 = n1;
            // d1 n4 = new d1(demo.f4);

            // n3 += n4;

            // System.Console.WriteLine(n3(5,6));

            // System.Console.WriteLine(n1(2,3));
            // System.Console.WriteLine(n2(10,5));

            // //d3 n3 = n1;
            
            // //n1 += n1;
            // n1 += n2;

            // n1(5,6);

            // d1 n3 = n1;
            // d1 n4 = ob.f4;
            // n3 += n4;
            // System.Console.WriteLine(n3(2,3));



            // ExceptionDemo exceptionDemo = new ExceptionDemo();
            //     exceptionDemo.division(2,0);

            // try
            // {
            //     exceptionDemo.division(2,0);
            //     exceptionDemo.division(2,2);
            // }
            // catch (System.Exception e)
            // {
            //     System.Console.WriteLine("Handled exception in main " + e.Message);
            // }
            


            try
            {
                AEDemo obj = new AEDemo();
                obj.updateMarks(20);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            






        }

        public void f1(){
            System.Console.WriteLine("I am in f1");
        }
    }
}



