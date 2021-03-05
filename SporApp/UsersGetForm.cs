using SporApp.BLL.SporApp;
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
	public partial class UsersGetForm : Form
	{
		public UsersGetForm()
		{
			InitializeComponent();
		}

        UsersBLL bll = new UsersBLL();

        private void ColumnName()
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "Üye Numarası";
            dataGridView1.Columns[1].HeaderText = "İsim Soyisim";
            dataGridView1.Columns[2].HeaderText = "Tc Kimlik";
            dataGridView1.Columns[3].HeaderText = "Fotoğraf";
            dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Branş";
            dataGridView1.Columns[6].HeaderText = "Telefon";
            dataGridView1.Columns[7].HeaderText = "E-mail Adresi";
            dataGridView1.Columns[8].HeaderText = "Adres";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGet();
            ColumnName();
        }

		private void button2_Click_1(object sender, EventArgs e)
		{
            dataGridView1.DataSource = bll.UsersGetFitness();
            ColumnName();
        }

		private void button3_Click_1(object sender, EventArgs e)
		{
            dataGridView1.DataSource = bll.UsersGetPilates();
            ColumnName();
        }

		private void button4_Click_1(object sender, EventArgs e)
		{
            dataGridView1.DataSource = bll.UsersGetKardiyo();
            ColumnName();
        }

		private void button5_Click(object sender, EventArgs e)
		{
            dataGridView1.DataSource = bll.UsersGetDans();
            ColumnName();
        }

		private void UsersGetForm_Load_1(object sender, EventArgs e)
		{
            dataGridView1.DataSource = bll.UsersGet();
            ColumnName();
        }
	}
}

