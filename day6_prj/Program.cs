using System;
using p2;
using p3;
using arithematic;

namespace day6_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            // methodDemo obj = new methodDemo();
            // int k = 10;
            // obj.f1(k);
            // System.Console.WriteLine(k);
            // obj.f2(ref k);
            // System.Console.WriteLine(k);
            // obj.f3(out k);
            // System.Console.WriteLine(k);
            // // obj.f5(in k);

            // c1 ob = new c2();
            // ob.f3();
            // ob.f1();
            // ob.f2();

            Arithematic a = ArithematicAbstractFactory.getFactory(3);
            a.display();
        }
    }
}
