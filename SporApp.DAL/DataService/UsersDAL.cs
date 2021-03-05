using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporApp.DataService
{
    public class UsersDAL
    {
        DbConnection con = new DbConnection();
        MySqlCommand cmd = new MySqlCommand();     
        public DataTable UsersGet()
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText = "SELECT * FROM users order by branch_id";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public int user_branch(string users_branch)
		{
			switch (users_branch)
			{
                case "Fitness":
                    return 1;
                case "Pilates":
                    return 2;
                case "Kardiyo":
                    return 3;
                case "Dans":
                    return 4;
            }
            return 0;
        }
        public DataTable UsersGetFitness()
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText = "SELECT * FROM users where branch_id='1'";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable UsersGetPilates()
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText = "SELECT * FROM users where branch_id='2'";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable UsersGetKardiyo()
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText = "SELECT * FROM users where branch_id='3'";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable UsersGetDans()
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText = "SELECT * FROM users where branch_id='4'";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        
        public void AddNewUser(string users_name, string users_tc, string users_image, string users_gender, string users_branch, string users_tel, string users_mail, string users_address,string users_password)
        {
			
            cmd.Connection = con.dbConn();
            cmd.CommandText = String.Format("Insert into users (users_name,users_tc,users_image,users_gender,branch_id,users_tel,users_mail,users_address,users_password) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", users_name, users_tc, users_image, users_gender, user_branch(users_branch), users_tel, users_mail, users_address, users_password);
            cmd.ExecuteNonQuery();
        }

        public void DeleteUserById(int users_id)
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText =String.Format("Delete from users where users_id={0}",users_id);
            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(int users_id,string users_name, string users_tc, string users_image, string users_gender, string users_branch, string users_tel, string users_mail, string users_address)
        {
            cmd.Connection = con.dbConn();
            cmd.CommandText = String.Format("Update users SET users_name='"+users_name+"',users_tc='"+users_tc+"',users_image='"+ users_image+"',users_gender='"+users_gender+"',branch_id='"+user_branch(users_branch)+ "',users_tel='"+users_tel+"',users_mail='"+users_mail+"',users_address='"+users_address+"' where users_id='"+ users_id+"'");
            cmd.ExecuteNonQuery();
        }
    }
}
