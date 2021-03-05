using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SporApp.DataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporApp
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        LoginService log = new LoginService();
        private void button1_Click(object sender, EventArgs e)
        {
            bool result = log.LoginEntry(textBox1.Text, textBox2.Text);

            if (result == true)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.");
            }
        }

    }
}
