using SporApp.DataService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporApp.BLL.SporApp
{
    public class UsersBLL
    {
        private UsersDAL UsersDAL;      
        public UsersBLL()
        {
            UsersDAL = new UsersDAL();
        }
        public DataTable UsersGet()
        {
            return UsersDAL.UsersGet();
        }
        public DataTable UsersGetFitness()
        {
            return UsersDAL.UsersGetFitness(); 
        }
        public DataTable UsersGetPilates()
        {
            return UsersDAL.UsersGetPilates();
        }
        public DataTable UsersGetKardiyo()
        {
            return UsersDAL.UsersGetKardiyo();
        }
        public DataTable UsersGetDans()
        {
            return UsersDAL.UsersGetDans();
        }

        public void AddNewUser(string users_name, string users_tc, string users_image, string users_gender, string users_branch, string users_tel, string users_mail, string users_address,string users_password)
        {
            UsersDAL.AddNewUser(users_name, users_tc, users_image, users_gender, users_branch, users_tel, users_mail, users_address, users_password);
        }

        public void DeleteUserById(int users_id)
        {
            UsersDAL.DeleteUserById(users_id);
        }

        public void UpdateUser(int users_id,string users_name, string users_tc, string users_image, string users_gender, string users_branch, string users_tel, string users_mail, string users_address)
        {
            UsersDAL.UpdateUser(users_id,users_name, users_tc, users_image, users_gender, users_branch, users_tel, users_mail, users_address);
        }
    }
}
