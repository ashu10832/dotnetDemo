using System.Collections.Generic;
using System.Collections;


namespace coll_prj{

    class QueueDemo{

        public void f1(){

            Queue<int> q = new Queue<int>();

            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(8);
            q.Enqueue(9);


            System.Console.WriteLine(q.Peek());

            System.Console.WriteLine(q.Dequeue());

            foreach (var item in q)
            {
                System.Console.WriteLine(item);
               // q.Dequeue();
                
            }

            // foreach (var item in q.GetEnumerator())
            // {
                
                
            // }

            //Enumerator en = q.GetEnumerator();
            IEnumerator<int> en = q.GetEnumerator();


            while (en.MoveNext())
            {
                System.Console.WriteLine(en.Current);
                
            }

        }

        public void f2(){

            HashSet<int> hset = new HashSet<int>();


            hset.Add(5);
            hset.Add(9);
            hset.Add(2);
            hset.Add(1);
            hset.Add(7);
            hset.Add(1);

            foreach (var item in hset)
            {
                System.Console.WriteLine(item);
            }
        }


        public void f3(){
            Stack<int> s = new Stack<int>();

            s.Push(1);
            s.Push(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);

            foreach (var item in s)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("-----------");

            System.Console.WriteLine(s.Pop());
            System.Console.WriteLine(s.Pop());
            System.Console.WriteLine(s.Peek());
            System.Console.WriteLine(s.Contains(5));
        }


        public void f4(){
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(1);
            ll.AddFirst(5);
            ll.AddLast(6);
            ll.AddAfter(ll.Find(5),10);

            foreach (var item in ll)
            {
                System.Console.WriteLine(item);
                
            }




        }





    }





}