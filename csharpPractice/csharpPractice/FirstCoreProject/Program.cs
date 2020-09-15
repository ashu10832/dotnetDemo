using System;
using FirstLib;

namespace FirstCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Arithematic a = new Addition(11, 10);
            // a.calculate();
            // a.display();



            // Arithematic[] a = new Arithematic[4];
            // a[0] = new Addition();
            // a[1] = new Subtraction();
            // a[2] = new Multiplication();
            // a[3] = new Division();



            // System.Console.WriteLine("Enter Choice: ");
            // int ch = Convert.ToInt32(Console.ReadLine());
            // a[ch - 1].read();
            // a[ch - 1].calculate();
            // a[ch - 1].display();



            // System.Console.WriteLine("Enter Choice: ");
            // int ch = Convert.ToInt32(Console.ReadLine());
            // Arithematic a = ArithematicAbstractFactory.getFactory(ch);
            // a.read();
            // a.calculate();
            // a.display(); 



            // System.Console.WriteLine("Enter Choice: ");
            // int ch = Convert.ToInt32(Console.ReadLine());
            // Arithematic a = ArithematicFactory.getFactory(ch, 11, 12);
            // a.calculate();
            // a.display();


            Maths a = MathsAbstractFactory.getAbstractFactory(1).getFactory(1, 10, 20);
            a.calculate();
            a.display();
        }
    }
}
