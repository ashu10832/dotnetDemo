namespace FirstLib
{
    public class Addition : Arithematic
    {

        public Addition() : base()
        {

        }
        public Addition(double a, double b) : base(a, b)
        {

        }

        public override void calculate()
        {
            this.c = this.a + this.b;
        }

        public sealed override void display()
        {
            System.Console.WriteLine("Addition");
            base.display();
        }
    }
}
