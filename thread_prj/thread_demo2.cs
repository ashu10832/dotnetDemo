using System;
using System.Threading;


namespace thread_prj
{
    class Tiktokgame
    {


        public void f1(){
            lock(this){
                System.Console.Write("tik -");
                Monitor.Pulse(this);
                Monitor.Wait(this);
            }
        }

        public void f2(){
            lock(this){
                System.Console.WriteLine("tok -");
                Monitor.Pulse(this);
                Monitor.Wait(this);
            }
        }

        public void dispose(){
            lock(this){
            Monitor.Pulse(this);
            }
        }
        
    }

    class P1Thread{

        Tiktokgame game;

        public P1Thread(){

        }

        public P1Thread(Tiktokgame game){
            this.game = game;
        }

        public void m1(){
            for (int i = 0; i < 10; i++)
            {
                game.f1();
            }

            game.dispose();

        }
    }


    class P2Thread{

        Tiktokgame game;

        public P2Thread(){

        }

        public P2Thread(Tiktokgame game){
            this.game = game;
        }

        public void m1(){
            for (int i = 0; i < 10; i++)
            {
                game.f2();
            }
             game.dispose();

        }
    }






}