namespace SporApp
{
    partial class UsersForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtUserTel = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUserMail = new System.Windows.Forms.TextBox();
			this.txtUserAddress = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnUsers = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnBranch = new System.Windows.Forms.Button();
			this.btnKardiyo = new System.Windows.Forms.Button();
			this.btnPilates = new System.Windows.Forms.Button();
			this.btnFitness = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.txtUpdateTc = new System.Windows.Forms.MaskedTextBox();
			this.txtUserTc = new System.Windows.Forms.MaskedTextBox();
			this.comboUpdateGender = new System.Windows.Forms.ComboBox();
			this.comboUserGender = new System.Windows.Forms.ComboBox();
			this.comboUserBranch = new System.Windows.Forms.ComboBox();
			this.comboUpdateBranch = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtUpdateName = new System.Windows.Forms.TextBox();
			this.txtUpdateAddress = new System.Windows.Forms.TextBox();
			this.txtUpdateImage = new System.Windows.Forms.TextBox();
			this.txtUpdateMail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtUpdateTel = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel12.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(636, 172);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(67, 195);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(80, 20);
			this.txtUserName.TabIndex = 8;
			// 
			// txtUserTel
			// 
			this.txtUserTel.Location = new System.Drawing.Point(203, 225);
			this.txtUserTel.MaxLength = 11;
			this.txtUserTel.Name = "txtUserTel";
			this.txtUserTel.Size = new System.Drawing.Size(83, 20);
			this.txtUserTel.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Ad Soyad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 237);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "TC";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Cinsiyet";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(163, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Branş";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(163, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Telefon";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(163, 258);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "E-mail";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(163, 288);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Adres";
			// 
			// txtUserMail
			// 
			this.txtUserMail.Location = new System.Drawing.Point(203, 251);
			this.txtUserMail.Name = "txtUserMail";
			this.txtUserMail.Size = new System.Drawing.Size(83, 20);
			this.txtUserMail.TabIndex = 22;
			// 
			// txtUserAddress
			// 
			this.txtUserAddress.Location = new System.Drawing.Point(203, 279);
			this.txtUserAddress.Name = "txtUserAddress";
			this.txtUserAddress.Size = new System.Drawing.Size(83, 20);
			this.txtUserAddress.TabIndex = 23;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(123, 322);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 24;
			this.btnAdd.Text = "Kayıt Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(286, 322);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 25;
			this.btnDelete.Text = "Kayıt Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(195, 82);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(195, 82);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnUsers);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 82);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(195, 30);
			this.panel3.TabIndex = 2;
			// 
			// btnUsers
			// 
			this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnUsers.FlatAppearance.BorderSize = 0;
			this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUsers.Location = new System.Drawing.Point(0, 0);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnUsers.Size = new System.Drawing.Size(195, 30);
			this.btnUsers.TabIndex = 0;
			this.btnUsers.Text = "Tüm Üyeler";
			this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUsers.UseVisualStyleBackColor = true;
			this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnBranch);
			this.panel4.Controls.Add(this.btnKardiyo);
			this.panel4.Controls.Add(this.btnPilates);
			this.panel4.Controls.Add(this.btnFitness);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 112);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(195, 120);
			this.panel4.TabIndex = 3;
			// 
			// btnBranch
			// 
			this.btnBranch.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBranch.FlatAppearance.BorderSize = 0;
			this.btnBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBranch.Location = new System.Drawing.Point(0, 90);
			this.btnBranch.Name = "btnBranch";
			this.btnBranch.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnBranch.Size = new System.Drawing.Size(195, 30);
			this.btnBranch.TabIndex = 3;
			this.btnBranch.Text = "Dans";
			this.btnBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBranch.UseVisualStyleBackColor = true;
			this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
			// 
			// btnKardiyo
			// 
			this.btnKardiyo.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKardiyo.FlatAppearance.BorderSize = 0;
			this.btnKardiyo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKardiyo.Location = new System.Drawing.Point(0, 60);
			this.btnKardiyo.Name = "btnKardiyo";
			this.btnKardiyo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnKardiyo.Size = new System.Drawing.Size(195, 30);
			this.btnKardiyo.TabIndex = 2;
			this.btnKardiyo.Text = "Kardiyo";
			this.btnKardiyo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKardiyo.UseVisualStyleBackColor = true;
			this.btnKardiyo.Click += new System.EventHandler(this.btnKardiyo_Click);
			// 
			// btnPilates
			// 
			this.btnPilates.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPilates.FlatAppearance.BorderSize = 0;
			this.btnPilates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPilates.Location = new System.Drawing.Point(0, 30);
			this.btnPilates.Name = "btnPilates";
			this.btnPilates.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnPilates.Size = new System.Drawing.Size(195, 30);
			this.btnPilates.TabIndex = 1;
			this.btnPilates.Text = "Pilates";
			this.btnPilates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPilates.UseVisualStyleBackColor = true;
			this.btnPilates.Click += new System.EventHandler(this.btnPilates_Click);
			// 
			// btnFitness
			// 
			this.btnFitness.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFitness.FlatAppearance.BorderSize = 0;
			this.btnFitness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFitness.Location = new System.Drawing.Point(0, 0);
			this.btnFitness.Name = "btnFitness";
			this.btnFitness.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnFitness.Size = new System.Drawing.Size(195, 30);
			this.btnFitness.TabIndex = 0;
			this.btnFitness.Text = "Fitness";
			this.btnFitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFitness.UseVisualStyleBackColor = true;
			this.btnFitness.Click += new System.EventHandler(this.btnFitness_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(195, 450);
			this.panel1.TabIndex = 6;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.txtUpdateTc);
			this.panel12.Controls.Add(this.txtUserTc);
			this.panel12.Controls.Add(this.comboUpdateGender);
			this.panel12.Controls.Add(this.comboUserGender);
			this.panel12.Controls.Add(this.comboUserBranch);
			this.panel12.Controls.Add(this.comboUpdateBranch);
			this.panel12.Controls.Add(this.btnUpdate);
			this.panel12.Controls.Add(this.txtUpdateName);
			this.panel12.Controls.Add(this.dataGridView1);
			this.panel12.Controls.Add(this.btnAdd);
			this.panel12.Controls.Add(this.txtUpdateAddress);
			this.panel12.Controls.Add(this.btnDelete);
			this.panel12.Controls.Add(this.txtUpdateImage);
			this.panel12.Controls.Add(this.txtUserName);
			this.panel12.Controls.Add(this.txtUpdateMail);
			this.panel12.Controls.Add(this.txtUserAddress);
			this.panel12.Controls.Add(this.label9);
			this.panel12.Controls.Add(this.txtUserMail);
			this.panel12.Controls.Add(this.label10);
			this.panel12.Controls.Add(this.txtUpdateTel);
			this.panel12.Controls.Add(this.label8);
			this.panel12.Controls.Add(this.label11);
			this.panel12.Controls.Add(this.label12);
			this.panel12.Controls.Add(this.label13);
			this.panel12.Controls.Add(this.label7);
			this.panel12.Controls.Add(this.label14);
			this.panel12.Controls.Add(this.txtUserTel);
			this.panel12.Controls.Add(this.label15);
			this.panel12.Controls.Add(this.label6);
			this.panel12.Controls.Add(this.label16);
			this.panel12.Controls.Add(this.label1);
			this.panel12.Controls.Add(this.label5);
			this.panel12.Controls.Add(this.label2);
			this.panel12.Controls.Add(this.label4);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(195, 0);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(636, 450);
			this.panel12.TabIndex = 26;
			// 
			// txtUpdateTc
			// 
			this.txtUpdateTc.Location = new System.Drawing.Point(388, 224);
			this.txtUpdateTc.Mask = "00000000000";
			this.txtUpdateTc.Name = "txtUpdateTc";
			this.txtUpdateTc.Size = new System.Drawing.Size(80, 20);
			this.txtUpdateTc.TabIndex = 49;
			// 
			// txtUserTc
			// 
			this.txtUserTc.Location = new System.Drawing.Point(67, 234);
			this.txtUserTc.Mask = "00000000000";
			this.txtUserTc.Name = "txtUserTc";
			this.txtUserTc.Size = new System.Drawing.Size(80, 20);
			this.txtUserTc.TabIndex = 48;
			// 
			// comboUpdateGender
			// 
			this.comboUpdateGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboUpdateGender.FormattingEnabled = true;
			this.comboUpdateGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.comboUpdateGender.Location = new System.Drawing.Point(385, 278);
			this.comboUpdateGender.Name = "comboUpdateGender";
			this.comboUpdateGender.Size = new System.Drawing.Size(83, 21);
			this.comboUpdateGender.TabIndex = 47;
			// 
			// comboUserGender
			// 
			this.comboUserGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboUserGender.FormattingEnabled = true;
			this.comboUserGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.comboUserGender.Location = new System.Drawing.Point(64, 274);
			this.comboUserGender.Name = "comboUserGender";
			this.comboUserGender.Size = new System.Drawing.Size(83, 21);
			this.comboUserGender.TabIndex = 46;
			// 
			// comboUserBranch
			// 
			this.comboUserBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboUserBranch.FormattingEnabled = true;
			this.comboUserBranch.Items.AddRange(new object[] {
            "Fitness",
            "Pilates",
            "Kardiyo",
            "Dans"});
			this.comboUserBranch.Location = new System.Drawing.Point(203, 192);
			this.comboUserBranch.Name = "comboUserBranch";
			this.comboUserBranch.Size = new System.Drawing.Size(83, 21);
			this.comboUserBranch.TabIndex = 45;
			// 
			// comboUpdateBranch
			// 
			this.comboUpdateBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboUpdateBranch.FormattingEnabled = true;
			this.comboUpdateBranch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.comboUpdateBranch.Location = new System.Drawing.Point(524, 195);
			this.comboUpdateBranch.Name = "comboUpdateBranch";
			this.comboUpdateBranch.Size = new System.Drawing.Size(83, 21);
			this.comboUpdateBranch.TabIndex = 44;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(443, 322);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(99, 23);
			this.btnUpdate.TabIndex = 43;
			this.btnUpdate.Text = "Kayıt Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtUpdateName
			// 
			this.txtUpdateName.Location = new System.Drawing.Point(388, 198);
			this.txtUpdateName.Name = "txtUpdateName";
			this.txtUpdateName.Size = new System.Drawing.Size(80, 20);
			this.txtUpdateName.TabIndex = 27;
			// 
			// txtUpdateAddress
			// 
			this.txtUpdateAddress.Location = new System.Drawing.Point(524, 282);
			this.txtUpdateAddress.Name = "txtUpdateAddress";
			this.txtUpdateAddress.Size = new System.Drawing.Size(83, 20);
			this.txtUpdateAddress.TabIndex = 42;
			// 
			// txtUpdateImage
			// 
			this.txtUpdateImage.Location = new System.Drawing.Point(388, 255);
			this.txtUpdateImage.Name = "txtUpdateImage";
			this.txtUpdateImage.Size = new System.Drawing.Size(80, 20);
			this.txtUpdateImage.TabIndex = 29;
			// 
			// txtUpdateMail
			// 
			this.txtUpdateMail.Location = new System.Drawing.Point(524, 254);
			this.txtUpdateMail.Name = "txtUpdateMail";
			this.txtUpdateMail.Size = new System.Drawing.Size(83, 20);
			this.txtUpdateMail.TabIndex = 41;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(484, 291);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 13);
			this.label9.TabIndex = 40;
			this.label9.Text = "Adres";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(484, 261);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 39;
			this.label10.Text = "E-mail";
			// 
			// txtUpdateTel
			// 
			this.txtUpdateTel.Location = new System.Drawing.Point(524, 228);
			this.txtUpdateTel.MaxLength = 11;
			this.txtUpdateTel.Name = "txtUpdateTel";
			this.txtUpdateTel.Size = new System.Drawing.Size(83, 20);
			this.txtUpdateTel.TabIndex = 32;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(484, 234);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 13);
			this.label11.TabIndex = 38;
			this.label11.Text = "Telefon";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(329, 198);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 13);
			this.label12.TabIndex = 33;
			this.label12.Text = "Ad Soyad";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(484, 201);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(34, 13);
			this.label13.TabIndex = 37;
			this.label13.Text = "Branş";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(329, 224);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(21, 13);
			this.label14.TabIndex = 34;
			this.label14.Text = "TC";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(329, 282);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(43, 13);
			this.label15.TabIndex = 36;
			this.label15.Text = "Cinsiyet";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(329, 252);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(46, 13);
			this.label16.TabIndex = 35;
			this.label16.Text = "Fotoğraf";
			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 450);
			this.Controls.Add(this.panel12);
			this.Controls.Add(this.panel1);
			this.Name = "UsersForm";
			this.Text = "Üye İşlemleri";
			this.Load += new System.EventHandler(this.AddNewUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnKardiyo;
        private System.Windows.Forms.Button btnPilates;
        private System.Windows.Forms.Button btnFitness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboUpdateBranch;
        private System.Windows.Forms.ComboBox comboUserBranch;
        private System.Windows.Forms.ComboBox comboUserGender;
        private System.Windows.Forms.ComboBox comboUpdateGender;
		private System.Windows.Forms.MaskedTextBox txtUserTc;
		private System.Windows.Forms.MaskedTextBox txtUpdateTc;
		private System.Windows.Forms.TextBox txtUpdateImage;
		private System.Windows.Forms.Label label16;
	}
}