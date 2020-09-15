using System;

namespace FirstLib
{
    public class Multiplication : Arithematic
    {

       public Multiplication() : base()
        {

        }
        public Multiplication(double a, double b) : base(a, b)
        {

        }


        public override void calculate()
        {
            this.c = this.a * this.b;
        }
    }
}
