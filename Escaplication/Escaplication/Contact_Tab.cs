﻿using Project_B_informatie;
using System;
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
    public partial class Contact_Tab : Form
    {
        public Contact_Tab()
        {
            InitializeComponent();
            RoutePlanner.Navigate("https://www.openstreetmap.org/search?query=wijnhaven%20107#map=19/51.91722/4.48405");
        }
        public System.Diagnostics.Process GoogleMaps = new System.Diagnostics.Process();
        
        private void GoogleMapsRedirectlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoogleMaps = System.Diagnostics.Process.Start("https://www.google.com/maps/dir//Wijnhaven+107,+3011+WN+Rotterdam/@51.9174734,4.4835233,17.26z/data=!4m8!4m7!1m0!1m5!1m1!1s0x47c4335dd6b0b5a3:0x3b8dcf047e6f0073!2m2!1d4.4839175!2d51.9173974");
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
        private void Recenties_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Recenties" drukt, deze doorgaat naar het recenties scherm.

            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Contact_Tab_Load(object sender, EventArgs e)
        {

        }

        private void Openingstijdentxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
