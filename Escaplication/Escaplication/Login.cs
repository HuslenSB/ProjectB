using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_B_informatie;

namespace Escaplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Als file \gebruikers niet bestaat, create file \gebruikers.

            if (!Directory.Exists(Application.StartupPath + "\\Gebruikers\\")&& !Directory.Exists(Environment.CurrentDirectory + "/Recensies/"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Gebruikers\\");
                Directory.CreateDirectory(Environment.CurrentDirectory + "/Recensies/");
                StreamWriter StrWriter = new StreamWriter(Application.StartupPath + "\\Recensies\\" + "Test.txt");
                StrWriter.WriteLine("Huslen");
                StrWriter.WriteLine("Sparta");
                StrWriter.WriteLine("Leuke kamer!");
                StrWriter.WriteLine("5");
                StrWriter.Close();
            }
    
        }
 


        // Maakt een txt file aan in de gebruikers file bij het registreren. Gebruikersnaam + ".txt" == txt file naam.
        // In
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if (RegisterWW.Text == RegisterWW2.Text)
            {
                StreamWriter StrWriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + RegisterGebruikersnaam.Text + ".txt");
                StrWriter.WriteLine(RegisterGebruikersnaam.Text);
                StrWriter.WriteLine(RegisterWW.Text);
                StrWriter.Close();
                MessageBox.Show("Registreren voltooid");
            }
            else
            {
                MessageBox.Show("Wachtwoorden komen niet overeen");
            }
        }
 
        // Lijn 0 en 1 van de txt file worden in [] users gestopt. Lijn 0 == gebruikersnaam, 1 == wachtwoord.
         
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Gebruikers\\" + Gebruikersnaamtxt.Text + ".txt";
 
            if (File.Exists(path))
            {
                string[] users = File.ReadAllLines(path);

                using (StreamReader sr = new StreamReader(path))
               
                if (users[0] == Gebruikersnaamtxt.Text && users[1] == Wachtwoordtxt.Text)
                {
                    Recensie f1 = new Recensie();
                    f1.Show();
                }
                else if (users[0]== Gebruikersnaamtxt.Text && users[1] != Wachtwoordtxt.Text)
                {
                    MessageBox.Show("Password incorrect try again");
                }
                
            }
            else 
            {
                MessageBox.Show("Gebruikersnaam niet gevonden, probeer opnieuw.\nRegistreer als u nog geen account heeft");
            }    

        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Homepage" drukt, deze terug gaat naar het start scherm.

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
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Reserveren" drukt, deze doorgaat naar het reserveren scherm.

            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }
        private void Recenties_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Recenties" drukt, deze doorgaat naar het Recensie scherm.

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
    }
}

