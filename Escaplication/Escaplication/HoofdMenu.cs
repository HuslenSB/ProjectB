using Project_B_informatie;
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

namespace Escaplication
{
    public partial class HoofdMenu : Form
    {
        public HoofdMenu()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + "\\Gebruikers\\") && !Directory.Exists(Environment.CurrentDirectory + "/Recensies/"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Gebruikers\\");
                Directory.CreateDirectory(Environment.CurrentDirectory + "/Recensies/");
                File.Create(Application.StartupPath + "\\Gebruikers\\" + "Account.txt");
                StreamWriter StrWriter = new StreamWriter(Application.StartupPath + "\\Recensies\\" + "Test.txt");
                StrWriter.WriteLine("Huslen");
                StrWriter.WriteLine("Sparta");
                StrWriter.WriteLine("Leuke kamer!");
                StrWriter.WriteLine("5");
                StrWriter.Close();
            }
        }
        //Escape room informatie link
        private void Label1_Click(object sender, EventArgs e)
        {
            Close();
            //Code voor openen form Informatie
        }

        private void Informatie_Click(object sender, EventArgs e)
        {
            Close();
            //Code voor openen form Informatie
        }
        //Locatie en contactgegevens link
        private void LocatieContact_Click(object sender, EventArgs e)
        {
            Close();
            //Code voor openen form Contact
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            Close();
            //Code voor openen form Contact
        }
        //Resereer link
        private void Reserveren_Click(object sender, EventArgs e)
        { 
            Close();
            Reserveren f2 = new Reserveren();
            f2.ShowDialog();

        }

        private void Reserveertekst_Click(object sender, EventArgs e)
        {
            Close();
            Reserveren f2 = new Reserveren();
            f2.ShowDialog();
        }

        //Escape room Recensies
        private void Recensies_Click(object sender, EventArgs e)
        {
            Close();
            //Code voor openen form Recensies
        }

        private void RecensieText_Click(object sender, EventArgs e)
        {
            Close();
            //Code voor openen form Recensies
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
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Tarieven" drukt, deze doorgaat naar het tarieven scherm.
            var tarief = new Tarieven_Tab();
            this.Hide();
            tarief.ShowDialog();
            this.Close();
        }

        private void Reserveer_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Reserveren" drukt, deze doorgaat naar het reserveren scherm.

            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }

        private void Recenties_Click(object sender, EventArgs e)
        {
            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
            this.Close();
        }

        private void Contacten_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Contacten" drukt, deze doorgaat naar het contact scherm.

            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Account" drukt, deze doorgaat naar het login scherm.

            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }
    }
}
