using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;



namespace ado_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDAO studentDAO = new StudentDAO();
            // List<StudentDTO> students = studentDAO.GetStudentByID("1005");
            // foreach (var item in students)
            // {
            //     System.Console.WriteLine(item.fname + " " + item.sid + " " + item.dob);
            // }

            System.Console.WriteLine("Enter student details: sid fname dob");
            StudentDTO student = new StudentDTO();
            student.sid = Console.ReadLine();
            student.fname = Console.ReadLine();
            student.dob = Console.ReadLine();

            // System.Console.WriteLine(studentDAO.InsertStudent(student));
            System.Console.WriteLine(studentDAO.InsertStudentUsingProcedure(student));
        }
    }

}
