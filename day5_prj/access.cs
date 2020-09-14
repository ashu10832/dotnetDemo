using System;

namespace p1{

    public class Access
    {
        private void f1(){
            System.Console.WriteLine("I am in f1");
        }

        internal void f2(){
            System.Console.WriteLine("I am in f2");
        }

        protected void f3(){
            System.Console.WriteLine("I am in f3");
        }

        internal protected void f4(){
            System.Console.WriteLine("I am in f4");
        }

        public void f5(){
            System.Console.WriteLine("I am in f5");
        }








        
    }






}