﻿using Project_B_informatie;
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
            this.Spartabtn = new System.Windows.Forms.Button();
            this.TLRbtn = new System.Windows.Forms.Button();
            this.Hauntedbtn = new System.Windows.Forms.Button();
            this.Spartapic = new System.Windows.Forms.PictureBox();
            this.TLRpic = new System.Windows.Forms.PictureBox();
            this.Hauntedpic = new System.Windows.Forms.PictureBox();
            this.PageTitle = new System.Windows.Forms.Label();
            this.Subtitlelbl = new System.Windows.Forms.Label();
            this.Spartalbl = new System.Windows.Forms.Label();
            this.TLRlbl = new System.Windows.Forms.Label();
            this.Hauntedlbl = new System.Windows.Forms.Label();
            this.Reservpagetabs = new System.Windows.Forms.TabControl();
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
            this.logincheckBox = new System.Windows.Forms.CheckBox();
            this.toaccountbtn = new System.Windows.Forms.Button();
            this.Registerlbl = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.yearbox = new System.Windows.Forms.NumericUpDown();
            this.monthbox = new System.Windows.Forms.NumericUpDown();
            this.daybox = new System.Windows.Forms.NumericUpDown();
            this.peoplenumeric = new System.Windows.Forms.NumericUpDown();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Peoplelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.overzichtbtn = new System.Windows.Forms.Button();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.Reserverenbtn = new System.Windows.Forms.Button();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.Reserverentitlelbl = new System.Windows.Forms.Label();
            this.Reserveren3 = new System.Windows.Forms.TabPage();
            this.Kortingbtn = new System.Windows.Forms.Button();
            this.overzicht2btn = new System.Windows.Forms.Button();
            this.Meldinglbl = new System.Windows.Forms.Label();
            this.Korting1 = new System.Windows.Forms.TabPage();
            this.OK_Button = new System.Windows.Forms.Button();
            this.answerlbl = new System.Windows.Forms.Label();
            this.textBox_antwoord = new System.Windows.Forms.TextBox();
            this.raadseltxtbox = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Spartapic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLRpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hauntedpic)).BeginInit();
            this.Reservpagetabs.SuspendLayout();
            this.Reserveren1.SuspendLayout();
            this.Reserveren2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daybox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplenumeric)).BeginInit();
            this.Reserveren3.SuspendLayout();
            this.Korting1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spartabtn
            // 
            this.Spartabtn.Location = new System.Drawing.Point(211, 500);
            this.Spartabtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Spartabtn.Name = "Spartabtn";
            this.Spartabtn.Size = new System.Drawing.Size(100, 28);
            this.Spartabtn.TabIndex = 0;
            this.Spartabtn.Text = "Ik kies deze!";
            this.Spartabtn.UseVisualStyleBackColor = true;
            this.Spartabtn.Click += new System.EventHandler(this.Spartabtn_Click);
            // 
            // TLRbtn
            // 
            this.TLRbtn.Location = new System.Drawing.Point(549, 500);
            this.TLRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TLRbtn.Name = "TLRbtn";
            this.TLRbtn.Size = new System.Drawing.Size(100, 28);
            this.TLRbtn.TabIndex = 1;
            this.TLRbtn.Text = "Ik kies deze!";
            this.TLRbtn.UseVisualStyleBackColor = true;
            this.TLRbtn.Click += new System.EventHandler(this.TLRbtn_Click);
            // 
            // Hauntedbtn
            // 
            this.Hauntedbtn.Location = new System.Drawing.Point(885, 500);
            this.Hauntedbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hauntedbtn.Name = "Hauntedbtn";
            this.Hauntedbtn.Size = new System.Drawing.Size(100, 28);
            this.Hauntedbtn.TabIndex = 2;
            this.Hauntedbtn.Text = "Ik kies deze!";
            this.Hauntedbtn.UseVisualStyleBackColor = true;
            this.Hauntedbtn.Click += new System.EventHandler(this.Hauntedbtn_Click);
            // 
            // Spartapic
            // 
            this.Spartapic.Image = ((System.Drawing.Image)(resources.GetObject("Spartapic.Image")));
            this.Spartapic.Location = new System.Drawing.Point(149, 197);
            this.Spartapic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Spartapic.Name = "Spartapic";
            this.Spartapic.Size = new System.Drawing.Size(221, 293);
            this.Spartapic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spartapic.TabIndex = 3;
            this.Spartapic.TabStop = false;
            // 
            // TLRpic
            // 
            this.TLRpic.Image = ((System.Drawing.Image)(resources.GetObject("TLRpic.Image")));
            this.TLRpic.Location = new System.Drawing.Point(488, 197);
            this.TLRpic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TLRpic.Name = "TLRpic";
            this.TLRpic.Size = new System.Drawing.Size(221, 293);
            this.TLRpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TLRpic.TabIndex = 4;
            this.TLRpic.TabStop = false;
            // 
            // Hauntedpic
            // 
            this.Hauntedpic.Image = ((System.Drawing.Image)(resources.GetObject("Hauntedpic.Image")));
            this.Hauntedpic.Location = new System.Drawing.Point(827, 197);
            this.Hauntedpic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hauntedpic.Name = "Hauntedpic";
            this.Hauntedpic.Size = new System.Drawing.Size(221, 293);
            this.Hauntedpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hauntedpic.TabIndex = 5;
            this.Hauntedpic.TabStop = false;
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Location = new System.Drawing.Point(557, 96);
            this.PageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(82, 17);
            this.PageTitle.TabIndex = 6;
            this.PageTitle.Text = "Reserveren";
            // 
            // Subtitlelbl
            // 
            this.Subtitlelbl.AutoSize = true;
            this.Subtitlelbl.Location = new System.Drawing.Point(457, 129);
            this.Subtitlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Subtitlelbl.Name = "Subtitlelbl";
            this.Subtitlelbl.Size = new System.Drawing.Size(283, 17);
            this.Subtitlelbl.TabIndex = 7;
            this.Subtitlelbl.Text = "Kies een escape room die je wilt reserveren";
            // 
            // Spartalbl
            // 
            this.Spartalbl.AutoSize = true;
            this.Spartalbl.Location = new System.Drawing.Point(203, 162);
            this.Spartalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Spartalbl.Name = "Spartalbl";
            this.Spartalbl.Size = new System.Drawing.Size(114, 17);
            this.Spartalbl.TabIndex = 8;
            this.Spartalbl.Text = "THIS IS SPARTA";
            // 
            // TLRlbl
            // 
            this.TLRlbl.AutoSize = true;
            this.TLRlbl.Location = new System.Drawing.Point(544, 162);
            this.TLRlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TLRlbl.Name = "TLRlbl";
            this.TLRlbl.Size = new System.Drawing.Size(109, 17);
            this.TLRlbl.TabIndex = 9;
            this.TLRlbl.Text = "THE LAST RUN";
            // 
            // Hauntedlbl
            // 
            this.Hauntedlbl.AutoSize = true;
            this.Hauntedlbl.Location = new System.Drawing.Point(869, 162);
            this.Hauntedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hauntedlbl.Name = "Hauntedlbl";
            this.Hauntedlbl.Size = new System.Drawing.Size(133, 17);
            this.Hauntedlbl.TabIndex = 10;
            this.Hauntedlbl.Text = "HAUNTED ESCAPE";
            // 
            // Reservpagetabs
            // 
            this.Reservpagetabs.Controls.Add(this.Reserveren1);
            this.Reservpagetabs.Controls.Add(this.Reserveren2);
            this.Reservpagetabs.Controls.Add(this.Reserveren3);
            this.Reservpagetabs.Controls.Add(this.Korting1);
            this.Reservpagetabs.Location = new System.Drawing.Point(1, 1);
            this.Reservpagetabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reservpagetabs.Name = "Reservpagetabs";
            this.Reservpagetabs.SelectedIndex = 0;
            this.Reservpagetabs.Size = new System.Drawing.Size(1176, 625);
            this.Reservpagetabs.TabIndex = 11;
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
            this.Reserveren1.Controls.Add(this.TLRpic);
            this.Reserveren1.Controls.Add(this.TLRlbl);
            this.Reserveren1.Controls.Add(this.Hauntedlbl);
            this.Reserveren1.Controls.Add(this.Spartapic);
            this.Reserveren1.Controls.Add(this.Spartalbl);
            this.Reserveren1.Controls.Add(this.Hauntedbtn);
            this.Reserveren1.Controls.Add(this.PageTitle);
            this.Reserveren1.Controls.Add(this.Subtitlelbl);
            this.Reserveren1.Controls.Add(this.TLRbtn);
            this.Reserveren1.Controls.Add(this.Spartabtn);
            this.Reserveren1.Controls.Add(this.Hauntedpic);
            this.Reserveren1.Location = new System.Drawing.Point(4, 25);
            this.Reserveren1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserveren1.Name = "Reserveren1";
            this.Reserveren1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Reserveren2.Controls.Add(this.logincheckBox);
            this.Reserveren2.Controls.Add(this.toaccountbtn);
            this.Reserveren2.Controls.Add(this.Registerlbl);
            this.Reserveren2.Controls.Add(this.Timelbl);
            this.Reserveren2.Controls.Add(this.yearbox);
            this.Reserveren2.Controls.Add(this.monthbox);
            this.Reserveren2.Controls.Add(this.daybox);
            this.Reserveren2.Controls.Add(this.peoplenumeric);
            this.Reserveren2.Controls.Add(this.Datelbl);
            this.Reserveren2.Controls.Add(this.Peoplelbl);
            this.Reserveren2.Controls.Add(this.Passwordlbl);
            this.Reserveren2.Controls.Add(this.Usernamelbl);
            this.Reserveren2.Controls.Add(this.overzichtbtn);
            this.Reserveren2.Controls.Add(this.passwordtxtbox);
            this.Reserveren2.Controls.Add(this.Reserverenbtn);
            this.Reserveren2.Controls.Add(this.usernametxtbox);
            this.Reserveren2.Controls.Add(this.Reserverentitlelbl);
            this.Reserveren2.Location = new System.Drawing.Point(4, 25);
            this.Reserveren2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserveren2.Name = "Reserveren2";
            this.Reserveren2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserveren2.Size = new System.Drawing.Size(1168, 596);
            this.Reserveren2.TabIndex = 1;
            this.Reserveren2.Text = "Reserveren 2";
            // 
            // TimeBox
            // 
            this.TimeBox.AllowDrop = true;
            this.TimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.TimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(152, 24);
            this.TimeBox.TabIndex = 25;
            // 
            // logincheckBox
            // 
            this.logincheckBox.AutoSize = true;
            this.logincheckBox.Location = new System.Drawing.Point(520, 327);
            this.logincheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logincheckBox.Name = "logincheckBox";
            this.logincheckBox.Size = new System.Drawing.Size(128, 21);
            this.logincheckBox.TabIndex = 24;
            this.logincheckBox.Text = "Ingelogd blijven";
            this.logincheckBox.UseVisualStyleBackColor = true;
            // 
            // toaccountbtn
            // 
            this.toaccountbtn.Location = new System.Drawing.Point(621, 366);
            this.toaccountbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toaccountbtn.Name = "toaccountbtn";
            this.toaccountbtn.Size = new System.Drawing.Size(100, 28);
            this.toaccountbtn.TabIndex = 23;
            this.toaccountbtn.Text = "Account";
            this.toaccountbtn.UseVisualStyleBackColor = true;
            this.toaccountbtn.Click += new System.EventHandler(this.toaccountbtn_Click);
            // 
            // Registerlbl
            // 
            this.Registerlbl.AutoSize = true;
            this.Registerlbl.Location = new System.Drawing.Point(353, 372);
            this.Registerlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registerlbl.Name = "Registerlbl";
            this.Registerlbl.Size = new System.Drawing.Size(233, 17);
            this.Registerlbl.TabIndex = 22;
            this.Registerlbl.Text = "Nog geen account? Registreer hier!";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Location = new System.Drawing.Point(467, 288);
            this.Timelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(31, 17);
            this.Timelbl.TabIndex = 21;
            this.Timelbl.Text = "Tijd";
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
            this.monthbox.Location = new System.Drawing.Point(595, 256);
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
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(377, 256);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(121, 17);
            this.Datelbl.TabIndex = 14;
            this.Datelbl.Text = "Datum Selecteren";
            // 
            // Peoplelbl
            // 
            this.Peoplelbl.AutoSize = true;
            this.Peoplelbl.Location = new System.Drawing.Point(396, 225);
            this.Peoplelbl.Name = "Peoplelbl";
            this.Peoplelbl.Size = new System.Drawing.Size(102, 17);
            this.Peoplelbl.TabIndex = 12;
            this.Peoplelbl.Text = "Aantal mensen";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(412, 199);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(86, 17);
            this.Passwordlbl.TabIndex = 11;
            this.Passwordlbl.Text = "Wachtwoord";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Location = new System.Drawing.Point(385, 171);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(113, 17);
            this.Usernamelbl.TabIndex = 10;
            this.Usernamelbl.Text = "Gebruikersnaam";
            // 
            // overzichtbtn
            // 
            this.overzichtbtn.Location = new System.Drawing.Point(285, 430);
            this.overzichtbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overzichtbtn.Name = "overzichtbtn";
            this.overzichtbtn.Size = new System.Drawing.Size(213, 106);
            this.overzichtbtn.TabIndex = 9;
            this.overzichtbtn.Text = "Terug naar overzicht";
            this.overzichtbtn.UseVisualStyleBackColor = true;
            this.overzichtbtn.Click += new System.EventHandler(this.overzichtbtn_Click);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(535, 194);
            this.passwordtxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(248, 22);
            this.passwordtxtbox.TabIndex = 2;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.passwordtxtbox_TextChanged);
            // 
            // Reserverenbtn
            // 
            this.Reserverenbtn.Location = new System.Drawing.Point(704, 430);
            this.Reserverenbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserverenbtn.Name = "Reserverenbtn";
            this.Reserverenbtn.Size = new System.Drawing.Size(179, 106);
            this.Reserverenbtn.TabIndex = 8;
            this.Reserverenbtn.Text = "Reserveren!";
            this.Reserverenbtn.UseVisualStyleBackColor = true;
            this.Reserverenbtn.Click += new System.EventHandler(this.Reserverenbtn_Click);
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(535, 167);
            this.usernametxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(248, 22);
            this.usernametxtbox.TabIndex = 0;
            // 
            // Reserverentitlelbl
            // 
            this.Reserverentitlelbl.AutoSize = true;
            this.Reserverentitlelbl.Location = new System.Drawing.Point(404, 102);
            this.Reserverentitlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reserverentitlelbl.Name = "Reserverentitlelbl";
            this.Reserverentitlelbl.Size = new System.Drawing.Size(46, 17);
            this.Reserverentitlelbl.TabIndex = 0;
            this.Reserverentitlelbl.Text = "label1";
            // 
            // Reserveren3
            // 
            this.Reserveren3.BackColor = System.Drawing.Color.Turquoise;
            this.Reserveren3.Controls.Add(this.Kortingbtn);
            this.Reserveren3.Controls.Add(this.overzicht2btn);
            this.Reserveren3.Controls.Add(this.Meldinglbl);
            this.Reserveren3.Location = new System.Drawing.Point(4, 25);
            this.Reserveren3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserveren3.Name = "Reserveren3";
            this.Reserveren3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserveren3.Size = new System.Drawing.Size(1168, 596);
            this.Reserveren3.TabIndex = 2;
            this.Reserveren3.Text = "Reserveren 3";
            // 
            // Kortingbtn
            // 
            this.Kortingbtn.Location = new System.Drawing.Point(507, 203);
            this.Kortingbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kortingbtn.Name = "Kortingbtn";
            this.Kortingbtn.Size = new System.Drawing.Size(193, 34);
            this.Kortingbtn.TabIndex = 5;
            this.Kortingbtn.TabStop = false;
            this.Kortingbtn.Text = "Extra korting? Klik Hier!";
            this.Kortingbtn.UseVisualStyleBackColor = true;
            this.Kortingbtn.Click += new System.EventHandler(this.Korting_Click);
            // 
            // overzicht2btn
            // 
            this.overzicht2btn.Location = new System.Drawing.Point(463, 277);
            this.overzicht2btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overzicht2btn.Name = "overzicht2btn";
            this.overzicht2btn.Size = new System.Drawing.Size(271, 150);
            this.overzicht2btn.TabIndex = 2;
            this.overzicht2btn.Text = "Terug naar overzicht";
            this.overzicht2btn.UseVisualStyleBackColor = true;
            this.overzicht2btn.Click += new System.EventHandler(this.overzicht2btn_Click);
            // 
            // Meldinglbl
            // 
            this.Meldinglbl.AutoSize = true;
            this.Meldinglbl.Location = new System.Drawing.Point(429, 167);
            this.Meldinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Meldinglbl.Name = "Meldinglbl";
            this.Meldinglbl.Size = new System.Drawing.Size(342, 17);
            this.Meldinglbl.TabIndex = 1;
            this.Meldinglbl.Text = "Je reservering is verwerkt en is te zien op je account!";
            // 
            // Korting1
            // 
            this.Korting1.BackColor = System.Drawing.Color.Turquoise;
            this.Korting1.Controls.Add(this.OK_Button);
            this.Korting1.Controls.Add(this.answerlbl);
            this.Korting1.Controls.Add(this.textBox_antwoord);
            this.Korting1.Controls.Add(this.raadseltxtbox);
            this.Korting1.Location = new System.Drawing.Point(4, 25);
            this.Korting1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Korting1.Name = "Korting1";
            this.Korting1.Size = new System.Drawing.Size(1168, 596);
            this.Korting1.TabIndex = 3;
            this.Korting1.Text = "Korting";
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(668, 356);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 12;
            this.OK_Button.Text = "Ok";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // answerlbl
            // 
            this.answerlbl.AutoSize = true;
            this.answerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerlbl.Location = new System.Drawing.Point(427, 353);
            this.answerlbl.Name = "answerlbl";
            this.answerlbl.Size = new System.Drawing.Size(101, 25);
            this.answerlbl.TabIndex = 11;
            this.answerlbl.Text = "Antwoord:";
            // 
            // textBox_antwoord
            // 
            this.textBox_antwoord.Location = new System.Drawing.Point(535, 356);
            this.textBox_antwoord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_antwoord.Name = "textBox_antwoord";
            this.textBox_antwoord.Size = new System.Drawing.Size(103, 22);
            this.textBox_antwoord.TabIndex = 2;
            // 
            // raadseltxtbox
            // 
            this.raadseltxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raadseltxtbox.AutoWordSelection = true;
            this.raadseltxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raadseltxtbox.Location = new System.Drawing.Point(330, 203);
            this.raadseltxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raadseltxtbox.Name = "raadseltxtbox";
            this.raadseltxtbox.Size = new System.Drawing.Size(543, 106);
            this.raadseltxtbox.TabIndex = 1;
            this.raadseltxtbox.Text = "Een Escape room samen met de drankjes kost € 110,-.\nDe Escape room is € 100,- mee" +
    "r dan de drankjes. \nHoeveel kost de Escape room?";
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
            this.Controls.Add(this.Reservpagetabs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reserveren";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Spartapic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLRpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hauntedpic)).EndInit();
            this.Reservpagetabs.ResumeLayout(false);
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
            this.Korting1.ResumeLayout(false);
            this.Korting1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Spartabtn;
        private System.Windows.Forms.Button TLRbtn;
        private System.Windows.Forms.Button Hauntedbtn;
        private System.Windows.Forms.PictureBox Spartapic;
        private System.Windows.Forms.PictureBox TLRpic;
        private System.Windows.Forms.PictureBox Hauntedpic;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.Label Subtitlelbl;
        private System.Windows.Forms.Label Spartalbl;
        private System.Windows.Forms.Label TLRlbl;
        private System.Windows.Forms.Label Hauntedlbl;
        private System.Windows.Forms.TabControl Reservpagetabs;
        private System.Windows.Forms.TabPage Reserveren1;
        private System.Windows.Forms.TabPage Reserveren2;
        private System.Windows.Forms.Label Reserverentitlelbl;
        private System.Windows.Forms.Button Reserverenbtn;
        private System.Windows.Forms.Button overzichtbtn;
        private System.Windows.Forms.TabPage Reserveren3;
        private System.Windows.Forms.Label Meldinglbl;
        private System.Windows.Forms.Button overzicht2btn;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Recenties;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button Thema;
        private System.Windows.Forms.Button Tarieven;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Homepage;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Peoplelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.NumericUpDown peoplenumeric;
        private System.Windows.Forms.NumericUpDown yearbox;
        private System.Windows.Forms.NumericUpDown monthbox;
        private System.Windows.Forms.NumericUpDown daybox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Button toaccountbtn;
        private System.Windows.Forms.Label Registerlbl;
        private System.Windows.Forms.CheckBox logincheckBox;
        private System.Windows.Forms.Button Kortingbtn;
        private System.Windows.Forms.TabPage Korting1;
        private System.Windows.Forms.RichTextBox raadseltxtbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label answerlbl;
        private System.Windows.Forms.TextBox textBox_antwoord;
        private System.Windows.Forms.Button OK_Button;
        private ComboBox TimeBox;
    }
}

