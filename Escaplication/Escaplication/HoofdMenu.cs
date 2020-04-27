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
    public partial class HoofdMenu : Form
    {
        public HoofdMenu()
        {
            InitializeComponent();
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

        private void Hoofdpagina_Click(object sender, EventArgs e)
        {

        }
    }
}
