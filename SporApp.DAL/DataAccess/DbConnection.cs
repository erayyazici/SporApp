using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporApp
{
    public class DbConnection
    {
        public MySqlConnection conn;
        public MySqlConnection dbConn()
        {
            conn = new MySqlConnection("Server=localhost;Database=sporapp;Uid=root;Pwd='';");
            conn.Open();
            return conn;
        }

        public void CloseConn()
        {
            conn.Close();
        }
        

    }
}
