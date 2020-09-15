using System;
namespace FirstLib
{
    public abstract class Arithematic : Maths
    {

        protected double a;
        protected double b;
        protected double c;

        public Arithematic()
        {
            this.a = this.b = this.c = 0.0;
        }

        public Arithematic(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.c = 0.0;
        }

        public abstract void calculate();

        public void read()
        {
            System.Console.WriteLine("Enter the two numbers : ");
            this.a = Convert.ToDouble(System.Console.ReadLine());
            this.b = Convert.ToDouble(System.Console.ReadLine());
        }

        public virtual void display()
        {
            System.Console.WriteLine("Result: {0}", this.c);
        }

    }
}