using System;

namespace FirstLib
{
    public class Division : Arithematic
    {

        public Division() : base()
        {

        }
        public Division(double a, double b) : base(a, b)
        {

        }

        public override void calculate()
        {
            this.c = this.a / this.b;
        }
    }
}
