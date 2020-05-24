using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project_B_informatie;

namespace Escaplication
{
    public partial class Recensie : Form
    {

        public string[] checkpassword;
        public static string pathh = Application.StartupPath + "\\Recensies\\";
        public static string[] RecensiePath = Directory.GetFiles(pathh);

        public Recensie()
        {
            InitializeComponent();
            checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            if (Convert.ToBoolean(checkpassword[0]) == true)
            {
                Gbnaam.Dispose();
                Wachtwoord.Dispose();
                checkBox.Dispose();
                Gebruikersnaamtxt.Dispose();
                Wachtwoordtxt.Dispose();
            }

        }
        public void RecensieLoad(object sender, EventArgs e)
        {
            int totalfiles = Directory.GetFiles(pathh).Length;

            if (totalfiles > 0)
            {
                RecensieMaker(totalfiles);
            }

        }

        public void RecensieUser(string Gebruikersnaamtext, string Wachtwoordtext)
        {
            string pathGebruikers = Application.StartupPath + "\\Gebruikers\\" + Gebruikersnaamtext + ".txt";
            var ster = Int32.Parse(sterrentxt.Text);

            if (File.Exists(pathGebruikers))
            {
                string[] lines = File.ReadAllLines(pathGebruikers);
                if (lines[0] == Gebruikersnaamtext)
                {
                    if (lines[1] == Wachtwoordtext)
                    {
                        if (Convert.ToBoolean(checkpassword[0]) == false)
                        {
                            StreamWriter WriteText = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                            if (checkBox.Checked)
                            { 
                                WriteText.WriteLine("true"); 
                            }

                            else {WriteText.WriteLine("false");}

                            WriteText.WriteLine(Gebruikersnaamtext);
                            WriteText.WriteLine(Wachtwoordtext);
                            WriteText.Close();
                        }
                        if (ster >= 0 && ster <= 5)
                        {
                            WriteRecensieFile();
                        }
                        else   {  messagebox("Typ een getal tussen 0-5 bij sterren"); }
                    }
                    else   { messagebox("Wachtwoord onjuist");  }
                }
            }
            else {messagebox("Gebruikersnaam niet gevonden"); }
        }
        public string folder;
        public void WriteRecensieFile()
        {
            StreamWriter WriteText = new StreamWriter(Application.StartupPath + "\\Recensies\\" + Gebruikersnaamtxt.Text + ".txt");
            WriteText.WriteLine(Gebruikersnaamtxt.Text);
            WriteText.WriteLine(kamertxt.Text);
            WriteText.WriteLine(commentaartxt.Text);
            WriteText.WriteLine(sterrentxt.Text);
            WriteText.Close();
            messagebox("Recensie voltooid");
        }

        public void messagebox(string text)
        {
            MessageBox.Show(text);
        }

        public void RecensieMaker(int totalfiles)
        {
            for (int i = 0, LocPointGB = 15, LocPointTB = 51, LocPointLabel = 18, LocPointSter = 24; i < totalfiles; i++, LocPointGB += 150, LocPointTB += 150, LocPointLabel += 150)
            {
                RecensiePath = Directory.GetFiles(pathh);
                string[] ArrayRecensies = File.ReadAllLines(Convert.ToString(RecensiePath[i]));

                GroupBox recensiegb = new GroupBox();
                recensiegb.Name = "";
                recensiegb.Size = new Size(432, 145);
                recensiegb.Location = new Point(3, LocPointGB);
                recensiegb.TabIndex = 0;
                recensiegb.TabStop = false;
                recensiegb.Text = ArrayRecensies[0];

                RichTextBox commentaar = new RichTextBox();
                commentaar.Text = ArrayRecensies[2];
                commentaar.Location = new Point(91, LocPointTB);
                commentaar.Size = new Size(270, 49);

                Label naamkamer = new Label();
                naamkamer.AutoSize = true;
                naamkamer.Location = new Point(182, LocPointLabel);
                naamkamer.Size = new Size(63, 13);
                naamkamer.Name = "Kamernaam";
                naamkamer.Text = ArrayRecensies[1];

                Label ster = new Label();
                ster.AutoSize = true;
                ster.Location = new Point(8, LocPointSter);
                ster.Margin = new Padding(4, 0, 4, 0);
                ster.Name = "label5";
                ster.Size = new Size(63, 13);
                ster.TabIndex = 6;
                ster.Text = "Sterren " + ArrayRecensies[3] + "/5";

                ScrollPanel.Controls.Add(naamkamer);
                ScrollPanel.Controls.Add(commentaar);
                ScrollPanel.Controls.Add(recensiegb);
                recensiegb.Controls.Add(ster);
            }
        }

        

        private void Homepage_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Homepage" drukt, deze teruggaat naar het begin scherm.

            var Hoofd = new HoofdMenu();
            this.Hide();
            Hoofd.ShowDialog();
            this.Close();
        }
        private void Thema_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Thema" drukt, deze doorgaat naar het informatie scherm.

            var thema = new Informatie();
            this.Hide();
            thema.ShowDialog();
            this.Close();
        }



        private void Tarieven_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Tarieven" drukt, deze doorgaat naar het Tarieven scherm.

            var tarief = new Tarieven_Tab();
            this.Hide();
            tarief.ShowDialog();
            this.Close();
        }


        private void Reserveren_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Reserveren" drukt, deze doorgaat naar het reservatie scherm.

            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Contact" drukt, deze doorgaat naar het contact scherm.

            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Acount" drukt, deze doorgaat naar het login scherm.

            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Wachtwoordtxt_TextChanged(object sender, EventArgs e)
        {
            Wachtwoordtxt.PasswordChar = '●';
        }
    }
}
