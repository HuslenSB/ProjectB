namespace Escaplication
{
    partial class Recensie
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sterrentxt = new System.Windows.Forms.TextBox();
            this.Gebruikersnaamtxt = new System.Windows.Forms.TextBox();
            this.Gbnaam = new System.Windows.Forms.Label();
            this.Recensiebtn = new System.Windows.Forms.Button();
            this.commentaartxt = new System.Windows.Forms.TextBox();
            this.kamertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sterrentxt);
            this.groupBox2.Controls.Add(this.Gebruikersnaamtxt);
            this.groupBox2.Controls.Add(this.Gbnaam);
            this.groupBox2.Controls.Add(this.Recensiebtn);
            this.groupBox2.Controls.Add(this.commentaartxt);
            this.groupBox2.Controls.Add(this.kamertxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schrijf een recensie";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sterrentxt
            // 
            this.sterrentxt.Location = new System.Drawing.Point(144, 106);
            this.sterrentxt.Name = "sterrentxt";
            this.sterrentxt.Size = new System.Drawing.Size(55, 20);
            this.sterrentxt.TabIndex = 8;
            // 
            // Gebruikersnaamtxt
            // 
            this.Gebruikersnaamtxt.Location = new System.Drawing.Point(144, 18);
            this.Gebruikersnaamtxt.Name = "Gebruikersnaamtxt";
            this.Gebruikersnaamtxt.Size = new System.Drawing.Size(217, 20);
            this.Gebruikersnaamtxt.TabIndex = 7;
            // 
            // Gbnaam
            // 
            this.Gbnaam.AutoSize = true;
            this.Gbnaam.Location = new System.Drawing.Point(9, 25);
            this.Gbnaam.Name = "Gbnaam";
            this.Gbnaam.Size = new System.Drawing.Size(84, 13);
            this.Gbnaam.TabIndex = 6;
            this.Gbnaam.Text = "Gebruikersnaam";
            // 
            // Recensiebtn
            // 
            this.Recensiebtn.Location = new System.Drawing.Point(176, 137);
            this.Recensiebtn.Name = "Recensiebtn";
            this.Recensiebtn.Size = new System.Drawing.Size(110, 23);
            this.Recensiebtn.TabIndex = 5;
            this.Recensiebtn.Text = "Verstuur recensie";
            this.Recensiebtn.UseVisualStyleBackColor = true;
            this.Recensiebtn.Click += new System.EventHandler(this.Recensiebtn_Click);
            // 
            // commentaartxt
            // 
            this.commentaartxt.Location = new System.Drawing.Point(144, 78);
            this.commentaartxt.Name = "commentaartxt";
            this.commentaartxt.Size = new System.Drawing.Size(217, 20);
            this.commentaartxt.TabIndex = 4;
            this.commentaartxt.TextChanged += new System.EventHandler(this.commentaartxt_TextChanged);
            // 
            // kamertxt
            // 
            this.kamertxt.Location = new System.Drawing.Point(144, 50);
            this.kamertxt.Name = "kamertxt";
            this.kamertxt.Size = new System.Drawing.Size(217, 20);
            this.kamertxt.TabIndex = 3;
            this.kamertxt.TextChanged += new System.EventHandler(this.kamertxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aantal sterren 0-5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Commentaar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam van kamer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sterren 4/5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(205, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(91, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 52);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Ago tijd wel een mier toch doel. Krachtiger monopolies verwachten begrenzing nu b" +
    "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Location = new System.Drawing.Point(3, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(205, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sterren 4/5";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(91, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(270, 49);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Ago tijd wel een mier toch doel. Krachtiger monopolies verwachten begrenzing nu b" +
    "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(6, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 544);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(397, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 568);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "TEST YOUR SKILLS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Recensie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Recensie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commentaartxt;
        private System.Windows.Forms.TextBox kamertxt;
        private System.Windows.Forms.Button Recensiebtn;
        private System.Windows.Forms.TextBox Gebruikersnaamtxt;
        private System.Windows.Forms.Label Gbnaam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sterrentxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

