using System;
using System.Threading;
using System.Collections.Concurrent;


namespace thread_prj{

    class Thread1
    {


        
        ConcurrentQueue<int>  purchases = new ConcurrentQueue<int>();
           
        string mName;
        int x;
        public Thread1(){
            mName = "Big Bazaar";
            x = 5;

            purchases.Enqueue(1);
            purchases.Enqueue(2);
            purchases.Enqueue(3);
            purchases.Enqueue(4);
            purchases.Enqueue(5);
            purchases.Enqueue(6);
            purchases.Enqueue(7);
            purchases.Enqueue(8);
            purchases.Enqueue(9);
            purchases.Enqueue(10);
        }

        public Thread1(string mName, int x){
            this.mName = mName;
            this.x = x;
        }

        public void runAsThread(){
            for (int i = 0; i < x; i++){
                System.Console.WriteLine(mName + ": " + i);
            }
        }

        public void f1(){
            System.Console.WriteLine(mName + ": " + x);
        }

        public void allot(){
            while(!purchases.IsEmpty){
                purchases.TryDequeue(out int p);
                System.Console.WriteLine("{0} alloted",p);
            }
            
            
        }
        
    }




}