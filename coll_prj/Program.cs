using System;
using p3;
using System.Collections.Generic;

namespace coll_prj
{
    class Program
    {
        static void Main(string[] args)
        {

            // EmpDTO emp = new EmpDTO("Raj",20,"Delhi");
            // EmpDTO emp1 = new EmpDTO("Alpha",21,"Delhi");
            // EmpDTO emp2 = new EmpDTO("Zeta",17,"Delhi");

            // SortedSet<EmpDTO> emp_set = new SortedSet<EmpDTO>();

            // emp_set.Add(emp);
            // emp_set.Add(emp1);
            // emp_set.Add(emp2);


            // List<EmpDTO> emp_list = new List<EmpDTO>(emp_set);
            // emp_list.Sort((x,y)=>x.age.CompareTo(y.age));

            // foreach (var em in emp_list)
            // {
            //     System.Console.WriteLine(em);
                
            // }


            

            // foreach (EmpDTO e in emp_set)
            // {
            //     System.Console.WriteLine(e);
                
            // }




            // SortedSet<int> sset = new SortedSet<int>();
            // sset.Add(5);
            // sset.Add(3);
            // sset.Add(8);
            // sset.Add(1);


            // sset.Remove(5);

            // System.Console.WriteLine(sset.Min);

            // System.Console.WriteLine(sset.Max);

            // System.Console.WriteLine(sset.Count);

            // //sset.RemoveWhere();

            // sset.Reverse();



            // DictionaryDemo dictDemo = new DictionaryDemo();
            // dictDemo.f1();

            // QueueDemo queueDemo = new QueueDemo();
            // queueDemo.f4();

            // GenAddTemplate<int> ob = new GenAddTemplate<int>();
            // ob.read(10,20);
            // ob.display();

            // GenAddTemplate<string> ob2 = new GenAddTemplate<string>();
            // ob2.read("Delhi","Mumbai");
            // ob2.display();

            NonGenDemo nonGenDemo = new NonGenDemo();
            nonGenDemo.f1();
            
            
        }
    }
}
