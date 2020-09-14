using System;

namespace p3{
    abstract class c1{

        public void f1(){
            System.Console.WriteLine("i am in f1");

        }

        virtual public void f2(){
            System.Console.WriteLine("This is f2 of c1");
        }

        abstract public void f3();

        //abstract public void f3();

    }

    class c2 : c1 {

        override public void f2(){
            base.f2();
            System.Console.WriteLine("This is f2 of c2");
        }

        override public void f3(){
            System.Console.WriteLine("I am in f3");
        }
    }




}