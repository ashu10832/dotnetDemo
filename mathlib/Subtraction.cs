using System;

namespace FirstLib
{
    public class Subtraction : Arithematic
    {

        public Subtraction() : base()
        {

        }
        public Subtraction(double a, double b) : base(a, b)
        {

        }

        public override void calculate()
        {
            this.c = this.a - this.b;
        }
    }
}
