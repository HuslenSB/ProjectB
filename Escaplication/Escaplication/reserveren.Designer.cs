using Project_B_informatie;
using System.IO;
using System.Windows.Forms;

namespace Escaplication
{
    partial class Reserveren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserveren));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PageTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reserveren1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Recenties = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.Thema = new System.Windows.Forms.Button();
            this.Tarieven = new System.Windows.Forms.Button();
            this.Homepage = new System.Windows.Forms.Button();
            this.Reserveren2 = new System.Windows.Forms.TabPage();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.toaccountbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.yearbox = new System.Windows.Forms.NumericUpDown();
            this.monthbox = new System.Windows.Forms.NumericUpDown();
            this.daybox = new System.Windows.Forms.NumericUpDown();
            this.peoplenumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reserveren3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Reserveren1.SuspendLayout();
            this.Reserveren2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daybox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplenumeric)).BeginInit();
            this.Reserveren3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ik kies deze!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ik kies deze!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(886, 500);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ik kies deze!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 197);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(488, 197);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(826, 197);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 293);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Location = new System.Drawing.Point(558, 96);
            this.PageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(82, 17);
            this.PageTitle.TabIndex = 6;
            this.PageTitle.Text = "Reserveren";
            this.PageTitle.Click += new System.EventHandler(this.PageTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kies een escape room die je wilt reserveren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "THIS IS SPARTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "THE LAST RUN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(870, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "HAUNTED ESCAPE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reserveren1);
            this.tabControl1.Controls.Add(this.Reserveren2);
            this.tabControl1.Controls.Add(this.Reserveren3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 625);
            this.tabControl1.TabIndex = 11;
            // 
            // Reserveren1
            // 
            this.Reserveren1.AccessibleDescription = "s";
            this.Reserveren1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Reserveren1.Controls.Add(this.button8);
            this.Reserveren1.Controls.Add(this.Account);
            this.Reserveren1.Controls.Add(this.Recenties);
            this.Reserveren1.Controls.Add(this.Contact);
            this.Reserveren1.Controls.Add(this.Thema);
            this.Reserveren1.Controls.Add(this.Tarieven);
            this.Reserveren1.Controls.Add(this.Homepage);
            this.Reserveren1.Controls.Add(this.pictureBox2);
            this.Reserveren1.Controls.Add(this.label4);
            this.Reserveren1.Controls.Add(this.label5);
            this.Reserveren1.Controls.Add(this.pictureBox1);
            this.Reserveren1.Controls.Add(this.label3);
            this.Reserveren1.Controls.Add(this.button3);
            this.Reserveren1.Controls.Add(this.PageTitle);
            this.Reserveren1.Controls.Add(this.label2);
            this.Reserveren1.Controls.Add(this.button2);
            this.Reserveren1.Controls.Add(this.button1);
            this.Reserveren1.Controls.Add(this.pictureBox3);
            this.Reserveren1.Location = new System.Drawing.Point(4, 25);
            this.Reserveren1.Margin = new System.Windows.Forms.Padding(4);
            this.Reserveren1.Name = "Reserveren1";
            this.Reserveren1.Padding = new System.Windows.Forms.Padding(4);
            this.Reserveren1.Size = new System.Drawing.Size(1168, 596);
            this.Reserveren1.TabIndex = 0;
            this.Reserveren1.Text = "Reserveren 1";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Aqua;
            this.button8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(547, 22);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 39);
            this.button8.TabIndex = 42;
            this.button8.Text = "Reserveren";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(1083, 9);
            this.Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(75, 23);
            this.Account.TabIndex = 41;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = true;
            this.Account.Click += new System.EventHandler(this.Account_Click_1);
            // 
            // Recenties
            // 
            this.Recenties.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recenties.Location = new System.Drawing.Point(695, 22);
            this.Recenties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Recenties.Name = "Recenties";
            this.Recenties.Size = new System.Drawing.Size(131, 39);
            this.Recenties.TabIndex = 40;
            this.Recenties.Text = "Recensies";
            this.Recenties.UseVisualStyleBackColor = true;
            this.Recenties.Click += new System.EventHandler(this.Recenties_Click);
            // 
            // Contact
            // 
            this.Contact.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(831, 22);
            this.Contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(131, 39);
            this.Contact.TabIndex = 39;
            this.Contact.Text = "Contact";
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Thema
            // 
            this.Thema.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thema.Location = new System.Drawing.Point(279, 22);
            this.Thema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(131, 39);
            this.Thema.TabIndex = 38;
            this.Thema.Text = "Thema";
            this.Thema.UseVisualStyleBackColor = true;
            this.Thema.Click += new System.EventHandler(this.Thema_Click);
            // 
            // Tarieven
            // 
            this.Tarieven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Tarieven.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarieven.Location = new System.Drawing.Point(412, 22);
            this.Tarieven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tarieven.Name = "Tarieven";
            this.Tarieven.Size = new System.Drawing.Size(131, 39);
            this.Tarieven.TabIndex = 37;
            this.Tarieven.Text = "Tarieven";
            this.Tarieven.UseVisualStyleBackColor = false;
            this.Tarieven.Click += new System.EventHandler(this.Tarieven_Click);
            // 
            // Homepage
            // 
            this.Homepage.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homepage.Location = new System.Drawing.Point(129, 22);
            this.Homepage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(144, 39);
            this.Homepage.TabIndex = 35;
            this.Homepage.Text = "Homepage";
            this.Homepage.UseVisualStyleBackColor = true;
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // Reserveren2
            // 
            this.Reserveren2.BackColor = System.Drawing.Color.Turquoise;
            this.Reserveren2.Controls.Add(this.TimeBox);
            this.Reserveren2.Controls.Add(this.checkBox);
            this.Reserveren2.Controls.Add(this.toaccountbtn);
            this.Reserveren2.Controls.Add(this.label12);
            this.Reserveren2.Controls.Add(this.label11);
            this.Reserveren2.Controls.Add(this.yearbox);
            this.Reserveren2.Controls.Add(this.monthbox);
            this.Reserveren2.Controls.Add(this.daybox);
            this.Reserveren2.Controls.Add(this.peoplenumeric);
            this.Reserveren2.Controls.Add(this.label10);
            this.Reserveren2.Controls.Add(this.label9);
            this.Reserveren2.Controls.Add(this.label8);
            this.Reserveren2.Controls.Add(this.label7);
            this.Reserveren2.Controls.Add(this.button5);
            this.Reserveren2.Controls.Add(this.passwordtxtbox);
            this.Reserveren2.Controls.Add(this.button4);
            this.Reserveren2.Controls.Add(this.usernametxtbox);
            this.Reserveren2.Controls.Add(this.label1);
            this.Reserveren2.Location = new System.Drawing.Point(4, 25);
            this.Reserveren2.Margin = new System.Windows.Forms.Padding(4);
            this.Reserveren2.Name = "Reserveren2";
            this.Reserveren2.Padding = new System.Windows.Forms.Padding(4);
            this.Reserveren2.Size = new System.Drawing.Size(1168, 596);
            this.Reserveren2.TabIndex = 1;
            this.Reserveren2.Text = "Reserveren 2";
            // 
            // TimeBox
            // 
            this.TimeBox.AllowDrop = true;
            this.TimeBox.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.TimeBox.Location = new System.Drawing.Point(535, 288);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(152, 24);
            this.TimeBox.TabIndex = 25;
            this.TimeBox.Text = "9:00";
            this.TimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(520, 327);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(128, 21);
            this.checkBox.TabIndex = 24;
            this.checkBox.Text = "Ingelogd blijven";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // toaccountbtn
            // 
            this.toaccountbtn.Location = new System.Drawing.Point(622, 365);
            this.toaccountbtn.Margin = new System.Windows.Forms.Padding(4);
            this.toaccountbtn.Name = "toaccountbtn";
            this.toaccountbtn.Size = new System.Drawing.Size(100, 28);
            this.toaccountbtn.TabIndex = 23;
            this.toaccountbtn.Text = "Account";
            this.toaccountbtn.UseVisualStyleBackColor = true;
            this.toaccountbtn.Click += new System.EventHandler(this.toaccountbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 365);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nog geen account? Registreer hier!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tijd";
            // 
            // yearbox
            // 
            this.yearbox.Location = new System.Drawing.Point(660, 256);
            this.yearbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearbox.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearbox.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(61, 22);
            this.yearbox.TabIndex = 18;
            this.yearbox.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearbox.ValueChanged += new System.EventHandler(this.yearbox_ValueChanged);
            // 
            // monthbox
            // 
            this.monthbox.Location = new System.Drawing.Point(594, 256);
            this.monthbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthbox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(60, 22);
            this.monthbox.TabIndex = 17;
            this.monthbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthbox.ValueChanged += new System.EventHandler(this.monthbox_ValueChanged);
            // 
            // daybox
            // 
            this.daybox.Location = new System.Drawing.Point(535, 256);
            this.daybox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daybox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.daybox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(53, 22);
            this.daybox.TabIndex = 16;
            this.daybox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daybox.ValueChanged += new System.EventHandler(this.daybox_ValueChanged);
            // 
            // peoplenumeric
            // 
            this.peoplenumeric.Location = new System.Drawing.Point(535, 225);
            this.peoplenumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peoplenumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.peoplenumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.peoplenumeric.Name = "peoplenumeric";
            this.peoplenumeric.Size = new System.Drawing.Size(187, 22);
            this.peoplenumeric.TabIndex = 15;
            this.peoplenumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Datum Selecteren";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Aantal mensen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Wachtwoord";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gebruikersnaam";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(285, 429);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 106);
            this.button5.TabIndex = 9;
            this.button5.Text = "Terug naar overzicht";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(535, 195);
            this.passwordtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(248, 22);
            this.passwordtxtbox.TabIndex = 2;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.passwordtxtbox_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(704, 429);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 106);
            this.button4.TabIndex = 8;
            this.button4.Text = "Reserveren!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(535, 167);
            this.usernametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(248, 22);
            this.usernametxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Reserveren3
            // 
            this.Reserveren3.BackColor = System.Drawing.Color.Turquoise;
            this.Reserveren3.Controls.Add(this.button6);
            this.Reserveren3.Controls.Add(this.label6);
            this.Reserveren3.Location = new System.Drawing.Point(4, 25);
            this.Reserveren3.Margin = new System.Windows.Forms.Padding(4);
            this.Reserveren3.Name = "Reserveren3";
            this.Reserveren3.Padding = new System.Windows.Forms.Padding(4);
            this.Reserveren3.Size = new System.Drawing.Size(1168, 596);
            this.Reserveren3.TabIndex = 2;
            this.Reserveren3.Text = "Reserveren 3";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(463, 277);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(271, 150);
            this.button6.TabIndex = 2;
            this.button6.Text = "Terug naar overzicht";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Je reservering is verwerkt en is te zien op je account!";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(593, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 39);
            this.button7.TabIndex = 36;
            this.button7.Text = "Reserveren";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Reserveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reserveren";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Reserveren1.ResumeLayout(false);
            this.Reserveren1.PerformLayout();
            this.Reserveren2.ResumeLayout(false);
            this.Reserveren2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daybox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplenumeric)).EndInit();
            this.Reserveren3.ResumeLayout(false);
            this.Reserveren3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Reserveren1;
        private System.Windows.Forms.TabPage Reserveren2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage Reserveren3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Recenties;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button Thema;
        private System.Windows.Forms.Button Tarieven;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Homepage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown peoplenumeric;
        private System.Windows.Forms.NumericUpDown yearbox;
        private System.Windows.Forms.NumericUpDown monthbox;
        private System.Windows.Forms.NumericUpDown daybox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button toaccountbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox;
        private ComboBox TimeBox;
    }
}

