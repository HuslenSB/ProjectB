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
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;
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

            var Accountpagina = new Accountpagina();
            this.Hide();
            Accountpagina.ShowDialog();
            this.Close();

        } 
        private void daybox_ValueChanged(object sender, EventArgs e)
        {
            if ((int)monthbox.Value == 4 || (int)monthbox.Value == 6 || (int)monthbox.Value == 9 || (int)monthbox.Value == 11)
            {
                daybox.Maximum = 30;
            }
            else if((int)monthbox.Value == 1 || (int)monthbox.Value == 3 || (int)monthbox.Value == 5 || (int)monthbox.Value == 7 || (int)monthbox.Value == 8 || (int)monthbox.Value == 10 || (int)monthbox.Value == 12)
            {
                daybox.Maximum = 31;
            }
            if (((int)yearbox.Value % 4 == 0 || (int)yearbox.Value % 100 == 0 && (int)yearbox.Value % 400 == 0) && (int)monthbox.Value == 2)
            {
                daybox.Maximum = 29;
            }
            else if ((int)monthbox.Value == 2)
            {
                daybox.Maximum = 28;
            }
        }

        private void monthbox_ValueChanged(object sender, EventArgs e)
        {
            if ((int)monthbox.Value == 4 || (int)monthbox.Value == 6 || (int)monthbox.Value == 9 || (int)monthbox.Value == 11)
            {
                daybox.Maximum = 30;
            }
            else if ((int)monthbox.Value == 1 || (int)monthbox.Value == 3 || (int)monthbox.Value == 5 || (int)monthbox.Value == 7 || (int)monthbox.Value == 8 || (int)monthbox.Value == 10 || (int)monthbox.Value == 12)
            {
                daybox.Maximum = 31;
            }
            if (((int)yearbox.Value % 4 == 0 || (int)yearbox.Value % 100 == 0 && (int)yearbox.Value % 400 == 0) && (int)monthbox.Value == 2)
            {
                daybox.Maximum = 29;
            }
            else if ((int)monthbox.Value == 2)
            {
                daybox.Maximum = 28;
            }

        }

        private void yearbox_ValueChanged(object sender, EventArgs e)
        {
            if ((int)monthbox.Value == 4 || (int)monthbox.Value == 6 || (int)monthbox.Value == 9 || (int)monthbox.Value == 11)
            {
                daybox.Maximum = 30;
            }
            else if ((int)monthbox.Value == 1 || (int)monthbox.Value == 3 || (int)monthbox.Value == 5 || (int)monthbox.Value == 7 || (int)monthbox.Value == 8 || (int)monthbox.Value == 10 || (int)monthbox.Value == 12)
            {
                daybox.Maximum = 31;
            }
            if (((int)yearbox.Value % 4 == 0 || (int)yearbox.Value % 100 == 0 && (int)yearbox.Value % 400 == 0) && (int)monthbox.Value == 2)
            {
                daybox.Maximum = 29;
            }
            else if ((int)monthbox.Value == 2)
            {
                daybox.Maximum = 28;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usernametxt = usernametxtbox.Text;
            passwordtxt = passwordtxtbox.Text;
            peopletxt = peopletxtbox.Text;
            string path = Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt";

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                {
                    DateTime date1 = new DateTime((int)yearbox.Value, (int)monthbox.Value, (int)daybox.Value);
                    DateTime date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    int datecomparinson = DateTime.Compare(date1, date2);
                    if (datecomparinson > 0) {
                        if (lines[0] == usernametxt && lines[1] == passwordtxt)
                        {
                            using (StreamWriter ac = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt"))
                            {
                                ac.WriteLine(chosenroom);
                                ac.WriteLine(peopletxt);
                                ac.WriteLine(yearbox.Value);
                                ac.WriteLine(monthbox.Value);
                                ac.WriteLine(daybox.Value);
                            }
                            tabControl1.SelectTab(2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("De datum die je hebt gekozen is niet beschikbaar");
                    }
                    if(lines[0] != usernametxt || lines[1] != passwordtxt)
                    {
                        MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
                    }

                }
            }
            else
            {
                MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
            }
        }
    }
}
