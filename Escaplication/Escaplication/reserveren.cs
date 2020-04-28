using Project_B_informatie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaplication
{
    public partial class Reserveren : Form
    {
        public string usernametxt, passwordtxt, peopletxt, chosenroom;
        public string[] lines;
        public Reserveren()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.label1.Text = "Leuk dat je hebt gekozen voor de Sparta escape room!";
            chosenroom = "Sparta";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.label1.Text = "Leuk dat je hebt gekozen voor de Last run escape room!";
            chosenroom = "The last run";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.label1.Text = "Leuk dat je hebt gekozen voor de Haunted escape, escape room!";
            chosenroom = "Haunted escape";
        }

        private void PageTitle_Click(object sender, EventArgs e)
        {

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



        private void Recenties_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Recenties" drukt, deze doorgaat naar het recenties scherm.

            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
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

            var Login = new Login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Account_Click_1(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Acount" drukt, deze doorgaat naar het login scherm.

            var Login = new Login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Accountpagina f1 = new Accountpagina();
            f1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            usernametxt = usernametxtbox.Text;
            passwordtxt = passwordtxtbox.Text;
            peopletxt = peopletxtbox.Text;
            string path = Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt";

            if (System.IO.File.Exists(path))
            {
                lines = System.IO.File.ReadAllLines(path);
                {
                    if (lines[0] == usernametxt && lines[1] == passwordtxt)
                    {
                        using (StreamWriter ac = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt"))
                        {
                            ac.WriteLine(chosenroom);
                        }
                        lines = File.ReadAllLines(path);
                        Console.WriteLine(lines.Length);
                    }
                    else
                    {
                        MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
                    }

                }
            }

        }
    }
}
