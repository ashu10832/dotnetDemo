using System;
using day8_prj;


namespace p4{

    public static class ExtensionDemo
    {
        public static void f2(this Program i){
            System.Console.WriteLine("I am in f2");
        }
        
    }

    public static class StringAddition
    {

        public static string toProperCase(this string s){
            return s.ToUpper();
        }
        
    }







}