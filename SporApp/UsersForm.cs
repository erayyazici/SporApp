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
    public partial class UsersForm : Form
    {
        UsersBLL bll = new UsersBLL();
        public UsersForm()
        {
            InitializeComponent();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGet();
            dataGridView1.MultiSelect = false;
            ColumnName();
        }
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
            dataGridView1.Columns[9].Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUpdateTc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUpdateImage.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboUpdateGender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboUpdateBranch.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtUpdateTel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtUpdateMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtUpdateAddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGet();
            ColumnName();
        }
        private void btnFitness_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGetFitness();
            ColumnName();
        }
        private void btnPilates_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGetPilates();
            ColumnName();
        }
        private void btnKardiyo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGetKardiyo();
            ColumnName();
        }
        private void btnBranch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.UsersGetDans();
            ColumnName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bll.UpdateUser(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txtUpdateName.Text, txtUpdateTc.Text, txtUpdateImage.Text, comboUpdateGender.Text, comboUpdateBranch.Text, txtUpdateTel.Text, txtUpdateMail.Text, txtUpdateAddress.Text);
            dataGridView1.DataSource = bll.UsersGet();
            txtUpdateName.Clear();
            txtUpdateTc.Clear();
            txtUpdateImage.Clear();
            txtUpdateTel.Clear();
            txtUpdateMail.Clear();
            txtUpdateAddress.Clear();
            comboUpdateGender.Text = null;
            comboUpdateBranch.Text = null;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
                bll.DeleteUserById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = bll.UsersGet();
        }
        Random rastgele = new Random();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int users_password = rastgele.Next(100000, 999999);
            bll.AddNewUser(txtUserName.Text, txtUserTc.Text, "/images/Kullanici/27208257702277027810logo.png", comboUserGender.Text, comboUserBranch.Text, txtUserTel.Text, txtUserMail.Text, txtUserAddress.Text, users_password.ToString());
            dataGridView1.DataSource = bll.UsersGet();
            txtUserName.Clear();
            txtUserTc.Clear();
            txtUserTel.Clear();
            txtUserMail.Clear();
            txtUserAddress.Clear();
            comboUserGender.Text = null;
            comboUserBranch.Text = null;
        }

	}
}
