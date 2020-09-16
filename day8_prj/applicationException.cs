using System;


namespace p4{

    public class InvalidMarks : Exception
    {

        public InvalidMarks() : base("Marks is out of range"){

        }

        public InvalidMarks(string s) : base(s){

        }
    }


    public class AEDemo {
        
        public void updateMarks(int m1){
            if(m1<0 || m1>100){
                throw new InvalidMarks();
            }
            System.Console.WriteLine("Marks is updated!");
        }


    }





}