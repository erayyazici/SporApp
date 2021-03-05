using MySql.Data.MySqlClient;
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
using SporApp.BLL;
using SporApp.BLL.SporApp;

namespace SporApp
{
    public partial class MainForm : Form
    {
        UsersBLL bll = new UsersBLL();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            customizeDesign();
           
        }
        private void customizeDesign()
        {
            panel4.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
  
        }
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersGetForm add = new UsersGetForm();
            add.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UsersForm add = new UsersForm();
            add.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UsersForm add = new UsersForm();
            add.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            UsersForm add = new UsersForm();
            add.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BranchForm add = new BranchForm();
            add.Show();
        }

		private void button15_Click(object sender, EventArgs e)
		{
            this.Close();
            Application.Exit();

        }

		private void button13_Click(object sender, EventArgs e)
		{
            BranchForm add = new BranchForm();
            add.Show();
        }

		private void button10_Click(object sender, EventArgs e)
		{
            UsersForm add = new UsersForm();
            add.Show();
        }

		private void button14_Click(object sender, EventArgs e)
		{
            ReportsForm add = new ReportsForm();
            add.Show();
        }

	}
}
