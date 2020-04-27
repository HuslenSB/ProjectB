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
            webBrowser1.Navigate("https://www.openstreetmap.org/search?query=wijnhaven%20107#map=19/51.91722/4.48405");
        }
        public System.Diagnostics.Process p = new System.Diagnostics.Process();
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p = System.Diagnostics.Process.Start("https://www.google.com/maps/dir//Wijnhaven+107,+3011+WN+Rotterdam/@51.9174734,4.4835233,17.26z/data=!4m8!4m7!1m0!1m5!1m1!1s0x47c4335dd6b0b5a3:0x3b8dcf047e6f0073!2m2!1d4.4839175!2d51.9173974");
        }
    }
}
