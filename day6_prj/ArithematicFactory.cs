using System;


namespace arithematic{

    class ArithematicAbstractFactory
    {

        public static Arithematic getFactory(int ch){
            switch (ch)
            {
                case 1: return new Addition();
                case 2: return new Subtraction();
                case 3: return new Multiplication();
                case 4: return new Division();
                
                default: return null;
            }

        }
        
    }



}