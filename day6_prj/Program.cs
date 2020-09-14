using System;
using p2;

namespace day6_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            methodDemo obj = new methodDemo();
            int k = 10;
            obj.f1(k);
            System.Console.WriteLine(k);
            obj.f2(ref k);
            System.Console.WriteLine(k);
            obj.f3(out k);
            System.Console.WriteLine(k);
            obj.f5(in k);
        }
    }
}
