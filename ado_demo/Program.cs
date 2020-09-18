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
            List<StudentDTO> students = studentDAO.GetAllStudents();
            foreach (var item in students)
            {
                System.Console.WriteLine(item.fname + " " + item.sid + " " + item.dob);
            }
        }
    }

}
