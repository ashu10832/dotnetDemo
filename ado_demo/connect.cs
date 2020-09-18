using System;
using MySql.Data.MySqlClient;
using System.IO;



namespace ado_demo
{
    class MConnect
    {

        public static MySqlConnection con = null;

        public static MySqlConnection getConnection(){
            try
            {
                if(con == null){
                    string connection_url = @"Server=localhost;database=student;uid=root;pwd=Ritzzxi1.";
                    con = new MySqlConnection(connection_url);
                    System.Console.WriteLine("Connection Established");
                }
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
            return con;
        }
        
    }
}