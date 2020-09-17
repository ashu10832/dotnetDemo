using System;
using System.Threading;
using System.Collections.Concurrent;

namespace thread_prj

{


    class Agent
    {

        public ConcurrentQueue<string> q = new ConcurrentQueue<string>();

        int flag;


        public Agent(){
            q.Enqueue("rice");
            q.Enqueue("wheat");
            q.Enqueue("lentil");
            q.Enqueue("surf");
            q.Enqueue("brush");
            q.Enqueue("pen");
            q.Enqueue("paper");
            q.Enqueue("rice");
            q.Enqueue("notebook");
            q.Enqueue("colgate");

            flag = 0;
        }

        public string issueProduct(int f1){
            lock(this){
                if(f1 == flag){
                    flag++;
                    Monitor.Pulse(this);
                    Monitor.Wait(this);
                    string s = null;
                    q.TryDequeue(out s);

                    if(flag>2) flag = 0;

                    return s;
                }
                Monitor.Pulse(this);
                Monitor.Wait(this);
                return "null";
            }
        }

        public void dispose(){
            lock(this){
                Monitor.Pulse(this);
            }
        }
    }


    class Store1
    {
        Agent agent;

        public Store1(){

        }

        public Store1(Agent agent){
            this.agent = agent;
        }

        public void m1(){
            while(!agent.q.IsEmpty){
                string s1 = agent.issueProduct(0);
                if(s1 != "null")
                System.Console.WriteLine("Store 1 got order of " + s1);
            }
                agent.dispose();
        }
    }

    class Store2
    {
        Agent agent;

        public Store2(){

        }

        public Store2(Agent agent){
            this.agent = agent;
        }

        public void m1(){
            while(!agent.q.IsEmpty){
                string s1 = agent.issueProduct(1);
                if(s1 != "null")
                System.Console.WriteLine("Store 2 got order of " + s1);
            }
                agent.dispose();
        }
    }
    
    class Store3
    {
        Agent agent;

        public Store3(){

        }

        public Store3(Agent agent){
            this.agent = agent;
        }

        public void m1(){
            while(!agent.q.IsEmpty){
                string s1 = agent.issueProduct(2);
                if(s1 != "null")
                System.Console.WriteLine("Store 3 got order of " + s1);
            }
                agent.dispose();
        }
    }
    
    
}