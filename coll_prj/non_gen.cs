using System.Collections;
using System;
using p3;


namespace coll_prj{

    class NonGenDemo
    {

        public void f1(){
            SortedList slist = new SortedList();
            slist.Add("a","delhi");
            slist.Add("c",20);
            slist.Add("b",new EmpDTO("a",5,"delhi"));

            foreach (var item in slist.Keys)
            {
                System.Console.WriteLine(slist[item]);
            }

            //slist.Add(EmpD);
        }
        
    }


}