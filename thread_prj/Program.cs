using System;
using System.Threading;
using System.Collections.Concurrent;
namespace thread_prj
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Thread1 t1 = new Thread1();

           // We are making runAsThread as a runnable and specifying which methods needs to be run
        //    ThreadStart obj1 = new ThreadStart(t1.runAsThread);


        //    Thread obj2 = new Thread(obj1);

        //    obj2.Start();

           //write a program to display tiktok thread1->tick thread2->tock

           // in a collection 10 purchases are there, distribute this 10 purchases for 3 stores
           // randomly call 3 stores using threads



            

            








        //    TikTok tikTok = new TikTok();
        //    TikTok tikTok2 = new TikTok();


        //    ThreadStart tikThreads = new ThreadStart(tikTok.tik);
        //    ThreadStart tokThreads = new ThreadStart(tikTok2.tok);

        //    Thread tikThread = new Thread(tikThreads);
        //    Thread tokThread = new Thread(tokThreads);
           
        //    tikThread.Start();
        //    tokThread.Start();

        // Thread1 purchaseThread = new Thread1();

        // ThreadStart pthread = new ThreadStart(purchaseThread.allot);

        //    Thread th1 = new Thread(pthread);
        //    Thread th2 = new Thread(pthread);
        //    Thread th3 = new Thread(pthread);

        //    th1.Start();
        //    th2.Start();
        //    th3.Start();



        // Tiktokgame game = new Tiktokgame();

        // Thread t1 = new Thread(new ThreadStart(new P1Thread(game).m1));
        // Thread t2 = new Thread(new ThreadStart(new P2Thread(game).m1));

        // t1.Start();
        // t2.Start();



        Agent agent = new Agent();

        Thread t1 = new Thread(new ThreadStart(new Store1(agent).m1));
        Thread t2 = new Thread(new ThreadStart(new Store2(agent).m1));
        Thread t3 = new Thread(new ThreadStart(new Store3(agent).m1));

        t1.Start();
        t2.Start();
        t3.Start();




           


        }
    }

}
