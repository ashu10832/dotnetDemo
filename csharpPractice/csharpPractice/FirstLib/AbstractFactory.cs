using System;
namespace FirstLib
{
    public interface Maths
    {
        void read();
        void calculate();
        void display();
    }

    abstract class Algebra : Maths
    {
        public void calculate()
        {

        }

        public void display()
        {

        }

        public void read()
        {

        }
    }


    public class MathsAbstractFactory
    {
        public static MathsFactory getAbstractFactory(int ch)
        {
             switch (ch)
            {
                case 1:
                    return new ArithematicFactory();

                // case 2:
                //     return new Subtraction();

                default: return null;
            }
        }
    }
}