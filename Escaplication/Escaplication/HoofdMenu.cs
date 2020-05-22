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

        // Dit zijn de functies dat als je op iets klikt je naar de volgende pagina gaat.
        
        public void InformatieClick()
        {
            var thema = new Informatie();
            this.Hide();
            thema.ShowDialog();
            this.Close();
        }
        public void TarievenClick()
        {
            var tarief = new Tarieven_Tab();
            this.Hide();
            tarief.ShowDialog();
            this.Close();
        }
        public void ContactClick()
        {
            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }

        public void ReserveerClick()
        {
            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }
            
        public void RecensieClick()
        {
            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
            this.Close();
        }
        public HoofdMenu()
        {
            InitializeComponent();
        }

        // Onderstaande code is voor de afbeeldingen en de text.
        // Escape room informatie link.

        private void InformatieText_Click(object sender, EventArgs e)
        {
            InformatieClick();
        }

        private void Informatie_Click(object sender, EventArgs e)
        {
            InformatieClick();
        }

        // Locatie en contactgegevens link.

        private void LocatieContact_Click(object sender, EventArgs e)
        {
            ContactClick();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            ContactClick();
        }

        // Resereer link.

        private void Reserveren_Click(object sender, EventArgs e)
        {
            ReserveerClick();
        }

        private void Reserveertekst_Click(object sender, EventArgs e)
        {
            ReserveerClick();
        }
        
        // Recensie link.

        private void RecensieText_Click(object sender, EventArgs e)
        {
            RecensieClick();
        }

        private void Recensies_Click(object sender, EventArgs e)
        {
            RecensieClick();
        }

        // Onderstaande code is voor het menu.

        private void Thema_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Thema" drukt, deze doorgaat naar het informatie scherm.

            InformatieClick();
        }

        private void Tarieven_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Tarieven" drukt, deze doorgaat naar het tarieven scherm.

            TarievenClick();
        }

        private void Reserveer_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Reserveren" drukt, deze doorgaat naar het reserveren scherm.

            ReserveerClick();
        }

        private void Recenties_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Recensie" drukt, deze doorgaat naar het recensie scherm.

            RecensieClick();
        }

        private void Contacten_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Contacten" drukt, deze doorgaat naar het contact scherm.

            ContactClick();
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
