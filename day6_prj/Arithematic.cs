using System;


namespace arithematic{

    abstract class Arithematic
    {

        protected int a;
        protected int b;
        protected int c;

        public abstract void display();
        
    }

    class Addition : Arithematic
    {

        override public void display(){
            System.Console.WriteLine("Addition");
        }   
    }
    class Division : Arithematic
    {

        override public void display(){
            System.Console.WriteLine("Division");
        }
        
    }
    
    class Subtraction : Arithematic
    {

        override public void display(){
            System.Console.WriteLine("Subtraction");
        }
        
    }
    
    class Multiplication : Arithematic
    {

        override public void display(){
            System.Console.WriteLine("Multiplication");
        }
        
    }





}