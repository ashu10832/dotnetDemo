using System;
using entity_demo.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace entity_demo
{

    class StudentDAO
    {
        public void insertIntoStud(Stud stud){
            try
            {
                studentContext context = new studentContext();
                context.Stud.Add(stud);
                context.SaveChanges();
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
    }
    
}