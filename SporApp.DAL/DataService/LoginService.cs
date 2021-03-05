using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporApp.DataService
{
    public class LoginService
    {
        private int _LoginId;
        private string _LoginUser;
        private string _LoginPass;

        public int LoginId { get => _LoginId; set => _LoginId = value; }
        public string LoginUser { get => _LoginUser; set => _LoginUser = value; }
        public string LoginPass { get => _LoginPass; set => _LoginPass = value; }

        DbConnection con = new DbConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public string message;

        public bool LoginEntry(string LoginUser, string LoginPass)
        {    
            try
            {
                con.dbConn();
                cmd.Connection = con.dbConn();
                cmd.CommandText = "SELECT * FROM login where login_user='" + LoginUser + "' AND login_pass='" + LoginPass + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
