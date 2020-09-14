using System;

namespace p2{

    class methodDemo{

        public void f1(int x){
            x++;
            System.Console.WriteLine(x);
        }

        public void f2(ref int x){
            x++;
            System.Console.WriteLine(x);
        }

        public void f3(out int x){
            x=10;
            System.Console.WriteLine(x);        
        }

        public static void f4(){
            System.Console.WriteLine("I am in f4");
        }

        public void f5(in int x){
            x=6;
            System.Console.WriteLine(x);
        }

        
    }

}