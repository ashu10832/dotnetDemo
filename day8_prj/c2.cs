using System;

namespace p4{

    public delegate int d1(int a,int b);
    public delegate int d2(int a,int b);
    public delegate int d3(int a,int b);

    class DelegateDemo
    {
        public int f3(int x,int y){
            System.Console.WriteLine("This is f3");
            return x+y;
        }

        public int f4(int x,int y){
            System.Console.WriteLine("This is f4");
            return x-y;
        }
    }








}