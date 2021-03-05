
namespace SporApp
{
	partial class ReportsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.kontenjan_seans2 = new System.Windows.Forms.DataGridView();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.kontenjan_salon2 = new System.Windows.Forms.ComboBox();
			this.kontenjan_saat2 = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.kontenjan_date2 = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.kontenjan_salon1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.kontenjan_date1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.txtKapasite = new System.Windows.Forms.TextBox();
			this.txtDoluluk = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.kontenjan_seans2)).BeginInit();
			this.panel8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// kontenjan_seans2
			// 
			this.kontenjan_seans2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.kontenjan_seans2.Location = new System.Drawing.Point(327, 12);
			this.kontenjan_seans2.Name = "kontenjan_seans2";
			this.kontenjan_seans2.Size = new System.Drawing.Size(442, 188);
			this.kontenjan_seans2.TabIndex = 25;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.label17);
			this.panel8.Controls.Add(this.kontenjan_salon2);
			this.panel8.Controls.Add(this.kontenjan_saat2);
			this.panel8.Controls.Add(this.label15);
			this.panel8.Controls.Add(this.kontenjan_date2);
			this.panel8.Controls.Add(this.label16);
			this.panel8.Controls.Add(this.button4);
			this.panel8.Location = new System.Drawing.Point(12, 12);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(297, 188);
			this.panel8.TabIndex = 26;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(7, 14);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(34, 13);
			this.label17.TabIndex = 21;
			this.label17.Text = "Salon";
			// 
			// kontenjan_salon2
			// 
			this.kontenjan_salon2.FormattingEnabled = true;
			this.kontenjan_salon2.Items.AddRange(new object[] {
            "Fitness",
            "Pilates",
            "Kardiyo",
            "Dans"});
			this.kontenjan_salon2.Location = new System.Drawing.Point(90, 11);
			this.kontenjan_salon2.Name = "kontenjan_salon2";
			this.kontenjan_salon2.Size = new System.Drawing.Size(138, 21);
			this.kontenjan_salon2.TabIndex = 20;
			this.kontenjan_salon2.Tag = "";
			// 
			// kontenjan_saat2
			// 
			this.kontenjan_saat2.FormattingEnabled = true;
			this.kontenjan_saat2.Items.AddRange(new object[] {
            "Tüm Seanslar",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "13:00 - 14:00",
            "14:00 - 15:00",
            "15:00 - 16:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00",
            "21:00 - 22:00",
            "22:00 - 23:00",
            "23:00 - 24:00"});
			this.kontenjan_saat2.Location = new System.Drawing.Point(99, 83);
			this.kontenjan_saat2.Name = "kontenjan_saat2";
			this.kontenjan_saat2.Size = new System.Drawing.Size(121, 21);
			this.kontenjan_saat2.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(7, 49);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(27, 13);
			this.label15.TabIndex = 3;
			this.label15.Text = "Gün";
			// 
			// kontenjan_date2
			// 
			this.kontenjan_date2.Location = new System.Drawing.Point(59, 43);
			this.kontenjan_date2.Name = "kontenjan_date2";
			this.kontenjan_date2.Size = new System.Drawing.Size(190, 20);
			this.kontenjan_date2.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(7, 86);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(29, 13);
			this.label16.TabIndex = 1;
			this.label16.Text = "Saat";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(99, 122);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(106, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Listele";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtKapasite);
			this.panel1.Controls.Add(this.txtDoluluk);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.kontenjan_salon1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.kontenjan_date1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(12, 217);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(443, 188);
			this.panel1.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(96, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Günlük Sayı Listeleme";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Salon";
			// 
			// kontenjan_salon1
			// 
			this.kontenjan_salon1.FormattingEnabled = true;
			this.kontenjan_salon1.Items.AddRange(new object[] {
            "Fitness",
            "Pilates",
            "Kardiyo",
            "Dans"});
			this.kontenjan_salon1.Location = new System.Drawing.Point(90, 41);
			this.kontenjan_salon1.Name = "kontenjan_salon1";
			this.kontenjan_salon1.Size = new System.Drawing.Size(138, 21);
			this.kontenjan_salon1.TabIndex = 20;
			this.kontenjan_salon1.Tag = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Gün";
			// 
			// kontenjan_date1
			// 
			this.kontenjan_date1.Location = new System.Drawing.Point(59, 77);
			this.kontenjan_date1.Name = "kontenjan_date1";
			this.kontenjan_date1.Size = new System.Drawing.Size(190, 20);
			this.kontenjan_date1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(99, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtKapasite
			// 
			this.txtKapasite.Location = new System.Drawing.Point(315, 122);
			this.txtKapasite.Name = "txtKapasite";
			this.txtKapasite.Size = new System.Drawing.Size(100, 20);
			this.txtKapasite.TabIndex = 30;
			// 
			// txtDoluluk
			// 
			this.txtDoluluk.Location = new System.Drawing.Point(315, 44);
			this.txtDoluluk.Name = "txtDoluluk";
			this.txtDoluluk.Size = new System.Drawing.Size(100, 20);
			this.txtDoluluk.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(323, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 32;
			this.label4.Text = "Toplam Doluluk";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(323, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "Toplam Kapasite";
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.kontenjan_seans2);
			this.Name = "ReportsForm";
			this.Text = "ReportsForm";
			((System.ComponentModel.ISupportInitialize)(this.kontenjan_seans2)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView kontenjan_seans2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox kontenjan_salon2;
		private System.Windows.Forms.ComboBox kontenjan_saat2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker kontenjan_date2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox kontenjan_salon1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker kontenjan_date1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtKapasite;
		private System.Windows.Forms.TextBox txtDoluluk;
	}
}