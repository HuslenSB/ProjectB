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
 
namespace Escaplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Als file \gebruikers niet bestaat, create file \gebruikers.

            if (!Directory.Exists(Application.StartupPath + "\\Gebruikers\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Gebruikers\\");
            }
        }
 
        private void Login_Load(object sender, EventArgs e)
        {
 
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

