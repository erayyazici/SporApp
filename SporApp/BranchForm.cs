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
    public partial class BranchForm : Form
    {
        KontenjanBLL bll = new KontenjanBLL();
        public BranchForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string date = kontenjan_date1.Value.ToShortDateString();
            bll.KontenjanAdd(kontenjan_salon1.SelectedItem.ToString(), date, Convert.ToInt32(kontenjan_person1.Text), "Çalışır");
            MessageBox.Show("Kontenjan Ayarlanmıştır.");
        }

		private void button4_Click(object sender, EventArgs e)
		{
            string date = kontenjan_date2.Value.ToShortDateString();
            kontenjan_seans2.DataSource = bll.KontenjanGet(kontenjan_salon2.SelectedItem.ToString(), date, kontenjan_saat2.SelectedItem.ToString());
            kontenjan_seans2.MultiSelect = false;
            kontenjan_seans2.Columns[0].Visible = false;
            kontenjan_seans2.Columns[1].Visible = false;
            kontenjan_seans2.Columns[2].Visible = false;
            kontenjan_seans2.Columns[3].Visible = false;
            kontenjan_seans2.Columns[4].HeaderText = "Doluluk";
            kontenjan_seans2.Columns[5].HeaderText = "Kontenjan";
            kontenjan_seans2.Columns[6].Visible = false;
        }

		private void button1_Click_1(object sender, EventArgs e)
		{
            string date = kontenjan_date3.Value.ToShortDateString();
            bll.KontenjanUpdate(kontenjan_salon3.SelectedItem.ToString(), date, kontenjan_person3.Text, kontenjan_saat3.SelectedItem.ToString());
            MessageBox.Show("Kontenjan Ayarlanmıştır.");
            
        }

		private void button3_Click_1(object sender, EventArgs e)
		{
            string date = kontenjan_date4.Value.ToShortDateString();
            bll.KontenjanUpdateDurum(kontenjan_salon4.SelectedItem.ToString(), date, kontenjan_cancel4.SelectedItem.ToString(), kontenjan_saat4.SelectedItem.ToString());
            MessageBox.Show("Kontenjan Ayarlanmıştır.");
        }
	}
}
