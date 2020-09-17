using System.Collections;


namespace coll_prj
{
    class GenAddTemplate<T>
    {
        T a,b;
        public void f1(){
            
        }

        public void read(T a, T b){
            this.a = a;
            this.b = b;
        }

        public void display(){
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
        
    }
    
}