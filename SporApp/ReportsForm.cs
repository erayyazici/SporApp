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
	public partial class ReportsForm : Form
	{
		KontenjanBLL bll = new KontenjanBLL();
		public ReportsForm()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string date = kontenjan_date2.Value.ToShortDateString();

			kontenjan_seans2.DataSource = bll.KontenjanGet(kontenjan_salon2.SelectedItem.ToString(), date, kontenjan_saat2.SelectedItem.ToString());
			kontenjan_seans2.MultiSelect = false;
			kontenjan_seans2.Columns[0].Visible = false;
			kontenjan_seans2.Columns[1].Visible = false;
			kontenjan_seans2.Columns[2].HeaderText = "Tarih";
			kontenjan_seans2.Columns[3].HeaderText = "Saat";
			kontenjan_seans2.Columns[4].HeaderText = "Doluluk";
			kontenjan_seans2.Columns[5].HeaderText = "Kontenjan";
			kontenjan_seans2.Columns[6].Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string date = kontenjan_date1.Value.ToShortDateString();

			kontenjan_seans2.DataSource = bll.KontenjanGets(kontenjan_salon1.SelectedItem.ToString(), date);
			int toplam = 0;
			int toplams = 0;
			for (int i = 0; i < kontenjan_seans2.Rows.Count; ++i)
			{
				toplam += Convert.ToInt32(kontenjan_seans2.Rows[i].Cells[4].Value);
				toplams += Convert.ToInt32(kontenjan_seans2.Rows[i].Cells[5].Value);
			}
			txtDoluluk.Text = toplam.ToString();
			txtKapasite.Text=toplams.ToString();
		}
	}
}
