namespace p4{

    public class ExceptionDemo
    {
        public void division(int a,int b){
            // try
            // {
            //     int result = a/b;
            // }
            // catch (System.Exception e)
            // {
            //     // System.Console.WriteLine("Exception caught" + e.Message);
            //     throw new System.Exception(e.Message);
            // }
            // finally{
            //     System.Console.WriteLine("Division method over");
            // }

            // if(b == 0) throw new System.Exception("Argument passed is 0 which cannot be divided");

            System.Console.WriteLine("Division = {0}",(a/b));
            

        }



    }




}