using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace ado_demo
{
    class StudentDAO
    {
        public List<StudentDTO> GetAllStudents(){
            MySqlDataReader reader = null;
            List<StudentDTO> students = null;
            try
            {
                MySqlConnection co = MConnect.getConnection();
                co.Open();
                MySqlCommand com = new MySqlCommand("select * from stud",co);
                reader = com.ExecuteReader();
                students = new List<StudentDTO>();
                while (reader.Read())
                {
                    StudentDTO ob = new StudentDTO();
                    ob.sid = (string) reader[0];
                    ob.fname = (string) reader[1];
                    ob.dob = reader[2].ToString();
                    students.Add(ob);
                }
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally{
                reader.Close();
            }
            return students;
        }

        public List<StudentDTO> GetStudentByID(string sid){
            MySqlDataReader reader = null;
            List<StudentDTO> students = null;
            try
            {
                MySqlConnection co = MConnect.getConnection();
                co.Open();
                string query = "select * from stud where sid=@a1";

                MySqlCommand com = new MySqlCommand(query,co);
                com.Parameters.AddWithValue("@a1",sid);
                reader = com.ExecuteReader();
                students = new List<StudentDTO>();
                while (reader.Read())
                {
                    StudentDTO ob = new StudentDTO();
                    ob.sid = (string) reader[0];
                    ob.fname = (string) reader[1];
                    ob.dob = reader[2].ToString();
                    students.Add(ob);
                }
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally{
                reader.Close();
            }
            return students;
        }


        public string InsertStudent(StudentDTO student){
            try
            {
                MySqlConnection co = MConnect.getConnection();
                co.Open();
                string query = "insert into stud values(@a1,@a2,@a3)";

                MySqlCommand com = new MySqlCommand(query,co);
                com.Parameters.AddWithValue("@a1",student.sid);
                com.Parameters.AddWithValue("@a2",student.fname);
                com.Parameters.AddWithValue("@a3",student.dob);
                com.ExecuteNonQuery();          
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally{
                
            }
            return "inserted!";
        }




        public string InsertStudentUsingProcedure(StudentDTO student){
            try
            {
                MySqlConnection co = MConnect.getConnection();
                co.Open();
                string query = "p2";

                MySqlCommand com = new MySqlCommand(query,co);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("a1",student.sid);
                com.Parameters.AddWithValue("a2",student.fname);
                com.Parameters.AddWithValue("a3",student.dob);
                com.ExecuteNonQuery();          
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally{
                
            }
            return "inserted!";
        }

        //delete

        public StudentDTO deleteStudentByID(string sid){
            
        }










        //update


        
        
        








    }
    
}