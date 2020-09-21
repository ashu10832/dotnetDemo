using System;
using entity_demo.Model;
using System.Collections.Generic;

namespace entity_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentDAO studentDAO = new StudentDAO();
            // try
            // {
            //     StudentDAO studentDAO = new StudentDAO();
            //     Stud stud = new Stud();
            //     stud.Sid = "2001";
            //     stud.Fname = "Kashish";
            //     stud.Dob = Convert.ToDateTime("10-10-2000");
            //     studentDAO.insertIntoStud(stud);
            //     System.Console.WriteLine("Data Added");
            // }
            // catch (System.Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            //     throw;
            // }

            try
            {
                IEnumerable<Stud> students  =  studentDAO.getAllStudentsList("1005");
                foreach (var item in students)
                    {
                        System.Console.WriteLine(item.Sid + item.Fname + item.Dob);
                    }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }


        }
    }
}
