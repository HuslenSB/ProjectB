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
            Program.pagina = 1;
            Close();
        }

        private void Informatie_Click(object sender, EventArgs e)
        {
            Program.pagina = 1;
            Close();
        }
        //Locatie en contactgegevens link
        private void LocatieContact_Click(object sender, EventArgs e)
        {
            Program.pagina = 2;
            Close();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            Program.pagina = 2;
            Close();
        }
        //Resereer link
        private void Reserveren_Click(object sender, EventArgs e)
        {
            Program.pagina = 3;
            Close();
        }

        private void Reserveertekst_Click(object sender, EventArgs e)
        {
            Program.pagina = 3;
            Close();
        }

        //Escape room Recensies
        private void Recensies_Click(object sender, EventArgs e)
        {
            Program.pagina = 4;
            Close();
        }

        private void RecensieText_Click(object sender, EventArgs e)
        {
            Program.pagina = 4;
            Close();
        }
    }
}
