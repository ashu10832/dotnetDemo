using System;
using FirstLib;

namespace factoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths a = MathsAbstractFactory.getAbstractFactory(1).getFactory(1, 10, 20);
            a.calculate();
            a.display();
        }
    }
}
