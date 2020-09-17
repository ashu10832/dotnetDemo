using System;
using System.Collections.Generic;

namespace coll_prj
{
    class DictionaryDemo
    {

        public void f1(){

            Dictionary<string,int> dict = new Dictionary<string, int>();

            dict.Add("Delhi",1000);
            dict.Add("Mumbai",2000);
            dict.Add("Chennai",3000);

            //dict.Add("Delhi",2000);
            //dict["Delhi"] = 2000;

            System.Console.WriteLine(dict["Delhi"]);

            foreach (var item in dict.Keys)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine(dict[item]);
            }

            dict["Delhi"] = 5000;
            System.Console.WriteLine("\n\n\n\n");

            System.Console.WriteLine(dict["Delhi"]);

            dict.Remove("Chennai");

            foreach (var item in dict.Keys)
            {
                System.Console.WriteLine(item);
                System.Console.WriteLine(dict[item]);
            }

            
            System.Console.WriteLine(dict.ContainsKey("Chennai"));

            Dictionary<string,int> dict2 = new Dictionary<string, int>();

            dict2.Add("Baroda",1);
            dict2.Add("Indore",2);
            dict2.Add("Guwahati",3);
            dict2.Add("Delhi",5);

            
            foreach (var item in dict.Keys)
            {   
                if(!dict2.ContainsKey(item))
                    dict2.Add(item,dict[item]);
                else{
                    dict2[item] = dict[item];
                }
            }

            foreach (var item in dict2.Keys)
            {   

                System.Console.WriteLine(item);
                System.Console.WriteLine(dict2[item]);
            }


























        }
        
    }
}