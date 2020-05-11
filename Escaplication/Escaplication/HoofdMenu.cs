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
        }
        //Escape room informatie link
        private void Label1_Click(object sender, EventArgs e)
        {
            var thema = new Informatie();
            this.Hide();
            thema.ShowDialog();
            this.Close();
        }

        private void Informatie_Click(object sender, EventArgs e)
        {
            var thema = new Informatie();
            this.Hide();
            thema.ShowDialog();
            this.Close();
        }
        //Locatie en contactgegevens link
        private void LocatieContact_Click(object sender, EventArgs e)
        {
            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }
        //Resereer link
        private void Reserveren_Click(object sender, EventArgs e)
        {
            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();

        }

        private void Reserveertekst_Click(object sender, EventArgs e)
        {
            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }

        //Escape room Recensies
        private void Recensies_Click(object sender, EventArgs e)
        {
            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
            this.Close();
        }

        private void RecensieText_Click(object sender, EventArgs e)
        {
            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
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
