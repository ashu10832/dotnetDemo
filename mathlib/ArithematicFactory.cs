using System;
namespace FirstLib
{

    public interface MathsFactory
    {
        Maths getFactory(int ch);

        Maths getFactory(int ch, double a, double b);
    }
    public class ArithematicFactory : MathsFactory
    {
        public ArithematicFactory()
        {
        }

        public Maths getFactory(int ch)
        {
            switch (ch)
            {
                case 1:
                    return new Addition();

                case 2:
                    return new Subtraction();

                case 3:
                    return new Multiplication();

                case 4:
                    return new Division();

                default: return null;
            }
        }

        public Maths getFactory(int ch, double a, double b)
        {
            switch (ch)
            {
                case 1:
                    return new Addition(a, b);

                case 2:
                    return new Subtraction(a, b);

                case 3:
                    return new Multiplication(a, b);

                case 4:
                    return new Division(a, b);

                default: return null;
            }
        }


    }
}