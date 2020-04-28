using Escaplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_B_informatie
{
    public partial class Informatie : Form
    {
        public Informatie()
        {
            InitializeComponent();
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Homepage" drukt, deze teruggaat naar het begin scherm.

            var Hoofd = new HoofdMenu();
            this.Hide();
            Hoofd.ShowDialog();
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
    }
}
