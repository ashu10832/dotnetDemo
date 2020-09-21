using System;
using entity_demo.Model;

namespace entity_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StudentDAO studentDAO = new StudentDAO();
                Stud stud = new Stud();
                stud.Sid = "2001";
                stud.Fname = "Kashish";
                stud.Dob = Convert.ToDateTime("10-10-2000");
                studentDAO.insertIntoStud(stud);
                System.Console.WriteLine("Data Added");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
