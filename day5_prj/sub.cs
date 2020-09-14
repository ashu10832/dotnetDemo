using System;

namespace p1{
    public class Subtract
    {   
        internal int a,b,c;
        public Subtract(){
            a = 0;
            b = 0;
        }

        public Subtract(int a,int b){
            this.a = a;
            this.b = b;
        }

        public Subtract(Subtract s1){
            this.a = s1.a;
            this.b = s1.b;
            this.c = s1.c;
        }

        public void cal(){
            c = a - b;
        }

        public void display(){
            System.Console.WriteLine("{0}, {1}, {2} ",a,b,c);
        }


        
    }





}