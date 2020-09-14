using System;
using p1;

namespace p2{

    class Access3{

        public void test2(){

            Access obj = new Access();
            // obj.f1();
            // obj.f2();
            // obj.f3();
            obj.f5();

            

            

            
            
            
            
            

            

        }

        
    }


    class Access4 : Access{

        public void test5(){
            f1();
            f2();
            f3();
            f5();
            f4();



        }




    }






}