using System.Collections.Generic;
using MySql.Data.MySqlClient;

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
                    ob.sid = (string)reader[0];
                    ob.fname =(string) reader[1];
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
        








    }
    
}