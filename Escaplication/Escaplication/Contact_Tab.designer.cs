namespace Escaplication
{
    partial class Contact_Tab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Tab));
            this.Recenties = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.Thema = new System.Windows.Forms.Button();
            this.Tarieven = new System.Windows.Forms.Button();
            this.Reserveren = new System.Windows.Forms.Button();
            this.Homepage = new System.Windows.Forms.Button();
            this.GoogleMapsRedirectlabel = new System.Windows.Forms.LinkLabel();
            this.RoutePlanner = new System.Windows.Forms.WebBrowser();
            this.Contactgegevenstxtbox = new System.Windows.Forms.RichTextBox();
            this.Openingstijdentxtbox = new System.Windows.Forms.RichTextBox();
            this.LogoHRLocatie = new System.Windows.Forms.PictureBox();
            this.Account = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHRLocatie)).BeginInit();
            this.SuspendLayout();
            // 
            // Recenties
            // 
            this.Recenties.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recenties.Location = new System.Drawing.Point(750, 25);
            this.Recenties.Name = "Recenties";
            this.Recenties.Size = new System.Drawing.Size(131, 39);
            this.Recenties.TabIndex = 29;
            this.Recenties.Text = "Recensies";
            this.Recenties.UseVisualStyleBackColor = true;
            this.Recenties.Click += new System.EventHandler(this.Recenties_Click);
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.Aqua;
            this.Contact.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(900, 25);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(131, 39);
            this.Contact.TabIndex = 28;
            this.Contact.Text = "Contact";
            this.Contact.UseVisualStyleBackColor = false;
            // 
            // Thema
            // 
            this.Thema.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thema.Location = new System.Drawing.Point(300, 25);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(131, 39);
            this.Thema.TabIndex = 27;
            this.Thema.Text = "Thema";
            this.Thema.UseVisualStyleBackColor = true;
            this.Thema.Click += new System.EventHandler(this.Thema_Click);
            // 
            // Tarieven
            // 
            this.Tarieven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Tarieven.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarieven.Location = new System.Drawing.Point(450, 25);
            this.Tarieven.Name = "Tarieven";
            this.Tarieven.Size = new System.Drawing.Size(131, 39);
            this.Tarieven.TabIndex = 26;
            this.Tarieven.Text = "Tarieven";
            this.Tarieven.UseVisualStyleBackColor = false;
            this.Tarieven.Click += new System.EventHandler(this.Tarieven_Click);
            // 
            // Reserveren
            // 
            this.Reserveren.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserveren.Location = new System.Drawing.Point(600, 25);
            this.Reserveren.Name = "Reserveren";
            this.Reserveren.Size = new System.Drawing.Size(144, 39);
            this.Reserveren.TabIndex = 25;
            this.Reserveren.Text = "Reserveren";
            this.Reserveren.UseVisualStyleBackColor = true;
            this.Reserveren.Click += new System.EventHandler(this.Reserveren_Click);
            // 
            // Homepage
            // 
            this.Homepage.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homepage.Location = new System.Drawing.Point(150, 25);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(131, 39);
            this.Homepage.TabIndex = 24;
            this.Homepage.Text = "Homepage";
            this.Homepage.UseVisualStyleBackColor = true;
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // GoogleMapsRedirectlabel
            // 
            this.GoogleMapsRedirectlabel.AutoSize = true;
            this.GoogleMapsRedirectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleMapsRedirectlabel.Location = new System.Drawing.Point(144, 426);
            this.GoogleMapsRedirectlabel.Name = "GoogleMapsRedirectlabel";
            this.GoogleMapsRedirectlabel.Size = new System.Drawing.Size(209, 29);
            this.GoogleMapsRedirectlabel.TabIndex = 31;
            this.GoogleMapsRedirectlabel.TabStop = true;
            this.GoogleMapsRedirectlabel.Text = "Plan hier via Maps";
            this.GoogleMapsRedirectlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoogleMapsRedirectlabel_LinkClicked);
            // 
            // RoutePlanner
            // 
            this.RoutePlanner.Location = new System.Drawing.Point(149, 61);
            this.RoutePlanner.MinimumSize = new System.Drawing.Size(20, 20);
            this.RoutePlanner.Name = "RoutePlanner";
            this.RoutePlanner.Size = new System.Drawing.Size(888, 362);
            this.RoutePlanner.TabIndex = 32;
            this.RoutePlanner.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Contactgegevenstxtbox
            // 
            this.Contactgegevenstxtbox.BackColor = System.Drawing.Color.White;
            this.Contactgegevenstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactgegevenstxtbox.Location = new System.Drawing.Point(151, 462);
            this.Contactgegevenstxtbox.Name = "Contactgegevenstxtbox";
            this.Contactgegevenstxtbox.Size = new System.Drawing.Size(330, 161);
            this.Contactgegevenstxtbox.TabIndex = 33;
            this.Contactgegevenstxtbox.Text = "Plaats: Wijnhaven 107\nTelefoonnummer: 010 794 4000\nE-mail: Info@HR.nl\nPostcode: 3" +
    "011 WN Rotterdam\n";
            // 
            // Openingstijdentxtbox
            // 
            this.Openingstijdentxtbox.BackColor = System.Drawing.Color.White;
            this.Openingstijdentxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Openingstijdentxtbox.Location = new System.Drawing.Point(623, 426);
            this.Openingstijdentxtbox.Name = "Openingstijdentxtbox";
            this.Openingstijdentxtbox.Size = new System.Drawing.Size(413, 205);
            this.Openingstijdentxtbox.TabIndex = 34;
            this.Openingstijdentxtbox.Text = resources.GetString("Openingstijdentxtbox.Text");
            // 
            // LogoHRLocatie
            // 
            this.LogoHRLocatie.Image = ((System.Drawing.Image)(resources.GetObject("LogoHRLocatie.Image")));
            this.LogoHRLocatie.Location = new System.Drawing.Point(0, 2);
            this.LogoHRLocatie.Name = "LogoHRLocatie";
            this.LogoHRLocatie.Size = new System.Drawing.Size(149, 156);
            this.LogoHRLocatie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoHRLocatie.TabIndex = 35;
            this.LogoHRLocatie.TabStop = false;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(1090, 12);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(75, 23);
            this.Account.TabIndex = 36;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = true;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Contact_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.LogoHRLocatie);
            this.Controls.Add(this.Openingstijdentxtbox);
            this.Controls.Add(this.Contactgegevenstxtbox);
            this.Controls.Add(this.RoutePlanner);
            this.Controls.Add(this.GoogleMapsRedirectlabel);
            this.Controls.Add(this.Recenties);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Thema);
            this.Controls.Add(this.Tarieven);
            this.Controls.Add(this.Reserveren);
            this.Controls.Add(this.Homepage);
            this.Name = "Contact_Tab";
            this.Text = "Contact_Tab";
            this.Load += new System.EventHandler(this.Contact_Tab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoHRLocatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Recenties;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button Thema;
        private System.Windows.Forms.Button Tarieven;
        private System.Windows.Forms.Button Reserveren;
        private System.Windows.Forms.Button Homepage;
        private System.Windows.Forms.LinkLabel GoogleMapsRedirectlabel;
        private System.Windows.Forms.WebBrowser RoutePlanner;
        private System.Windows.Forms.RichTextBox Contactgegevenstxtbox;
        private System.Windows.Forms.RichTextBox Openingstijdentxtbox;
        private System.Windows.Forms.PictureBox LogoHRLocatie;
        private System.Windows.Forms.Button Account;
    }
}