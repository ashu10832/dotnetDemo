using System;
using Humanizer;

namespace p1{

    class Add
    {
        public int num1,num2;
        public static int num3;

        

        public Add(){
            num1 = 10;
            num2 = 20;
        }

        public Add(int num1,int num2){
            this.num1 = num1;
            this.num2 = num2;
        }

        ~Add(){
            System.Console.WriteLine("I am in destructor");
            dispose();
        }

        public void dispose(){
            num1 = 0;
            num2 = 0;
        }

        public void read(){
            System.Console.WriteLine("Enter two numbers:");
            this.num1 = Convert.ToInt32(Console.ReadLine());
            this.num2 = Convert.ToInt32(Console.ReadLine());
        }

        public void cal(){
            num3 = num1 + num2;
        }

        public void display(){
            System.Console.WriteLine("num1 = {0}, num2 = {1}, num3 = {2}",num1,num2,num3);
        }



    }

    class n1
    {
        public void f1(){
            Add ob = new Add();
        }
        
    }



}

